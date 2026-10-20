// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;

/// <summary>
/// Fanned out from one line item of a
/// <see cref="RequestToPayCreditorEnrolmentAmendmentRequestV02"/> message (<c>reda.067</c>). See
/// <see cref="CreditorEnrolmentRequested"/> for the shared shape rationale.
/// </summary>
/// <param name="Amendment">
/// The single line item. Carries <c>OriginalBusinessInstruction</c>/<c>OriginalEnrolment</c> —
/// the fields the saga state machine's correlation expression matches against; not hoisted to a
/// top-level property since nothing outside correlation needs them directly.
/// </param>
public sealed record CreditorEnrolmentAmendmentRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    RTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    CreditorEnrolmentAmendment5 Amendment
) : IIso20022FanOutEvent;
