// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;

/// <summary>
/// Fanned out from one line item of a
/// <see cref="IRequestToPayDebtorActivationAmendmentRequestV02"/> message (<c>reda.071</c>).
/// </summary>
public sealed record DebtorActivationAmendmentRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    IRTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    IDebtorActivationAmendment5 Amendment
) : IIso20022FanOutEvent;
