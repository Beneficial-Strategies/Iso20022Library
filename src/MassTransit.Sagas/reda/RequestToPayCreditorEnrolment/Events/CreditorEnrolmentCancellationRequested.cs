// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;

/// <summary>
/// Fanned out from one line item of a
/// <see cref="IRequestToPayCreditorEnrolmentCancellationRequestV02"/> message (<c>reda.068</c>).
/// See <see cref="CreditorEnrolmentRequested"/> for the shared shape rationale.
/// </summary>
public sealed record CreditorEnrolmentCancellationRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    IRTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    ICreditorEnrolmentCancellation3 Cancellation
) : IIso20022FanOutEvent;
