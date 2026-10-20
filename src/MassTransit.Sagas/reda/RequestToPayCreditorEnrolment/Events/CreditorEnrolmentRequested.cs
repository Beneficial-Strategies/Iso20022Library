// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;

/// <summary>
/// Fanned out from one line item of a <see cref="IRequestToPayCreditorEnrolmentRequestV02"/>
/// message (<c>reda.066</c>). Not an ISO 20022 type — see
/// <see cref="Framework.IIso20022FanOutEvent"/> for why this exists.
/// </summary>
/// <param name="EventId">Fresh per fan-out call — dedup/tracing only, no ISO source.</param>
/// <param name="MessageIdentification">The source message's <c>Header.MessageIdentification</c>.</param>
/// <param name="CreationDateTime">The source message's <c>Header.CreationDateTime</c>.</param>
/// <param name="InitiatingParty">The source message's <c>Header.InitiatingParty</c>.</param>
/// <param name="LineItemIndex">Position of <paramref name="Enrolment"/> within the source message's <c>CreditorEnrolment</c> batch.</param>
/// <param name="Enrolment">The single line item this event represents.</param>
/// <param name="ActivationData">The source message's message-level <c>ActivationData</c>, carried along unchanged for every line item.</param>
public sealed record CreditorEnrolmentRequested(
    Guid EventId,
    string MessageIdentification,
    DateTime CreationDateTime,
    IRTPPartyIdentification2 InitiatingParty,
    int LineItemIndex,
    ICreditorEnrolment5 Enrolment,
    ICreditorInvoice6 ActivationData
) : IIso20022FanOutEvent;
