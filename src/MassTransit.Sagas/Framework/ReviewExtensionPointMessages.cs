// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Framework;

/// <summary>
/// Placeholder message contract for the "review requested" extension-point event exposed by this
/// package's state machines (see e.g.
/// <see cref="reda.RequestToPayCreditorEnrolment.CreditorEnrolmentServiceProviderStateMachine.ReviewRequested"/>).
/// Not an ISO 20022 type — the source Message Definition Report specifies no review/compliance
/// step for this flow, so this carries only enough to let a caller's own activity correlate back
/// to the right saga episode. A caller needing richer review context should define and publish
/// their own event instead of this one; MassTransit requires every <c>Event&lt;T&gt;</c> to have
/// a concrete message type (a bare <c>object</c> placeholder is rejected at state-machine
/// construction time), so this exists to give the extension point a real, minimal type rather
/// than leaving it undeclared.
/// </summary>
public sealed record ReviewRequestedMessage(Guid CorrelationId);

/// <summary>See <see cref="ReviewRequestedMessage"/>.</summary>
public sealed record ReviewCompletedMessage(Guid CorrelationId, bool Approved, string? Note);
