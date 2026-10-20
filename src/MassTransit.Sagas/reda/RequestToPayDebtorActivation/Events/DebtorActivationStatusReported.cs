// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;

/// <summary>
/// Fanned out from one line item of a <see cref="IRequestToPayDebtorActivationStatusReportV02"/>
/// message (<c>reda.073</c>).
/// </summary>
public sealed record DebtorActivationStatusReported(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    IRTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    IActivationStatus3 ActivationStatus
) : IIso20022FanOutEvent;
