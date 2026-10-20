// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Serialization;
using MassTransit.Configuration;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using static BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.CreditorEnrolmentFixtures;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>
/// Exercises <see cref="Iso20022ServiceCollectionExtensionsTests"/>'s companion class
/// <c>Iso20022ServiceCollectionExtensions</c> — the reflection-based "register everything, or by
/// business area" entry point — end to end through a real bus, not just via unit-testing the
/// reflection helpers in isolation. Uses the Creditor Enrolment family as the representative case;
/// <see cref="RequestToPayDebtorActivation.DebtorActivationServiceProviderStateMachineTests"/>
/// already covers the Debtor Activation family's own behavior thoroughly via the strongly-typed
/// registration path, and the mechanism under test here is family-agnostic.
/// </summary>
public class Iso20022ServiceCollectionExtensionsTests
{
    private static async Task<(ServiceProvider Provider, ITestHarness Harness)> StartHarnessAsync(
        IEnumerable<string>? businessAreas
    )
    {
        var services = new ServiceCollection();
        services.AddMassTransitTestHarness(cfg =>
        {
            // AddIso20022Sagas is called INSIDE this configuration delegate, on the same `cfg` it
            // hands us — not as a standalone `services.Add...` call — per that method's own
            // remarks on why it extends IRegistrationConfigurator rather than IServiceCollection.
            if (businessAreas is null)
            {
                cfg.AddIso20022Sagas(new InMemorySagaRepositoryRegistrationProvider());
            }
            else
            {
                cfg.AddIso20022Sagas(businessAreas, new InMemorySagaRepositoryRegistrationProvider());
            }

            cfg.UsingInMemory(
                (context, busCfg) =>
                {
                    // Same requirement as every other test in this project — see
                    // CreditorEnrolmentServiceProviderStateMachineTests for why.
                    busCfg.ConfigureJsonSerializerOptions(options =>
                    {
                        foreach (var converter in Iso20022JsonSerializerOptions.Default.Converters)
                            options.Converters.Add(converter);
                        return options;
                    });
                    busCfg.ConfigureEndpoints(context);
                }
            );
        });

        var provider = services.BuildServiceProvider(true);
        var harness = provider.GetRequiredService<ITestHarness>();
        await harness.Start();
        return (provider, harness);
    }

    [Fact]
    public async Task AddIso20022Sagas_NoFilter_RegistersCreditorEnrolmentSagaFamily()
    {
        var (provider, harness) = await StartHarnessAsync(businessAreas: null);
        await using var _ = provider;

        var sagaHarness = harness.GetSagaStateMachineHarness<
            reda.RequestToPayCreditorEnrolment.CreditorEnrolmentServiceProviderStateMachine,
            reda.RequestToPayCreditorEnrolment.CreditorEnrolmentSagaState
        >();

        await harness.Bus.Publish(ARequest("MSG-001"));
        Assert.True(await sagaHarness.Created.Any());

        await harness.Bus.Publish(AStatusReport("MSG-002", "MSG-001", ServiceRequestStatus1Code.Accepted));
        Assert.True(
            await sagaHarness.Consumed.Any<reda.RequestToPayCreditorEnrolment.Events.CreditorEnrolmentStatusReported>()
        );

        var instance = sagaHarness.Created.Select(_ => true).First().Saga;
        Assert.Equal(sagaHarness.StateMachine.Enrolled.Name, instance.CurrentState);
    }

    [Fact]
    public async Task AddIso20022Sagas_FilteredToReda_StillRegistersCreditorEnrolmentSagaFamily()
    {
        var (provider, harness) = await StartHarnessAsync(businessAreas: ["reda"]);
        await using var _ = provider;

        var sagaHarness = harness.GetSagaStateMachineHarness<
            reda.RequestToPayCreditorEnrolment.CreditorEnrolmentServiceProviderStateMachine,
            reda.RequestToPayCreditorEnrolment.CreditorEnrolmentSagaState
        >();

        await harness.Bus.Publish(ARequest("MSG-101"));
        Assert.True(await sagaHarness.Created.Any());
    }

    [Fact]
    public async Task AddIso20022Sagas_FilteredToUnrelatedArea_RegistersNoSagaOrConsumer()
    {
        var (provider, harness) = await StartHarnessAsync(businessAreas: ["pain"]);
        await using var _ = provider;

        // Neither the fan-out consumer nor the saga state machine were registered for this
        // filter, so the raw ISO message is never consumed at all.
        await harness.Bus.Publish(ARequest("MSG-201"));
        Assert.False(await harness.Consumed.Any<RequestToPayCreditorEnrolmentRequestV02>());
    }
}
