# Messaging Building-Block Framework — Design Notes

**Status: tabled, not started.** This captures a design conversation that grew out of building
`BeneficialStrategies.Iso20022.MassTransit.Sagas`'s Request-to-Pay proof of concept. Nothing
below is implemented. Resume here rather than re-deriving it from scratch.

## How we got here

Building the two RTP sagas (Creditor Enrolment, Debtor Activation) surfaced a series of "wait,
how would this actually work in production" questions that go well beyond the RTP proof of
concept — they apply to essentially any ISO 20022 message flow this platform would process. The
RTP sagas may not even be the best example to keep developing against once this resumes (the
source MDR doesn't specify a human-review step, for one — see below), but the design questions
themselves are real and worth keeping.

## 1. The two deferred "pass-through" actors — not saga-worthy, but not nothing

Every RTP sub-process has two swim-lane actors we didn't build: the RTP Directory Provider, and
the Creditor's/Debtor's own originating system. The original plan correctly reasoned these don't
need a saga — a saga exists to correlate state *across* multiple messages over time, and these
actors handle each message once and are done (no later message needs matching back to an earlier
one). But "no saga needed" and "no handler needed" are different claims, and got conflated in the
shipped package README, which currently reads as "nothing needed for these actors." The original
plan's own wording was more precise:

> reactive pass-throughs, would be plain `IConsumer<T>` classes in a later pass, not designed here

**Action when resumed:** tighten the README/doc-comment wording to restore this distinction, and
actually design/build the plain `IConsumer<T>` pass-through handlers — they're a real gap, not an
intentional omission.

## 2. Outbound response routing — currently doesn't exist at all

Verified by grep, not assumed: neither `CreditorEnrolmentServiceProviderStateMachine` nor
`DebtorActivationServiceProviderStateMachine` contains a single `Publish`/`Send`/`RespondAsync`
call. Every `.Then(...)` activity only mutates `context.Saga.*` fields. The only `Publish` calls
anywhere in the package are internal, inside the fan-out consumers (raw ISO batch → per-line-item
event).

A real deployment needs two more outbound legs neither saga produces today:
- Forwarding the initiating request on to the Directory Provider.
- Reporting the final Enrolled/Rejected/Activated/Cancelled outcome back to the originator.

**Why `ConsumeContext.RespondAsync<T>()` doesn't fit:** it replies to the `ResponseAddress` set by
a caller using `IRequestClient<T>.GetResponse<T>()` — real request/response. This pipeline's entry
point is publish-based fan-out, so there's no `ResponseAddress` in scope by the time the saga
handles a per-line-item event, even in principle. More fundamentally, "the caller" here is a
*business party* reached through whatever topology a given deployment has for them (internal bus,
partner webhook, SFTP, API gateway...) — not a bus address this package could know.

**Proposed shape:** the saga `.Publish(...)`s an outbound-facing event at each meaningful
transition (e.g. `CreditorEnrolmentOutcomeDetermined`), and a caller-supplied consumer — one of
the pass-through actors from §1 — owns translating that into whatever the real external system
needs. Same "named hook, caller wires the real behavior" pattern already used for
`ReviewRequested`/`ReviewCompleted`.

## 3. Human review / approval workflow, as CQRS

**The scenario:** partner sends an ISO 20022 request → it shows up for review on someone's screen
→ they approve/reject/request more info → the saga updates from that decision → the correct ISO
20022 response is formed and sent back to the sender.

**Confirmed via grep:** `ReviewRequested`/`ReviewCompleted` are *declared* as `Event<T>`
properties on both state machines but appear nowhere else in either file — no `When(...)` inside
any `During(...)` block, no `CorrelateBy` registered. They are placeholders in name only; nothing
is wired.

**CQRS mapping onto MassTransit:**
- **Commands** (`bus.Send`, point-to-point, addressed to one saga instance) — `ApproveX`,
  `RejectX`, `RequestAdditionalInformation`. Handling one of these is exactly where the real
  outbound ISO 20022 response (§2) would get built and sent — the two gaps converge here.
- **Events** (`bus.Publish`, fan-out) — published *after* a command commits, for UI/read-model
  consumers (a SignalR hub, an audit log) to react to independently, decoupled from the write.
- **Correction to keep in mind:** atomicity comes from the saga repository's own transactional
  write when a correlated message triggers a transition — not from Send vs. Publish. Send vs.
  Publish is purely about routing/addressing (point-to-point vs. fan-out), not a transactional
  guarantee.

**New state needed:** something like `AwaitingReview` — doesn't exist in the current graph, which
only has `AwaitingEnrolmentResult`/`Enrolled`/`Rejected`/`AwaitingAmendmentResult`/
`AwaitingCancellationResult`/`Cancelled` (and the Debtor Activation mirror).

**Honest caveat:** the source MDR specifies no human-review step for this flow at all. Whatever
gets built here is a legitimate real-world extension, not something traceable to the standard —
keep it labeled that way in docs, same as the existing `ReviewRequested` comment already does.
Worth reconsidering whether RTP is even the best example flow to keep building this against.

## 4. `Incoming<T>` / `Outgoing<T>` — directional envelope

```csharp
public sealed record Incoming<TMessage>(TMessage Message, /* counterparty/RTN, receivedAtUtc, provenance, ... */)
    where TMessage : class, IOuterRecord;
public sealed record Outgoing<TMessage>(TMessage Message, /* ... */)
    where TMessage : class, IOuterRecord;
```

**Why this is more than cosmetic:** MassTransit routes/subscribes by message *type*. A pain.008
sent to you and a pain.008 sent by you are unrelated events despite the identical wire shape.
Wrapping direction into the type gives `IConsumer<Incoming<T>>` vs. `IConsumer<Outgoing<T>>` for
free — no runtime `if (direction == ...)` branching anywhere.

**Precedent already in this repo:** `XmlEnvelope<TMessage>`/`JsonEnvelope<TMessage>` in the
FluentValidation package, constrained `where TMessage : class, IOuterRecord` — but those wrap the
*raw pre-deserialization string* for validate-from-bytes scenarios. A different axis
(wire-format) than direction — composable with `Incoming`/`Outgoing`, not competing.

`Incoming<T>` never needs its own wire contract with a partner — an ingress adapter (SFTP, AS2/
AS4, HTTP API, whatever the rail is) deserializes the raw payload into the real `T`, then
constructs `Incoming<T>` purely as an internal bus envelope. Mirrors how the existing fan-out
consumers already work (raw ISO message in, internal event out), one level up.

## 5. Queue-naming convention

MassTransit's default endpoint-name formatter derives queue names from the consumer type; its
exact behavior for generic message types like `Incoming<CustomerCreditTransferInitiationV12>` has
not been empirically verified — do that before relying on it. A custom `IEndpointNameFormatter`
can force an explicit scheme (e.g. `pain008-incoming`/`pain008-outgoing`) if the default is ugly
or unpredictable.

**The real fork underneath the naming question:** does the RTN/institution belong in queue
*identity*, or in message *data*?
- **One queue per (direction, message type)**, RTN as envelope data, correlation handles
  per-instance routing. Simpler, recommended default.
- **One queue per (direction, message type, RTN)** — genuine per-institution isolation
  (independent scaling, blast-radius containment, possible regulatory segregation requirement) —
  but multiplies queue count by RTN count and is a transport-topology decision (partitioning
  support varies a lot between RabbitMQ/Azure Service Bus/Kafka), not something the envelope type
  itself solves.

Default to the first unless there's a specific operational/regulatory reason to segregate.

## 6. Multi-institution / "on-us" routing

**The reality:** the platform processes for multiple RTNs. An "on-us" transaction — both sender
and receiver RTN owned by the same platform — never needs external transmission.

**Proposed design:** `Outgoing<T>` → an on-us router (`IConsumer<Outgoing<T>>`, stateless — one of
the §1 pass-through family) → look up the destination RTN → if owned, synthesize and `Publish` the
matching `Incoming<T>` on the *same* bus (functionally identical to a real external round-trip
from every downstream consumer's perspective) → if not owned, hand off to whatever real external
dispatch mechanism exists.

**Open questions to resolve before building:**
1. **Where does "do we own this RTN" live?** A registry/lookup abstraction — see §7, this turns
   out to have a concrete answer.
2. **Message identity across the short-circuit.** For something like pain.008, the synthesized
   `Incoming<T>` likely carries the *same* message content/identification as the `Outgoing<T>` it
   came from (Bank XYZ needs to receive the literal instruction Bank ABC issued) — but this varies
   per message family; some replies are a genuinely different message type (a pain.008 out gets a
   pain.002 status report back, not another pain.008). Don't assume one shape fits every family.
3. **Provenance for audit/compliance**, even though processing is functionally identical. Banks
   generally need to report on-us vs. off-us volumes separately. Carry this as envelope metadata
   (`Incoming<T>.Provenance = OnUs`) that business logic ignores by default but compliance/
   reporting code can read — not a diverging code path.
4. **Atomicity across debit/credit legs.** A real clearing rail owns the settlement guarantee
   between two legs of a transaction. Once short-circuited internally, the platform owns that
   guarantee end-to-end — MassTransit doesn't give this for free across two independently-consumed
   messages. Be deliberate about this if a debit-then-credit sequence rides on the on-us path.

## 7. The Owned Institution Registry — itself a saga

**Verified via MCP, not guessed** (the user's own instinct was to check `acmt`/`admi`/`auth` —
none of those matched; the real family lives in `reda`, Reference Data, the same business area
both existing sagas are already under):

| Message | ISO ID | Role |
|---|---|---|
| `PartyCreationRequestV02` | `reda.014.001.02` | request to create party reference data |
| `PartyModificationRequestV02` | `reda.022.001.02` | request to update it |
| `PartyDeletionRequestV01` | `reda.031.001.01` | request to delete it |
| `PartyStatusAdviceV01` | `reda.016.001.01` | universal ack/nack for all three above |

Plus reporting/query companions (`PartyReportV02`, `PartyActivityAdviceV02`, `PartyQueryV01`,
`PartyAuditTrailQueryV01`/`ReportV02`). **All already exist as message model classes** under
`Common/MessageDefinitions/reda/` — no new ISO model work needed, correlated on
`SystemPartyIdentification`.

**Two things to be precise about:**
- **"Party" (ISO concept) ≠ "institution we own."** ISO 20022 has no concept of RTN ownership —
  that's proprietary policy. `IsOwned`/RTN-ownership would be a saga-state field *we* add, same
  pattern already established for `PartyIdentityKey`/`ReviewApproved` on the existing sagas —
  real, but explicitly documented as not-from-the-standard.
- **The soft-delete safety requirement needs a piece that isn't in the spec at all.**
  `PartyDeletionRequestV01` is a request to delete — nothing ISO-side models "don't actually
  finalize until all associated transactions are purged." That confirmation has to come from this
  system's own ledger/transaction store, which makes it necessarily a non-ISO command — same
  pattern as §3's approval commands. Proposed state graph:
  `Active → PendingDeletion (soft-delete, still resolvable/correlatable for anything referencing
  it) → Deleted (terminal, reachable ONLY via an internal confirmation command like
  ConfirmAllTransactionsPurged, never directly from PendingDeletion)`.

**Why this is foundational, not just another saga:** nearly everything else — the RTP sagas,
future pain.008 processing, the §6 on-us router — needs "is this RTN ours" on a hot path.
Consequence: other consumers should **not** query this saga's own repository directly. Instead,
this saga publishes domain events (`PartyRegistered`, `PartyMarkedForDeletion`, `PartyPurged`) that
feed a separate, lightweight read-model/projection table — and *that* projection is what
`IOwnedInstitutionRegistry` (§6) actually queries. This is the concrete CQRS split from §3 made
real: this saga is the write side; the registry lookup is a projected read side fed by its events,
not the same store.

## Open questions to resolve when this resumes

- Is RTP still the right flow to prototype the review/approval and outbound-routing pieces
  against, given the MDR doesn't spec a review step? Might be worth a flow that's a cleaner fit.
- Exact state graph and command/event names for the Party lifecycle saga (§7).
- Exact state graph for the review/approval extension (§3) — what states, what commands, what the
  saga does at each to actually construct the outbound ISO response.
- Whether `Incoming<T>`/`Outgoing<T>` belong in the core `BeneficialStrategies.Iso20022` package,
  the Sagas package, or a new package of their own (this "building block framework" the user has
  in mind may end up being its own package).
- Empirically verify MassTransit's default endpoint-name-formatter behavior for generic message
  types before deciding whether a custom `IEndpointNameFormatter` is actually needed.
- Design `IOwnedInstitutionRegistry`'s read-model projection mechanism concretely (what updates
  it, how consumers query it, caching/consistency expectations).
