// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment;

/// <summary>
/// Endpoint/retry configuration for <see cref="CreditorEnrolmentServiceProviderStateMachine"/>.
/// The defaults here are conservative and fully overridable by a caller's own bus configuration —
/// this is an operational concern each deployment tunes for its own environment, not something
/// derived from the ISO 20022 specification.
/// </summary>
public sealed class CreditorEnrolmentSagaDefinition : SagaDefinition<CreditorEnrolmentSagaState>
{
    protected override void ConfigureSaga(
        IReceiveEndpointConfigurator endpointConfigurator,
        ISagaConfigurator<CreditorEnrolmentSagaState> sagaConfigurator,
        IRegistrationContext context
    )
    {
        endpointConfigurator.UseMessageRetry(r => r.Intervals(100, 500, 1000));
        sagaConfigurator.UseInMemoryOutbox(context);
    }
}
