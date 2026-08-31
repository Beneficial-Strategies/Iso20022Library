# RequestToPayDebtorActivation.Demo

Lives under `demos/reda/` — the Request-to-Pay sagas this demonstrates are `reda` message family
(`reda.066`-`073`) sagas specifically; grouping by business area here mirrors the same `reda/`
folder the package itself uses, so it's visible at a glance which business areas have saga
coverage and which (e.g. `pain`) don't yet.

A small, runnable console app that proves `BeneficialStrategies.Iso20022.MassTransit.Sagas`
actually works — not a unit test, a live walkthrough. It runs the `DebtorActivationServiceProviderStateMachine`
saga through a real lifecycle, twice:

1. **A single episode, start to finish**: activation request → accepted → amendment →
   re-activated. Every step prints the saga's state loaded fresh from MySQL (a new `DbContext`,
   a new query, every time — not a cached in-process object), so what you see on screen is
   actually what's in the database.
2. **A fan-out proof**: one raw ISO 20022 message carrying *two* debtor activation line items,
   showing that it produces two independent saga instances with distinct `CorrelationId`s — the
   core architectural reason this package can't treat raw ISO messages as saga events directly
   (see the package's own README/CLAUDE.md notes on the batch/fan-out design).

Every message publish also prints a `[wire]` line showing the literal JSON bytes the consumer
deserialized from — proof that MassTransit's in-memory transport is not simply passing a shared
object reference between components in-process. It genuinely serializes on publish and
deserializes on consume, exactly as it would over a real broker. This was discovered the hard way
while building the Sagas package itself (see `WireSerializationObserver.cs`).

Source is annotated throughout with `SIMULATING:` notes explaining what real-world actor or step
each action stands in for.

## What this is not

Not a package, not published, not part of `src/iso20022.sln`. It exists purely to demonstrate the
Sagas package working end to end with real persistence and real serialization. See
`BeneficialStrategies.Iso20022.MassTransit.Sagas`'s own README for what the actual package
supports and doesn't.

## Running it

Requires Docker (for MySQL) and the .NET 8 SDK.

```bash
docker compose up -d      # starts a throwaway MySQL 8.4 container
dotnet run                # builds, connects, runs the full walkthrough
docker compose down -v    # tear down + wipe the persisted saga data when you're done
```

No migrations are used — the app calls `EnsureCreatedAsync()` against the demo database on
startup, since this is a throwaway schema with no upgrade history to manage.

### Pointing at your own MySQL instance instead

Set `RTP_DEMO_MYSQL_CONNECTION_STRING` before running and skip `docker compose up -d`:

```bash
export RTP_DEMO_MYSQL_CONNECTION_STRING="Server=myhost;Port=3306;Database=mydb;Uid=myuser;Pwd=mypassword;"
dotnet run
```

## Why net8.0, not net10.0

The Sagas library itself multi-targets `net8.0;net10.0`. This demo is pinned to `net8.0` only —
`MassTransit.EntityFrameworkCore` 8.5.10 requires EF Core 10 under a net10.0 target, but
`Pomelo.EntityFrameworkCore.MySql`'s latest stable release (9.0.0) caps at EF Core 9.x; no
net10-compatible MySQL provider exists upstream yet. See the `.csproj` comment for the exact
NuGet conflict this avoids.

## Layout

- `Program.cs` — the narrated walkthrough (DI/bus setup, both scenarios, final state dump).
- `Scenario.cs` — builds the raw ISO 20022 messages published during the walkthrough.
- `Persistence/DebtorActivationSagaDbContext.cs` — the real EF Core + MySQL saga repository
  configuration. Nested ISO record/choice/enum properties are persisted as JSON columns using
  the *same* `Iso20022JsonSerializerOptions.Default` the library uses for real wire payloads —
  not an ad hoc demo format.
- `Persistence/Iso20022JsonValueConverter.cs` — the EF Core value converters backing that.
- `Diagnostics/WireSerializationObserver.cs` — prints the real serialized bytes each consumer
  deserializes from, proving genuine serialization is happening on every hop.
- `docker-compose.yml` — throwaway MySQL 8.4 instance for local runs.
