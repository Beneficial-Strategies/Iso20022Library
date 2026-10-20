// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;

/// <summary>
/// Fanned out from one line item of a <see cref="RequestToPayCreditorEnrolmentStatusReportV02"/>
/// message (<c>reda.069</c>). See <see cref="CreditorEnrolmentRequested"/> for the shared shape
/// rationale.
/// </summary>
/// <param name="EnrolmentStatus">
/// The single line item. Carries <c>Status</c> (the Accepted/Rejected outcome the state machine
/// branches on) and <c>OriginalBusinessInstruction</c>/<c>OriginalEnrolmentReference</c> — the
/// correlation fields.
/// </param>
public sealed record CreditorEnrolmentStatusReported(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    RTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    EnrolmentStatus3 EnrolmentStatus
) : IIso20022FanOutEvent;
