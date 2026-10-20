// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;

/// <summary>
/// Fanned out from one line item of a <see cref="RequestToPayDebtorActivationRequestV02"/>
/// message (<c>reda.070</c>). See
/// <see cref="MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events.CreditorEnrolmentRequested"/>
/// for the shared shape rationale (this family mirrors it, Debtor-side).
/// </summary>
public sealed record DebtorActivationRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    RTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    DebtorActivation5 Activation,
    ElectronicInvoice1 ElectronicInvoiceData
) : IIso20022FanOutEvent;
