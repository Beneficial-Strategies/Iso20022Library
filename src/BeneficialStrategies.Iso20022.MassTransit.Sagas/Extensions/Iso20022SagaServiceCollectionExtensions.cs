// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayCreditorEnrolment;
using BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation;
using Microsoft.Extensions.DependencyInjection;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Extensions;

/// <summary>
/// DI registration for the Request-to-Pay sagas. Ships no concrete persistence — the caller
/// supplies it via <paramref name="configureRepository"/> against MassTransit's own
/// <c>ISagaRegistrationConfigurator&lt;TInstance&gt;</c> (the same builder
/// <c>AddSagaStateMachine&lt;...&gt;()</c> itself returns), matching how MassTransit's
/// repository-configuration extension methods (<c>InMemoryRepository()</c>,
/// <c>EntityFrameworkRepository(...)</c>, etc.) are meant to be chained.
/// </summary>
public static class Iso20022SagaServiceCollectionExtensions
{
    /// <summary>
    /// Registers <see cref="CreditorEnrolmentServiceProviderStateMachine"/>, its fan-out
    /// consumers, and <see cref="CreditorEnrolmentSagaDefinition"/>. No persistence is configured
    /// unless <paramref name="configureRepository"/> configures one.
    /// </summary>
    public static IServiceCollection AddCreditorEnrolmentSaga(
        this IServiceCollection services,
        Action<IBusRegistrationConfigurator> configureBus,
        Action<ISagaRegistrationConfigurator<CreditorEnrolmentSagaState>> configureRepository
    )
    {
        services.AddMassTransit(x =>
        {
            var saga = x.AddSagaStateMachine<
                CreditorEnrolmentServiceProviderStateMachine,
                CreditorEnrolmentSagaState,
                CreditorEnrolmentSagaDefinition
            >();
            configureRepository(saga);

            x.AddConsumer<RequestToPayCreditorEnrolment.Consumers.CreditorEnrolmentRequestConsumer>();
            x.AddConsumer<RequestToPayCreditorEnrolment.Consumers.CreditorEnrolmentAmendmentRequestConsumer>();
            x.AddConsumer<RequestToPayCreditorEnrolment.Consumers.CreditorEnrolmentCancellationRequestConsumer>();
            x.AddConsumer<RequestToPayCreditorEnrolment.Consumers.CreditorEnrolmentStatusReportConsumer>();

            configureBus(x);
        });
        return services;
    }

    /// <summary>
    /// Registers <see cref="DebtorActivationServiceProviderStateMachine"/>, its fan-out
    /// consumers, and <see cref="DebtorActivationSagaDefinition"/>. No persistence is configured
    /// unless <paramref name="configureRepository"/> configures one.
    /// </summary>
    public static IServiceCollection AddDebtorActivationSaga(
        this IServiceCollection services,
        Action<IBusRegistrationConfigurator> configureBus,
        Action<ISagaRegistrationConfigurator<DebtorActivationSagaState>> configureRepository
    )
    {
        services.AddMassTransit(x =>
        {
            var saga = x.AddSagaStateMachine<
                DebtorActivationServiceProviderStateMachine,
                DebtorActivationSagaState,
                DebtorActivationSagaDefinition
            >();
            configureRepository(saga);

            x.AddConsumer<RequestToPayDebtorActivation.Consumers.DebtorActivationRequestConsumer>();
            x.AddConsumer<RequestToPayDebtorActivation.Consumers.DebtorActivationAmendmentRequestConsumer>();
            x.AddConsumer<RequestToPayDebtorActivation.Consumers.DebtorActivationCancellationRequestConsumer>();
            x.AddConsumer<RequestToPayDebtorActivation.Consumers.DebtorActivationStatusReportConsumer>();

            configureBus(x);
        });
        return services;
    }
}
