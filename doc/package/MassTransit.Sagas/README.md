# Beneficial Strategies ISO 20022 MassTransit Sagas

A [MassTransit](https://masstransit.io) saga toolkit correlated to ISO 20022 message flows, built
on top of the strongly-typed message model published in
[`BeneficialStrategies.Iso20022`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022).

## Why this package exists

The ISO 20022 specification describes message *shapes* in exhaustive machine-readable detail, but
says nothing machine-readable about *sequencing* — which message triggers which response, what
order things happen in, who initiates versus who responds. That knowledge lives only in narrative
Message Definition Report (MDR) documents published per message set on
[iso20022.org](https://www.iso20022.org). This package is the result of reading one such document
(the Request-to-Pay Service MDR Part 1) closely enough to derive real state machines from it, and
is intentionally scoped to that one flow as a proof of concept — not a generalized
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
  document, not saga-worthy, and are not covered by this first release.

## Registration

```csharp
services.AddCreditorEnrolmentSaga(
    configureBus: bus => bus.UsingInMemory((context, cfg) => cfg.ConfigureEndpoints(context)),
    configureRepository: r => r.InMemoryRepository());
```

Swap `configureRepository` for your production persistence, and `configureBus` for your real
transport, when you're ready to deploy.
