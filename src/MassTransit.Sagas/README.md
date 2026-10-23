# Beneficial Strategies ISO 20022 MassTransit Sagas

> **Status: proof of concept only. Not published, and not planned to be.**
>
> This package exists to show what ISO 20022 message flows look like as [MassTransit](https://masstransit.io) sagas. It is **not published
> to NuGet and is not scheduled for publication**; it is not on the roadmap, and nothing should be built on it. Its API and design may change,
> or it may be removed, without notice.
>
> It lives in this monorepo only so that it evolves in lockstep with the rest of the family while it is being explored. **If it is ever
> pursued, it will probably move to a repository of its own, and may be licensed differently** from the packages here. Treat it as a reference
> and a worked example, not as a dependency.

A saga toolkit correlated to ISO 20022 message flows, written against the **interfaces** of the message model
([`BeneficialStrategies.Iso20022.Messages`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Messages)), so it does not need the
message records.

## Why this package exists

The ISO 20022 specification describes message *shapes* in exhaustive machine-readable detail, but
says nothing machine-readable about *sequencing* — which message triggers which response, what
order things happen in, who initiates versus who responds. That knowledge lives only in narrative
Message Definition Report (MDR) documents published per message set on
[iso20022.org](https://www.iso20022.org). This package is the result of reading one such document
(the Request-to-Pay Service MDR Part 1) closely enough to derive real state machines from it, and
is intentionally scoped to that one flow, as a proof of concept: not a generalized
"generate a saga for any ISO 20022 message set" pipeline.

## What's included

Two independent [MassTransit state machines](https://masstransit.io/documentation/patterns/saga/state-machine),
one per RTP sub-process, each representing the perspective of the one actor in that sub-process
that actually needs multi-message lifecycle tracking:

- **`CreditorEnrolmentServiceProviderStateMachine`** — the Creditor/Payee's RTP Service Provider,
  tracking a creditor's enrolment through `RequestToPayCreditorEnrolmentRequestV02` →
  `...AmendmentRequestV02` / `...CancellationRequestV02` → `...StatusReportV02` (reda.066-069).
- **`DebtorActivationServiceProviderStateMachine`** — the Debtor/Payer's RTP Service Provider,
  tracking the same lifecycle shape for `RequestToPayDebtorActivationRequestV02` (reda.070-073).

Both message families wrap a **list** of line items per wire message — a single
`RequestToPayCreditorEnrolmentRequestV02` can report on several enrolments at once. This package's
fan-out consumers translate each batch message into one saga-facing event per line item, so one
saga instance always tracks exactly one enrolment/activation, never a whole batch.

## What's deliberately not included

- **No concrete persistence.** You supply your own `ISagaRepository<T>` — EF Core, MongoDB, Redis,
  or MassTransit's in-memory provider for tests/demos — via the `configureRepository` callback on
  `AddCreditorEnrolmentSaga`/`AddDebtorActivationSaga`.
- **No review, approval, or compliance logic.** The source ISO document does not specify any such
  step for this flow. `ReviewRequested`/`ReviewCompleted` exist as named hook points on the state
  machine with zero implementation — wire your own activities to them if your deployment needs a
  human-in-the-loop or OFAC-style check before an enrolment/activation is forwarded.
- **No outbound forwarding.** The state machines react to inbound events; sending the forwarded
  request on to a Directory Provider (or wherever your topology sends it next) is your own
  integration logic, since that depends entirely on your deployment.
- **The other two swim-lane actors per sub-process** (the RTP Directory Provider, and the
  Creditor's/Debtor's own originating systems) — those are reactive pass-throughs in the source
  document, not saga-worthy, and are not covered.

## Interfaces, not records

The consumers, events and saga state use the **interfaces** of the model (`IRequestToPayDebtorActivationRequestV02`, `IRTPPartyIdentification2`,
`Party53Choice.IOrganisationIdentification`, ...), so this package needs `Primitives` and `Interfaces` and **not**
`BeneficialStrategies.Iso20022.Common` (the 3,339 message records; #70). Your application decides what makes the objects: the records, or the
`Factory` package's `IsoDataFactory` (a test checks that this package does not reference `Common`). Consumers are bound to the interface, so a message
published as a record and one read from the wire by the factory reach the same consumer.

## JSON serialization

The events and the saga state carry these interfaces, and MassTransit moves them as JSON with `System.Text.Json`. Three things to know
(each is covered by `MassTransitJsonRoundTripTests`, and the first by the saga tests as well):

* **Register the library's converters and a factory, or events are lost or come out wrong.** MassTransit's default options cannot read a
  `ValueList<T>`, and for a member declared with an interface MassTransit makes an object of its own, which keeps the members but loses which
  variant of a choice it was. On the bus:

  ```csharp
  busCfg.ConfigureIso20022Json(new IsoDataFactory());   // IsoDataFactory is in the Factory package
  ```

  This registers the converters of `Iso20022JsonSerializerOptions.Default` and `Iso20022InterfaceJsonConverterFactory`, which reads an interface into
  the object the factory makes (first in the list, so that MassTransit's own interface converters do not get there first). Without the factory
  (`ConfigureIso20022Json()`), only records can be read; without either an event is silently never consumed and ends in the error queue.
  With them, an event with lists and a choice arrives with the same content and the same variants.
* **The registration is process-wide.** `ConfigureJsonSerializerOptions` changes MassTransit's shared options, not those of one bus: once
  any bus in the process has registered the converters, every bus has them, and one kind of factory is in force (two instances of the same kind
  are interchangeable). It also means a test that checks the failure without them depends on the order the tests run in.
* **The events use MassTransit's property names, not the ISO ones.** The wire form of an event is camelCase (`messageIdentification`,
  `initiatingParty`), which is fine between services of one team and is the format this package settles on for its events. A payload meant for
  another system should be written with the library's own serializer (`Iso20022JsonSerializer`), not by MassTransit.

## Project layout

Both state machines live under `reda/` (folder and namespace:
`BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.*`) — the ISO 20022 business area they
implement (Reference Data), matching the folder naming convention `BeneficialStrategies.Iso20022`
itself uses (`MessageDefinitions/reda/`). This is deliberate: it's meant to make it obvious at a
glance which business areas have saga coverage today (`reda`) and which don't yet (e.g. `pain`) —
a future business area's sagas would get their own sibling folder/namespace, not get folded into
`reda`. `Framework/` (shared saga-state base class, party-identity correlation helper) rounds out
the package, alongside the two registration surfaces below.

## Registration

Two ways to register, mirroring the sibling `BeneficialStrategies.Iso20022.FluentValidation`
package's own `AddIso20022Validators` — "register everything (optionally narrowed by business
area)" via reflection, or strongly-typed per-saga registration:

**Everything, or narrowed by business area** (`Iso20022ServiceCollectionExtensions`, package root)
— finds every saga state machine in the assembly via reflection and registers each one plus its
fan-out consumers, using one shared `ISagaRepositoryRegistrationProvider` for persistence. Compose
it *inside* your own `AddMassTransit`/`AddMassTransitTestHarness` call, the same way you'd use
MassTransit's own `AddConsumersFromNamespaceContaining`:

```csharp
services.AddMassTransitTestHarness(cfg =>
{
    cfg.AddIso20022Sagas(["reda"], new InMemorySagaRepositoryRegistrationProvider());
    cfg.UsingInMemory((context, busCfg) => busCfg.ConfigureEndpoints(context));
});
```

For real persistence, swap the provider (e.g. `new EntityFrameworkSagaRepositoryRegistrationProvider(r => r.UseSqlite(...))`
from `MassTransit.EntityFrameworkCore`) — it configures every registered saga uniformly. If
different sagas genuinely need different persistence strategies, use the strongly-typed methods
below instead.

*How "plus its fan-out consumers" happens without listing them:* there's no
`x.AddConsumer<CreditorEnrolmentRequestConsumer>()`-style line anywhere in
`AddIso20022Sagas`'s own code. Instead, once reflection has picked the saga state machines to
register (`CreditorEnrolmentServiceProviderStateMachine`, living in namespace
`BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment`), that
namespace becomes a filter for MassTransit's own `AddConsumersFromNamespaceContaining<T>` — which
does the actual assembly-wide `IConsumer<T>` scan:

```csharp
configurator.AddConsumersFromNamespaceContaining<AssemblyMarker>(consumerType =>
    registeredFamilyNamespaces.Any(ns =>
        (consumerType.Namespace ?? string.Empty).StartsWith(ns + ".", StringComparison.Ordinal)));
```

`CreditorEnrolmentRequestConsumer`, `...AmendmentRequestConsumer`, `...CancellationRequestConsumer`,
and `...StatusReportConsumer` all live under
`...RequestToPayCreditorEnrolment.Consumers` — a child of that same family namespace — so all four
match the prefix check and get registered with no per-type line needed. A saga that wasn't
selected (filtered out, or from a business area you didn't ask for) contributes nothing to
`registeredFamilyNamespaces`, so its own consumers are excluded the same way, automatically.

**Strongly-typed, per saga** (`Iso20022SagaServiceCollectionExtensions`, `reda/Extensions/`) — for
when you want independent control over each saga's own repository configuration:

```csharp
services.AddCreditorEnrolmentSaga(
    configureBus: bus => bus.UsingInMemory((context, cfg) => cfg.ConfigureEndpoints(context)),
    configureRepository: r => r.InMemoryRepository());
```

Swap `configureRepository` for your production persistence, and `configureBus` for your real
transport, when you're ready to deploy.
