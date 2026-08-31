// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using static BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.CreditorEnrolmentFixtures;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment;

/// <summary>
/// Regression coverage for a bug class discovered 2026-08-30 while building the
/// <c>RequestToPayDebtorActivation.Demo</c> app: a saga's <c>CorrelateBy</c> predicate that calls a
/// helper method taking the saga <c>state</c> as an argument compiles and runs fine against
/// MassTransit's in-memory saga repository (which just compiles-and-invokes the expression), but
/// throws <c>InvalidOperationException: ... could not be translated</c> at runtime against any real
/// relational EF Core saga repository (SQL Server, Postgres, MySQL, SQLite) — because
/// <c>CorrelateBy</c> takes an <c>Expression&lt;Func&lt;TSaga, ConsumeContext&lt;TMessage&gt;,
/// bool&gt;&gt;</c> that a real repository pushes down to SQL via <c>IQueryable</c>, and an opaque
/// method call referencing the queryable's row parameter cannot be translated. See
/// <see cref="CreditorEnrolmentServiceProviderStateMachine"/>'s class-level remarks on the
/// <c>AmendmentRequested</c> event registration for the full story and the fix that was applied.
/// </summary>
/// <remarks>
/// This class backs <see cref="CreditorEnrolmentServiceProviderStateMachine"/>'s follow-up-event
/// correlation with a REAL relational EF Core saga repository (SQLite, an in-memory database — no
/// external server needed, fast enough for every normal <c>dotnet test</c> run) instead of the
/// trivial in-memory MassTransit repository <see cref="CreditorEnrolmentServiceProviderStateMachineTests"/>
/// uses, specifically so a future change that reintroduces a helper-method-taking-<c>state</c>
/// correlation predicate fails a test immediately instead of only surfacing against a real
/// deployment's database — which is exactly what happened here.
///
/// SQLite's LINQ-to-SQL translator uses the same relational translation pipeline architecture as
/// SQL Server/Postgres/MySQL (unlike EF Core's InMemory provider, which has its own much looser,
/// non-representative translation path and would NOT have caught this bug) — so this genuinely
/// exercises the class of failure that matters, even though it isn't literally MySQL. Only the
/// scalar columns the correlation predicates themselves reference are mapped; the saga's other
/// (complex ISO record/choice) properties are <c>Ignore</c>d — this suite is about correlation
/// translatability, not persisted-value fidelity (see <c>RequestToPayDebtorActivation.Demo</c> for
/// that, verified against real MySQL).
///
/// TEMPLATE FOR FUTURE SAGAS: any new saga family added to this package should get an equivalent
/// test class following this same shape — a minimal EF Core <see cref="DbContext"/> mapping just
/// the saga's own scalar/correlation columns, backed by an open in-memory <see cref="SqliteConnection"/>,
/// running the same follow-up-event scenarios the in-memory tests already cover.
/// </remarks>
public class CreditorEnrolmentSqliteCorrelationTests
{
    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<CreditorEnrolmentSagaState> Sagas => Set<CreditorEnrolmentSagaState>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditorEnrolmentSagaState>(b =>
            {
                b.HasKey(x => x.CorrelationId);
                b.Property(x => x.CurrentState).HasMaxLength(64).IsRequired();
                b.Property(x => x.LastMessageIdentification).HasMaxLength(35).IsRequired();
                b.Property(x => x.OriginalMessageIdentification).HasMaxLength(35).IsRequired();
                b.Property(x => x.PartyIdentityKey).HasMaxLength(256);

                // Not relevant to what this test class verifies (correlation-expression
                // translatability) — see class remarks.
                b.Ignore(x => x.Creditor);
                b.Ignore(x => x.MerchantCategoryCode);
                b.Ignore(x => x.UltimateCreditor);
                b.Ignore(x => x.EffectiveEnrolmentDate);
                b.Ignore(x => x.LastStatus);
                b.Ignore(x => x.ReviewApproved);
                b.Ignore(x => x.ReviewNote);
            });
        }
    }

    /// <summary>
    /// A single open connection for the lifetime of the harness — SQLite's <c>:memory:</c>
    /// database is destroyed the moment its owning connection closes, so this must be kept alive
    /// (and reused, not reopened) for every DbContext instance the saga repository creates.
    /// </summary>
    private static async Task<(
        ServiceProvider Provider,
        SqliteConnection Connection,
        ITestHarness Harness,
        ISagaStateMachineTestHarness<CreditorEnrolmentServiceProviderStateMachine, CreditorEnrolmentSagaState> SagaHarness
    )> StartHarnessAsync()
    {
        var connection = new SqliteConnection("DataSource=:memory:");
        await connection.OpenAsync();

        var services = new ServiceCollection();

        // Registered separately from the saga repository's own internal DbContext wiring below
        // (its AddDbContext<DbContext, TImplementation> call configures EF Core FOR the saga
        // repository, but doesn't expose TestDbContext as a directly resolvable service) — this
        // harness also needs to resolve it directly, to run EnsureCreatedAsync.
        services.AddDbContext<TestDbContext>(builder => builder.UseSqlite(connection));

        var provider = services.AddMassTransitTestHarness(cfg =>
            {
                cfg.AddSagaStateMachine<CreditorEnrolmentServiceProviderStateMachine, CreditorEnrolmentSagaState>()
                    .EntityFrameworkRepository(r =>
                    {
                        r.ConcurrencyMode = ConcurrencyMode.Pessimistic;
                        r.AddDbContext<DbContext, TestDbContext>((_, builder) => builder.UseSqlite(connection));
                        r.UseSqlite();
                    });
                cfg.AddConsumer<Consumers.CreditorEnrolmentRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentAmendmentRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentCancellationRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentStatusReportConsumer>();

                // Same requirement as the in-memory-repository tests — see that class's remarks.
                cfg.UsingInMemory(
                    (context, busCfg) =>
                    {
                        busCfg.ConfigureJsonSerializerOptions(options =>
                        {
                            foreach (var converter in Iso20022JsonSerializerOptions.Default.Converters)
                                options.Converters.Add(converter);
                            return options;
                        });
                        busCfg.ConfigureEndpoints(context);
                    }
                );
            })
            .BuildServiceProvider(true);

        await using (var scope = provider.CreateAsyncScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<TestDbContext>();
            await db.Database.EnsureCreatedAsync();
        }

        var harness = provider.GetRequiredService<ITestHarness>();
        await harness.Start();

        var sagaHarness = harness.GetSagaStateMachineHarness<
            CreditorEnrolmentServiceProviderStateMachine,
            CreditorEnrolmentSagaState
        >();

        return (provider, connection, harness, sagaHarness);
    }

    /// <summary>
    /// Polls the REAL database for the saga's current state, rather than trusting
    /// <c>sagaHarness.Created</c>'s captured <c>.Saga</c> reference. That reference is a
    /// point-in-time snapshot from when the saga was first created — the in-memory repository
    /// mutates that same object in place on every later transition, so the other test classes'
    /// "just read <c>.Created</c> again" pattern happens to work there, but an EF Core-backed
    /// repository loads a FRESH entity into a new <c>DbContext</c> for every correlated event and
    /// never touches the original object again — so the harness's snapshot stays frozen at
    /// whatever state it had at creation. This also sidesteps a related trap: `Consumed.Any(...)`
    /// only proves the transport delivered/processed the message, not that the saga repository's
    /// database transaction has actually committed by the time this returns.
    /// </summary>
    private static async Task<CreditorEnrolmentSagaState> WaitForStateAsync(
        IServiceProvider provider,
        Guid correlationId,
        string expectedState,
        TimeSpan? timeout = null
    )
    {
        var deadline = DateTime.UtcNow + (timeout ?? TimeSpan.FromSeconds(10));
        while (DateTime.UtcNow < deadline)
        {
            await using var scope = provider.CreateAsyncScope();
            var db = scope.ServiceProvider.GetRequiredService<TestDbContext>();
            var state = await db.Sagas.AsNoTracking().FirstOrDefaultAsync(x => x.CorrelationId == correlationId);
            if (state is { CurrentState: var current } && current == expectedState)
                return state;
            await Task.Delay(20);
        }

        throw new TimeoutException($"Saga {correlationId} never reached state '{expectedState}' within the timeout.");
    }

    private static async Task<Guid> WaitForCreatedAsync(IServiceProvider provider, string originalMessageId)
    {
        var deadline = DateTime.UtcNow + TimeSpan.FromSeconds(10);
        while (DateTime.UtcNow < deadline)
        {
            await using var scope = provider.CreateAsyncScope();
            var db = scope.ServiceProvider.GetRequiredService<TestDbContext>();
            var state = await db
                .Sagas.AsNoTracking()
                .FirstOrDefaultAsync(x => x.OriginalMessageIdentification == originalMessageId);
            if (state is not null)
                return state.CorrelationId;
            await Task.Delay(20);
        }

        throw new TimeoutException($"No saga for original message {originalMessageId} was created within the timeout.");
    }

    /// <summary>
    /// The scenario that actually reproduces the original bug: Amendment must correlate via
    /// <c>OriginalMessageIdentification</c> — which by this point in the flow is NOT the same
    /// value as <c>LastMessageIdentification</c> (the StatusReport already moved that on) — a
    /// helper-method-based predicate that only "worked" against the in-memory repository would
    /// throw here against a real SQL translator.
    /// </summary>
    [Fact]
    public async Task AmendmentAfterEnrolled_CorrelatesAndFoldsBackToEnrolled_ViaRealSqlTranslation()
    {
        var (provider, connection, harness, _) = await StartHarnessAsync();
        await using var _p = provider;
        await using var __ = connection;

        await harness.Bus.Publish(ARequest("MSG-201"));
        var correlationId = await WaitForCreatedAsync(provider, "MSG-201");

        await harness.Bus.Publish(AStatusReport("MSG-202", "MSG-201", ServiceRequestStatus1Code.Accepted));
        await WaitForStateAsync(provider, correlationId, "Enrolled");

        await harness.Bus.Publish(AAmendment("MSG-203", "MSG-201"));
        await WaitForStateAsync(provider, correlationId, "AwaitingAmendmentResult");

        await harness.Bus.Publish(AStatusReport("MSG-204", "MSG-203", ServiceRequestStatus1Code.Accepted));
        await WaitForStateAsync(provider, correlationId, "Enrolled");
    }

    [Fact]
    public async Task OrphanStatusReport_CorrelatesToNothing_ViaRealSqlTranslation()
    {
        var (provider, connection, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;
        await using var __ = connection;

        await harness.Bus.Publish(AStatusReport("MSG-301", "NEVER-SENT", ServiceRequestStatus1Code.Accepted));
        Assert.True(await harness.Consumed.Any<RequestToPayCreditorEnrolmentStatusReportV02>());

        Assert.False(await sagaHarness.Created.Any());
    }
}
