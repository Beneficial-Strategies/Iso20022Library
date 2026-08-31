// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using static BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.DebtorActivationFixtures;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;

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
    public async Task AmendmentAfterActivated_FoldsBackToActivated()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-201"));
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-202", "MSG-201", ServiceRequestStatus1Code.Accepted));
        Assert.True(await sagaHarness.Consumed.Any<Events.DebtorActivationStatusReported>());
        Assert.Equal(sagaHarness.StateMachine.Activated.Name, FirstCreated(sagaHarness).CurrentState);

        await harness.Bus.Publish(AAmendment("MSG-203", "MSG-201"));
        Assert.True(await sagaHarness.Consumed.Any<Events.DebtorActivationAmendmentRequested>());

        var awaitingAmendment = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.AwaitingAmendmentResult.Name, awaitingAmendment.CurrentState);
        Assert.Equal("MSG-203", awaitingAmendment.LastMessageIdentification);
        Assert.Equal("MSG-201", awaitingAmendment.OriginalMessageIdentification);

        await harness.Bus.Publish(AStatusReport("MSG-204", "MSG-203", ServiceRequestStatus1Code.Accepted));
        // Filtered on this specific message id — a plain Any<T>() would already be true from the
        // FIRST status report consumed earlier in this test and would not actually wait for this
        // second one to finish processing. See CreditorEnrolmentServiceProviderStateMachineTests'
        // identical test for the full explanation.
        Assert.True(
            await sagaHarness.Consumed.Any<Events.DebtorActivationStatusReported>(m =>
                m.Context.Message.MessageIdentification == "MSG-204"
            )
        );

        Assert.Equal(sagaHarness.StateMachine.Activated.Name, FirstCreated(sagaHarness).CurrentState);
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
