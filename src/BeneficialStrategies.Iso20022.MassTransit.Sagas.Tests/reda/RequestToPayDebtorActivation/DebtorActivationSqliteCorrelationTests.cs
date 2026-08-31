// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using static BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.DebtorActivationFixtures;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;

/// <summary>
/// Mirrors <see cref="reda.RequestToPayCreditorEnrolment.CreditorEnrolmentSqliteCorrelationTests"/> for
/// this saga family — see that class's remarks for the full rationale (the bug class this guards
/// against, why SQLite is a genuine proxy for "does this translate to real SQL," and the template
/// this establishes for future saga families).
/// </summary>
public class DebtorActivationSqliteCorrelationTests
{
    private sealed class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<DebtorActivationSagaState> Sagas => Set<DebtorActivationSagaState>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DebtorActivationSagaState>(b =>
            {
                b.HasKey(x => x.CorrelationId);
                b.Property(x => x.CurrentState).HasMaxLength(64).IsRequired();
                b.Property(x => x.LastMessageIdentification).HasMaxLength(35).IsRequired();
                b.Property(x => x.OriginalMessageIdentification).HasMaxLength(35).IsRequired();
                b.Property(x => x.PartyIdentityKey).HasMaxLength(256);

                // Not relevant to what this test class verifies (correlation-expression
                // translatability) — see class remarks.
                b.Ignore(x => x.Debtor);
                b.Ignore(x => x.Creditor);
                b.Ignore(x => x.DebtorSolutionProvider);
                b.Ignore(x => x.UltimateDebtor);
                b.Ignore(x => x.EffectiveActivationDate);
                b.Ignore(x => x.LastStatus);
                b.Ignore(x => x.ReviewApproved);
                b.Ignore(x => x.ReviewNote);
            });
        }
    }

    private static async Task<(
        ServiceProvider Provider,
        SqliteConnection Connection,
        ITestHarness Harness,
        ISagaStateMachineTestHarness<DebtorActivationServiceProviderStateMachine, DebtorActivationSagaState> SagaHarness
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
                cfg.AddSagaStateMachine<DebtorActivationServiceProviderStateMachine, DebtorActivationSagaState>()
                    .EntityFrameworkRepository(r =>
                    {
                        r.ConcurrencyMode = ConcurrencyMode.Pessimistic;
                        r.AddDbContext<DbContext, TestDbContext>((_, builder) => builder.UseSqlite(connection));
                        r.UseSqlite();
                    });
                cfg.AddConsumer<Consumers.DebtorActivationRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationAmendmentRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationCancellationRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationStatusReportConsumer>();

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
            DebtorActivationServiceProviderStateMachine,
            DebtorActivationSagaState
        >();

        return (provider, connection, harness, sagaHarness);
    }

    /// <summary>
    /// Polls the REAL database for the saga's current state — see
    /// <c>CreditorEnrolmentSqliteCorrelationTests.WaitForStateAsync</c>'s remarks for why
    /// <c>sagaHarness.Created</c>'s captured <c>.Saga</c> reference can't be trusted here (it's a
    /// point-in-time snapshot from creation, never touched again by an EF Core-backed repository's
    /// fresh-DbContext-per-event loads) and why <c>Consumed.Any(...)</c> alone doesn't prove the
    /// database transaction has committed yet either.
    /// </summary>
    private static async Task<DebtorActivationSagaState> WaitForStateAsync(
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

    [Fact]
    public async Task AmendmentAfterActivated_CorrelatesAndFoldsBackToActivated_ViaRealSqlTranslation()
    {
        var (provider, connection, harness, _) = await StartHarnessAsync();
        await using var _p = provider;
        await using var __ = connection;

        await harness.Bus.Publish(ARequest("MSG-201"));
        var correlationId = await WaitForCreatedAsync(provider, "MSG-201");

        await harness.Bus.Publish(AStatusReport("MSG-202", "MSG-201", ServiceRequestStatus1Code.Accepted));
        await WaitForStateAsync(provider, correlationId, "Activated");

        await harness.Bus.Publish(AAmendment("MSG-203", "MSG-201"));
        await WaitForStateAsync(provider, correlationId, "AwaitingAmendmentResult");

        await harness.Bus.Publish(AStatusReport("MSG-204", "MSG-203", ServiceRequestStatus1Code.Accepted));
        await WaitForStateAsync(provider, correlationId, "Activated");
    }

    [Fact]
    public async Task OrphanStatusReport_CorrelatesToNothing_ViaRealSqlTranslation()
    {
        var (provider, connection, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;
        await using var __ = connection;

        await harness.Bus.Publish(AStatusReport("MSG-301", "NEVER-SENT", ServiceRequestStatus1Code.Accepted));
        Assert.True(await harness.Consumed.Any<RequestToPayDebtorActivationStatusReportV02>());

        Assert.False(await sagaHarness.Created.Any());
    }
}
