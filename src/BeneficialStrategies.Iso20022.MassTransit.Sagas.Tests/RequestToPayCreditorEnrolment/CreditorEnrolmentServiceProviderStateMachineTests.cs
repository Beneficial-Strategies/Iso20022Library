// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalEnrolment3Choice = BeneficialStrategies.Iso20022.Choices.OriginalEnrolment3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayCreditorEnrolment;

public class CreditorEnrolmentServiceProviderStateMachineTests
{
    private static async Task<(
        ServiceProvider Provider,
        ITestHarness Harness,
        ISagaStateMachineTestHarness<CreditorEnrolmentServiceProviderStateMachine, CreditorEnrolmentSagaState> SagaHarness
    )> StartHarnessAsync()
    {
        var provider = new ServiceCollection()
            .AddMassTransitTestHarness(cfg =>
            {
                cfg.AddSagaStateMachine<
                    CreditorEnrolmentServiceProviderStateMachine,
                    CreditorEnrolmentSagaState
                >().InMemoryRepository();
                cfg.AddConsumer<Consumers.CreditorEnrolmentRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentAmendmentRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentCancellationRequestConsumer>();
                cfg.AddConsumer<Consumers.CreditorEnrolmentStatusReportConsumer>();

                // Required: without this, MassTransit's default STJ options cannot deserialize
                // ValueList<T> (or any of the other Iso20022JsonSerializerOptions converters cover)
                // when a message round-trips through actual JSON, since ValueList<T> is a
                // custom immutable collection type STJ's reflection-based converter can't
                // construct on its own. See RTP MassTransit.Sagas README for the full note.
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
            CreditorEnrolmentServiceProviderStateMachine,
            CreditorEnrolmentSagaState
        >();

        return (provider, harness, sagaHarness);
    }

    private static CreditorEnrolmentSagaState FirstCreated(
        ISagaStateMachineTestHarness<CreditorEnrolmentServiceProviderStateMachine, CreditorEnrolmentSagaState> sagaHarness
    ) => sagaHarness.Created.Select(_ => true).First().Saga;

    private static List<CreditorEnrolmentSagaState> AllCreated(
        ISagaStateMachineTestHarness<CreditorEnrolmentServiceProviderStateMachine, CreditorEnrolmentSagaState> sagaHarness
    ) => sagaHarness.Created.Select(_ => true).Select(x => x.Saga).ToList();

    private static RTPPartyIdentification2 ACreditor() => new() { Name = "Acme Payee Ltd" };

    private static RequestToPayCreditorEnrolmentRequestV02 ARequest(string messageId, int lineItems = 1) =>
        new()
        {
            Header = new EnrolmentHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = ACreditor(),
                MessageIdentification = messageId,
            },
            ActivationData = new CreditorInvoice6
            {
                ActivationRequestDeliveryParty = ACreditor(),
                LimitedPresentmentIndicator = false,
            },
            CreditorEnrolment =
            [
                .. Enumerable
                    .Range(0, lineItems)
                    .Select(_ => new CreditorEnrolment5
                    {
                        Creditor = ACreditor(),
                        MerchantCategoryCode = "5411",
                        Enrolment = new CreditorServiceEnrolment1 { ServiceActivationAllowed = true },
                    }),
            ],
        };

    private static RequestToPayCreditorEnrolmentStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        new()
        {
            Header = new EnrolmentHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = ACreditor(),
                MessageIdentification = messageId,
            },
            OriginalEnrolmentAndStatus =
            [
                new EnrolmentStatus3
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
    public async Task HappyPath_RequestThenAcceptedStatusReport_TransitionsToEnrolled()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-001"));
        Assert.True(await harness.Consumed.Any<RequestToPayCreditorEnrolmentRequestV02>());
        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentRequested>());
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-002", "MSG-001", ServiceRequestStatus1Code.Accepted));
        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentStatusReported>());

        var instance = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Enrolled.Name, instance.CurrentState);
        Assert.Equal(ServiceRequestStatus1Code.Accepted, instance.LastStatus);
    }

    [Fact]
    public async Task RejectionPath_RequestThenRejectedStatusReport_TransitionsToRejected()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-101"));
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-102", "MSG-101", ServiceRequestStatus1Code.Rejected));
        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentStatusReported>());

        var instance = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Rejected.Name, instance.CurrentState);
    }

    [Fact]
    public async Task AmendmentAfterEnrolled_FoldsBackToEnrolled()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-201"));
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-202", "MSG-201", ServiceRequestStatus1Code.Accepted));
        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentStatusReported>());
        var enrolled = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Enrolled.Name, enrolled.CurrentState);

        await harness.Bus.Publish(
            new RequestToPayCreditorEnrolmentAmendmentRequestV02
            {
                Header = new EnrolmentHeader3
                {
                    CreationDateTime = DateTime.UtcNow,
                    InitiatingParty = ACreditor(),
                    MessageIdentification = "MSG-203",
                },
                AmendmentData =
                [
                    new CreditorEnrolmentAmendment5
                    {
                        Amendment = new CreditorEnrolmentAmendment6(),
                        OriginalEnrolment = new OriginalEnrolment3Choice.OriginalCreditorIdentification
                        {
                            Value = new Party53Choice.OrganisationIdentification
                            {
                                Value = new OrganisationIdentification40(),
                            },
                        },
                        OriginalBusinessInstruction = new OriginalBusinessInstruction1
                        {
                            MessageIdentification = "MSG-201",
                        },
                    },
                ],
            }
        );
        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentAmendmentRequested>());

        var awaitingAmendment = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.AwaitingAmendmentResult.Name, awaitingAmendment.CurrentState);
        Assert.Equal("MSG-203", awaitingAmendment.LastMessageIdentification);
        Assert.Equal("MSG-201", awaitingAmendment.OriginalMessageIdentification);

        await harness.Bus.Publish(AStatusReport("MSG-204", "MSG-203", ServiceRequestStatus1Code.Accepted));
        // Filtered on this specific message id — a plain Any<T>() would already be true from the
        // FIRST status report consumed earlier in this test and would not actually wait for this
        // second one to finish processing (a real race: the assertion could pass before the fold-back
        // transition below has happened at all).
        Assert.True(
            await sagaHarness.Consumed.Any<Events.CreditorEnrolmentStatusReported>(m =>
                m.Context.Message.MessageIdentification == "MSG-204"
            )
        );

        var folded = FirstCreated(sagaHarness);
        Assert.Equal(sagaHarness.StateMachine.Enrolled.Name, folded.CurrentState);
    }

    [Fact]
    public async Task OrphanStatusReport_CreatesNoSaga()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(AStatusReport("MSG-301", "NEVER-SENT", ServiceRequestStatus1Code.Accepted));
        Assert.True(await harness.Consumed.Any<RequestToPayCreditorEnrolmentStatusReportV02>());

        Assert.False(await sagaHarness.Created.Any());
    }

    [Fact]
    public async Task FanOutConsumer_TwoLineItems_PublishesTwoRequestedEvents_TwoDistinctSagas()
    {
        var (provider, harness, sagaHarness) = await StartHarnessAsync();
        await using var _ = provider;

        await harness.Bus.Publish(ARequest("MSG-401", lineItems: 2));

        Assert.True(await sagaHarness.Consumed.Any<Events.CreditorEnrolmentRequested>());
        var created = AllCreated(sagaHarness);
        Assert.Equal(2, created.Count);
        Assert.NotEqual(created[0].CorrelationId, created[1].CorrelationId);
    }
}
