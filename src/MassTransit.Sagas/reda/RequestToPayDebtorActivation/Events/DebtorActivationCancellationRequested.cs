// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;

/// <summary>
/// Fanned out from one line item of a
/// <see cref="IRequestToPayDebtorActivationCancellationRequestV02"/> message (<c>reda.072</c>).
/// </summary>
public sealed record DebtorActivationCancellationRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    IRTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    IDebtorActivationCancellation3 Cancellation
) : IIso20022FanOutEvent;
