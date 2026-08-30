// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation.Events;

/// <summary>
/// Fanned out from one line item of a <see cref="RequestToPayDebtorActivationStatusReportV02"/>
/// message (<c>reda.073</c>).
/// </summary>
public sealed record DebtorActivationStatusReported(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    RTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    ActivationStatus3 ActivationStatus
) : IIso20022FanOutEvent;
