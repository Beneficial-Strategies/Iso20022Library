// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>Registers the <see cref="IsoDataFactory"/>.</summary>
public static class Iso20022FactoryServiceCollectionExtensions
{
    /// <summary>
    /// Registers the factory as a singleton (as <see cref="IsoDataFactory"/> and as <see cref="IIsoDataFactory"/>) and, in
    /// a host, builds the classes for <paramref name="messages"/> when the host starts, so no read pays for it.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="messages">The message interfaces you will read, for example <c>typeof(IFIToFICustomerCreditTransferV14)</c>.</param>
    public static IServiceCollection AddIso20022Factory(
        this IServiceCollection services,
        params Type[] messages
    )
    {
        services.TryAddSingleton<IsoDataFactory>();
        services.TryAddSingleton<IIsoDataFactory>(sp => sp.GetRequiredService<IsoDataFactory>());
        if (messages.Length > 0)
            services.AddSingleton<IHostedService>(sp => new WarmUp(
                sp.GetRequiredService<IsoDataFactory>(),
                messages
            ));
        return services;
    }

    private sealed class WarmUp(IsoDataFactory factory, Type[] messages) : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            factory.Warm(messages);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
