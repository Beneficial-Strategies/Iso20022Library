// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Consumers;

/// <summary>
/// Translates each of the 4 raw Creditor Enrolment messages (<c>reda.066</c>-<c>069</c>) — every
/// one of which wraps a <em>list</em> of line items under one shared <c>Header</c> — into one
/// internal fan-out event per line item. This is where "one wire message can report on N
/// enrolments at once" gets reconciled with MassTransit's one-message-one-saga-instance
/// correlation model; kept deliberately boring and separate from the state machine itself.
/// </summary>
public sealed class CreditorEnrolmentRequestConsumer : IConsumer<RequestToPayCreditorEnrolmentRequestV02>
{
    public async Task Consume(ConsumeContext<RequestToPayCreditorEnrolmentRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var enrolment in message.CreditorEnrolment)
        {
            await context.Publish(
                new CreditorEnrolmentRequested(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    Enrolment: enrolment,
                    ActivationData: message.ActivationData
                )
            );
            index++;
        }
    }
}

/// <summary>See <see cref="CreditorEnrolmentRequestConsumer"/>.</summary>
public sealed class CreditorEnrolmentAmendmentRequestConsumer
    : IConsumer<RequestToPayCreditorEnrolmentAmendmentRequestV02>
{
    public async Task Consume(ConsumeContext<RequestToPayCreditorEnrolmentAmendmentRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var amendment in message.AmendmentData)
        {
            await context.Publish(
                new CreditorEnrolmentAmendmentRequested(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    Amendment: amendment
                )
            );
            index++;
        }
    }
}

/// <summary>See <see cref="CreditorEnrolmentRequestConsumer"/>.</summary>
public sealed class CreditorEnrolmentCancellationRequestConsumer
    : IConsumer<RequestToPayCreditorEnrolmentCancellationRequestV02>
{
    public async Task Consume(ConsumeContext<RequestToPayCreditorEnrolmentCancellationRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var cancellation in message.CancellationData)
        {
            await context.Publish(
                new CreditorEnrolmentCancellationRequested(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    Cancellation: cancellation
                )
            );
            index++;
        }
    }
}

/// <summary>See <see cref="CreditorEnrolmentRequestConsumer"/>.</summary>
public sealed class CreditorEnrolmentStatusReportConsumer
    : IConsumer<RequestToPayCreditorEnrolmentStatusReportV02>
{
    public async Task Consume(ConsumeContext<RequestToPayCreditorEnrolmentStatusReportV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var status in message.OriginalEnrolmentAndStatus)
        {
            await context.Publish(
                new CreditorEnrolmentStatusReported(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    EnrolmentStatus: status
                )
            );
            index++;
        }
    }
}
