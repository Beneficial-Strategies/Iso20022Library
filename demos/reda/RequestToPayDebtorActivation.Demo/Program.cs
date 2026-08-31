// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RequestToPayDebtorActivation.Demo;
using RequestToPayDebtorActivation.Demo.Diagnostics;
using RequestToPayDebtorActivation.Demo.Persistence;

// SIMULATING: the connection string a deployment would supply via configuration/secrets — here
// just an environment variable override with a default matching this demo's own docker-compose.yml.
var connectionString =
    Environment.GetEnvironmentVariable("RTP_DEMO_MYSQL_CONNECTION_STRING")
    ?? "Server=127.0.0.1;Port=3306;Database=rtp_debtor_activation_demo;Uid=root;Pwd=demo_password;";

Banner("BeneficialStrategies.Iso20022.MassTransit.Sagas — live demo");
Console.WriteLine("Debtor Activation saga, run through to conclusion twice: once as a single");
Console.WriteLine("episode (request -> activated -> amendment -> re-activated), once as a 2-line-");
Console.WriteLine("item batch proving the fan-out design. Saga state persists to real MySQL between");
Console.WriteLine("every step, and every message genuinely round-trips through JSON on the bus (see");
Console.WriteLine("the gray [wire] lines below).");
Console.WriteLine();

var services = new ServiceCollection();
services.AddLogging(b => b.AddSimpleConsole(o => o.SingleLine = true).SetMinimumLevel(LogLevel.Warning));

