// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation;

/// <summary>
/// Endpoint/retry configuration for <see cref="DebtorActivationServiceProviderStateMachine"/>.
/// See
/// <see cref="MassTransit.Sagas.RequestToPayCreditorEnrolment.CreditorEnrolmentSagaDefinition"/>
/// for the rationale — identical defaults, fully overridable.
/// </summary>
public sealed class DebtorActivationSagaDefinition : SagaDefinition<DebtorActivationSagaState>
{
    protected override void ConfigureSaga(
        IReceiveEndpointConfigurator endpointConfigurator,
        ISagaConfigurator<DebtorActivationSagaState> sagaConfigurator,
        IRegistrationContext context
    )
    {
        endpointConfigurator.UseMessageRetry(r => r.Intervals(100, 500, 1000));
        sagaConfigurator.UseInMemoryOutbox(context);
    }
}
