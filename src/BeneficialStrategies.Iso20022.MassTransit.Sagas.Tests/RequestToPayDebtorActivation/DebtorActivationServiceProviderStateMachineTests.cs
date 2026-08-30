// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation;

public class DebtorActivationServiceProviderStateMachineTests
{
    private static async Task<(
        ServiceProvider Provider,
        ITestHarness Harness,
        ISagaStateMachineTestHarness<DebtorActivationServiceProviderStateMachine, DebtorActivationSagaState> SagaHarness
    )> StartHarnessAsync()
    {
        var provider = new ServiceCollection()
            .AddMassTransitTestHarness(cfg =>
            {
                cfg.AddSagaStateMachine<
                    DebtorActivationServiceProviderStateMachine,
                    DebtorActivationSagaState
                >().InMemoryRepository();
                cfg.AddConsumer<Consumers.DebtorActivationRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationAmendmentRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationCancellationRequestConsumer>();
                cfg.AddConsumer<Consumers.DebtorActivationStatusReportConsumer>();

                // See CreditorEnrolmentServiceProviderStateMachineTests for why this is required.
                cfg.UsingInMemory(
                    (context, busCfg) =>
                    {
                        busCfg.ConfigureJsonSerializerOptions(options =>
                        {
                            foreach (var converter in Iso20022JsonSerializerOptions.Default.Converters)
                                options.Converters.Add(converter);
                            return options;
                        });
                        busCfg.ConfigureEndpoints(context);
                    }
                );
            })
            .BuildServiceProvider(true);

        var harness = provider.GetRequiredService<ITestHarness>();
        await harness.Start();

        var sagaHarness = harness.GetSagaStateMachineHarness<
            DebtorActivationServiceProviderStateMachine,
            DebtorActivationSagaState
        >();

        return (provider, harness, sagaHarness);
    }

    private static DebtorActivationSagaState FirstCreated(
        ISagaStateMachineTestHarness<DebtorActivationServiceProviderStateMachine, DebtorActivationSagaState> sagaHarness
    ) => sagaHarness.Created.Select(_ => true).First().Saga;

    private static RTPPartyIdentification2 AParty(string name) => new() { Name = name };

    private static RequestToPayDebtorActivationRequestV02 ARequest(string messageId) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = AParty("Debtor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            ElectronicInvoiceData = new ElectronicInvoice1 { PresentmentType = PresentmentType1Code.Full },
            DebtorActivation =
            [
                new DebtorActivation5
                {
                    Debtor = AParty("Jane Debtor"),
                    Creditor = AParty("Acme Payee Ltd"),
                    DebtorSolutionProvider = AParty("Debtor Solution Provider"),
                },
            ],
        };

    private static RequestToPayDebtorActivationStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = AParty("Creditor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            OriginalActivationAndStatus =
            [
                new ActivationStatus3
                {
                    Status = new ServiceStatus1Choice.Code { Value = status },
                    OriginalBusinessInstruction = new OriginalBusinessInstruction1
                    {
                        MessageIdentification = originalMessageId,
                    },
                },
            ],
        };

    [Fact]
    public async Task HappyPath_RequestThenAcceptedStatusReport_TransitionsToActivated()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-001"));
        Assert.True(await sagaHarness.Consumed.Any<Events.DebtorActivationRequested>());
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-002", "MSG-001", ServiceRequestStatus1Code.Accepted));
        Assert.True(await sagaHarness.Consumed.Any<Events.DebtorActivationStatusReported>());

        var instance = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Activated.Name, instance.CurrentState);
    }

    [Fact]
    public async Task RejectionPath_RequestThenRejectedStatusReport_TransitionsToRejected()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-101"));
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-102", "MSG-101", ServiceRequestStatus1Code.Rejected));
        Assert.True(await sagaHarness.Consumed.Any<Events.DebtorActivationStatusReported>());

        var instance = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Rejected.Name, instance.CurrentState);
    }

    [Fact]
    public async Task OrphanStatusReport_CreatesNoSaga()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(AStatusReport("MSG-301", "NEVER-SENT", ServiceRequestStatus1Code.Accepted));
        Assert.True(await harness.Consumed.Any<RequestToPayDebtorActivationStatusReportV02>());

        Assert.False(await sagaHarness.Created.Any());
    }
}