// Registered separately from the saga repository's own internal DbContext wiring below (its
// AddDbContext<DbContext, TImplementation> call configures EF Core FOR the saga repository, but
// doesn't expose DebtorActivationSagaDbContext as a directly resolvable service) — this app also
// wants to query the same database directly, to prove state really landed in MySQL rather than
// just trusting the saga repository's own internal reads.
services.AddDbContext<DebtorActivationSagaDbContext>(builder =>
    builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

services.AddMassTransit(x =>
{
    // SIMULATING: exactly the repository configuration a production deployment of this saga
    // would use — MassTransit loads/saves the saga instance from/to MySQL on every correlated
    // event through this repository. Nothing here is demo-only.
    x.AddSagaStateMachine<DebtorActivationServiceProviderStateMachine, DebtorActivationSagaState>()
        .EntityFrameworkRepository(r =>
        {
            // Pessimistic locking pairs with UseMySql()'s row-locking statement provider below —
            // MySQL lacks the same optimistic-concurrency/rowversion story MassTransit's EF Core
            // integration uses for SQL Server/Postgres.
            r.ConcurrencyMode = ConcurrencyMode.Pessimistic;
            r.AddDbContext<DbContext, DebtorActivationSagaDbContext>(
                (_, builder) => builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );
            r.UseMySql();
        });

    x.AddConsumer<DebtorActivationRequestConsumer>();
    x.AddConsumer<DebtorActivationAmendmentRequestConsumer>();
    x.AddConsumer<DebtorActivationCancellationRequestConsumer>();
    x.AddConsumer<DebtorActivationStatusReportConsumer>();

    x.UsingInMemory(
        (context, busCfg) =>
        {
            // SIMULATING: the same converter-merge step any real deployment of this package needs
            // (documented in the package README) — without it, ValueList<T> deserialization fails
            // at runtime. This is also the reason MassTransit's "in-memory" transport is a valid
            // stand-in for a real broker in this demo: it runs every message through this same
            // JSON serializer, not just an in-process object reference.
            busCfg.ConfigureJsonSerializerOptions(options =>
            {
                foreach (var converter in Iso20022JsonSerializerOptions.Default.Converters)
                    options.Converters.Add(converter);
                return options;
            });
            busCfg.ConfigureEndpoints(context);
        }
    );
});

await using var provider = services.BuildServiceProvider(validateScopes: true);

// SIMULATING: the schema/migration step a deployment pipeline would run ahead of time —
// simplified to EnsureCreated since this is a throwaway demo database with no upgrade history.
// Wiped first: this app hardcodes its scenario's message ids (DEMO-REQ-001 etc.), so without a
// clean slate a rerun against the same persistent container would leave stale rows from earlier
// runs sharing those same ids — ambiguous for the polling queries below, not a reflection of
// anything wrong with the saga itself. A real deployment would never do this on startup.
await using (var scope = provider.CreateAsyncScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DebtorActivationSagaDbContext>();
    await db.Database.EnsureDeletedAsync();
    await db.Database.EnsureCreatedAsync();
    Console.WriteLine($"MySQL schema ready, clean slate (table: debtor_activation_saga, connection: {SafeConnectionSummary(connectionString)})");
}

var busControl = provider.GetRequiredService<IBusControl>();
busControl.ConnectConsumeObserver(new WireSerializationObserver());
await busControl.StartAsync();

try
{
    await RunSingleEpisodeAsync(busControl, provider);
    await RunFanOutBatchAsync(busControl, provider);
    await PrintFinalTableAsync(provider);
}
finally
{
    await busControl.StopAsync();
}

Banner("Done");

// ---------------------------------------------------------------------------------------------

async Task RunSingleEpisodeAsync(IBusControl bus, IServiceProvider services)
{
    Banner("Part 1: one debtor's activation episode, start to finish");

    const string requestId = "DEMO-REQ-001";
    Step($"Publishing DebtorActivationRequest ({requestId}) — Debtor's RTP Service Provider submits activation");
    await bus.Publish(Scenario.ActivationRequest(requestId));
    var afterRequest = await WaitForStateAsync(services, requestId, "AwaitingActivationResult");
    PrintState("after Request", afterRequest);

    const string statusId1 = "DEMO-STA-002";
    Step($"Publishing StatusReport ({statusId1}, Accepted) — Creditor side reports activation accepted");
    await bus.Publish(Scenario.StatusReport(statusId1, requestId, ServiceRequestStatus1Code.Accepted, DateOnly.FromDateTime(DateTime.UtcNow)));
    var afterAccept = await WaitForStateAsync(services, requestId, "Activated");
    PrintState("after StatusReport (Accepted)", afterAccept);

    const string amendmentId = "DEMO-AMD-003";
    Step($"Publishing AmendmentRequest ({amendmentId}, referencing original {requestId}) — Debtor updates the activation");
    await bus.Publish(Scenario.AmendmentRequest(amendmentId, requestId));
    var afterAmendment = await WaitForStateAsync(services, requestId, "AwaitingAmendmentResult");
    PrintState("after AmendmentRequest", afterAmendment);
    Console.WriteLine(
        $"    (correlated via OriginalMessageIdentification={afterAmendment?.OriginalMessageIdentification} "
            + $"— NOT LastMessageIdentification, which is now {afterAmendment?.LastMessageIdentification})"
    );

    const string statusId2 = "DEMO-STA-004";
    Step($"Publishing StatusReport ({statusId2}, Accepted, referencing amendment {amendmentId}) — amendment accepted, folds back");
    await bus.Publish(Scenario.StatusReport(statusId2, amendmentId, ServiceRequestStatus1Code.Accepted, DateOnly.FromDateTime(DateTime.UtcNow)));
    var final = await WaitForStateAsync(services, requestId, "Activated");
    PrintState("CONCLUSION", final);
}

async Task RunFanOutBatchAsync(IBusControl bus, IServiceProvider services)
{
    Banner("Part 2: fan-out proof — one wire message, two debtors, two independent sagas");
    Console.WriteLine("This is the architectural reason a raw ISO message can't be a saga Event<T>");
    Console.WriteLine("directly: RequestToPayDebtorActivationRequestV02 carries a *list* of line");
    Console.WriteLine("items. DebtorActivationRequestConsumer fans each one out into its own");
    Console.WriteLine("internal event, and MassTransit correlates each to its own saga instance.");
    Console.WriteLine();

    const string batchRequestId = "DEMO-BATCH-001";
    var batchMessage = new RequestToPayDebtorActivationRequestV02
    {
        Header = new ActivationHeader3
        {
            CreationDateTime = DateTime.UtcNow,
            InitiatingParty = Scenario.Party("Contoso Bank — Debtor RTP Service Provider"),
            MessageIdentification = batchRequestId,
        },
        ElectronicInvoiceData = new ElectronicInvoice1 { PresentmentType = PresentmentType1Code.Full },
        DebtorActivation =
        [
            new DebtorActivation5
            {
                Debtor = Scenario.Party("Jane Debtor"),
                Creditor = Scenario.Party("Acme Utility Co."),
                DebtorSolutionProvider = Scenario.Party("Contoso Bank Digital Channels"),
            },
            new DebtorActivation5
            {
                Debtor = Scenario.Party("John Debtor"),
                Creditor = Scenario.Party("Acme Utility Co."),
                DebtorSolutionProvider = Scenario.Party("Contoso Bank Digital Channels"),
            },
        ],
    };

    Step($"Publishing ONE RequestToPayDebtorActivationRequestV02 ({batchRequestId}) with 2 line items");
    await bus.Publish(batchMessage);

    // Both line items share the same wire MessageIdentification (it's the whole batch's header),
    // so we can't distinguish them by OriginalMessageIdentification alone — poll by count instead.
    var rows = await WaitForRowCountAsync(services, batchRequestId, expectedCount: 2);
    Console.WriteLine($"    {rows.Count} independent saga rows created from 1 published message, distinct CorrelationIds:");
    foreach (var row in rows)
        Console.WriteLine($"      {row.CorrelationId} — Debtor={row.Debtor?.Name}, state={row.CurrentState}");
}

async Task PrintFinalTableAsync(IServiceProvider services)
{
    Banner("Final MySQL state (fresh SELECT, not cached in-process objects)");
    await using var scope = services.CreateAsyncScope();
    var db = scope.ServiceProvider.GetRequiredService<DebtorActivationSagaDbContext>();
    var all = await db.Sagas.AsNoTracking().OrderBy(x => x.CreatedUtc).ToListAsync();
    foreach (var s in all)
        Console.WriteLine(
            $"  {s.CorrelationId}  state={s.CurrentState,-24} debtor={s.Debtor?.Name,-14} originalMsgId={s.OriginalMessageIdentification}"
        );
}

async Task<DebtorActivationSagaState?> WaitForStateAsync(
    IServiceProvider services,
    string originalMessageId,
    string expectedState,
    TimeSpan? timeout = null
)
{
    var deadline = DateTime.UtcNow + (timeout ?? TimeSpan.FromSeconds(10));
    while (DateTime.UtcNow < deadline)
    {
        // A fresh scope + fresh DbContext each poll — this is a genuine round-trip to MySQL, not
        // a read of an EF Core change-tracker cache from an earlier query.
        await using var scope = services.CreateAsyncScope();
        var db = scope.ServiceProvider.GetRequiredService<DebtorActivationSagaDbContext>();
        var state = await db
            .Sagas.AsNoTracking()
            .Where(x => x.OriginalMessageIdentification == originalMessageId)
            .OrderByDescending(x => x.CreatedUtc)
            .FirstOrDefaultAsync();
        if (state is { CurrentState: var current } && current == expectedState)
            return state;
        await Task.Delay(100);
    }

    throw new TimeoutException(
        $"Saga for original message {originalMessageId} never reached state '{expectedState}' within the timeout."
    );
}

async Task<List<DebtorActivationSagaState>> WaitForRowCountAsync(
    IServiceProvider services,
    string batchMessageId,
    int expectedCount,
    TimeSpan? timeout = null
)
{
    var deadline = DateTime.UtcNow + (timeout ?? TimeSpan.FromSeconds(10));
    while (DateTime.UtcNow < deadline)
    {
        await using var scope = services.CreateAsyncScope();
        var db = scope.ServiceProvider.GetRequiredService<DebtorActivationSagaDbContext>();
        var rows = await db.Sagas.AsNoTracking().Where(x => x.LastMessageIdentification == batchMessageId).ToListAsync();
        if (rows.Count >= expectedCount)
            return rows;
        await Task.Delay(100);
    }

    throw new TimeoutException($"Expected {expectedCount} saga rows for batch {batchMessageId} within the timeout.");
}

void PrintState(string label, DebtorActivationSagaState? state)
{
    if (state is null)
    {
        Console.WriteLine($"    [{label}] (not found)");
        return;
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"    [{label}] loaded fresh from MySQL: CorrelationId={state.CorrelationId}, State={state.CurrentState}");
    Console.ResetColor();
    Console.WriteLine(
        $"      Debtor={state.Debtor?.Name}, Creditor={state.Creditor?.Name}, LastStatus={state.LastStatus}, "
            + $"EffectiveActivationDate={DescribeChoice(state.EffectiveActivationDate)}"
    );
}

string DescribeChoice(DateAndDateTime2Choice_? choice) =>
    choice switch
    {
        DateAndDateTime2Choice.Date d => d.Value.ToString(),
        DateAndDateTime2Choice.DateTime dt => dt.Value.ToString(),
        null => "(none)",
        _ => choice.ToString() ?? "(unknown)",
    };

string SafeConnectionSummary(string cs)
{
    // Never print credentials, even for a throwaway demo password — just the bits useful to
    // confirm you're pointed at the right server.
    var parts = cs.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    var kept = parts.Where(p => p.StartsWith("Server=", StringComparison.OrdinalIgnoreCase) || p.StartsWith("Database=", StringComparison.OrdinalIgnoreCase));
    return string.Join(";", kept);
}

void Banner(string title)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(new string('=', title.Length + 4));
    Console.WriteLine($"= {title} =");
    Console.WriteLine(new string('=', title.Length + 4));
    Console.ResetColor();
}

void Step(string description)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"--> {description}");
    Console.ResetColor();
}
