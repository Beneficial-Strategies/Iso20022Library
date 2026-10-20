// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Consumers;

/// <summary>
/// Translates each of the 4 raw Debtor Activation messages (<c>reda.070</c>-<c>073</c>) into one
/// internal fan-out event per line item. See
/// <see cref="MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Consumers.CreditorEnrolmentRequestConsumer"/>
/// for the shared rationale.
/// </summary>
public sealed class DebtorActivationRequestConsumer : IConsumer<IRequestToPayDebtorActivationRequestV02>
{
    public async Task Consume(ConsumeContext<IRequestToPayDebtorActivationRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var activation in message.DebtorActivation)
        {
            await context.Publish(
                new DebtorActivationRequested(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    Activation: activation,
                    ElectronicInvoiceData: message.ElectronicInvoiceData
                )
            );
            index++;
        }
    }
}

/// <summary>See <see cref="DebtorActivationRequestConsumer"/>.</summary>
public sealed class DebtorActivationAmendmentRequestConsumer
    : IConsumer<IRequestToPayDebtorActivationAmendmentRequestV02>
{
    public async Task Consume(ConsumeContext<IRequestToPayDebtorActivationAmendmentRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var amendment in message.AmendmentData)
        {
            await context.Publish(
                new DebtorActivationAmendmentRequested(
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

/// <summary>See <see cref="DebtorActivationRequestConsumer"/>.</summary>
public sealed class DebtorActivationCancellationRequestConsumer
    : IConsumer<IRequestToPayDebtorActivationCancellationRequestV02>
{
    public async Task Consume(ConsumeContext<IRequestToPayDebtorActivationCancellationRequestV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var cancellation in message.CancellationData)
        {
            await context.Publish(
                new DebtorActivationCancellationRequested(
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

/// <summary>See <see cref="DebtorActivationRequestConsumer"/>.</summary>
public sealed class DebtorActivationStatusReportConsumer
    : IConsumer<IRequestToPayDebtorActivationStatusReportV02>
{
    public async Task Consume(ConsumeContext<IRequestToPayDebtorActivationStatusReportV02> context)
    {
        var message = context.Message;
        var index = 0;
        foreach (var status in message.OriginalActivationAndStatus)
        {
            await context.Publish(
                new DebtorActivationStatusReported(
                    EventId: NewId.NextGuid(),
                    MessageIdentification: message.Header.MessageIdentification,
                    CreationDateTime: message.Header.CreationDateTime,
                    InitiatingParty: message.Header.InitiatingParty,
                    LineItemIndex: index,
                    ActivationStatus: status
                )
            );
            index++;
        }
    }
}
