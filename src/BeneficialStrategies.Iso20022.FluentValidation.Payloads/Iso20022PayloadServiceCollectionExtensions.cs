// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>Registers the payload (raw XML or JSON) validators and the dispatcher.</summary>
public static class Iso20022PayloadServiceCollectionExtensions
{
    /// <summary>
    /// For every ISO 20022 message type that already has an <c>IValidator&lt;TMessage&gt;</c>
    /// registered in <paramref name="services"/>, additionally registers
    /// <c>IValidator&lt;XmlEnvelope&lt;TMessage&gt;&gt;</c> and
    /// <c>IValidator&lt;JsonEnvelope&lt;TMessage&gt;&gt;</c> — so raw XML/JSON payloads can be
    /// deserialized-then-validated through the exact same <c>IValidator&lt;T&gt;</c> surface as
    /// any other validator in this project (see <see cref="XmlEnvelope{TMessage}"/> and
    /// <see cref="JsonEnvelope{TMessage}"/>).
    /// </summary>
    /// <param name="services">
    /// The service collection to register payload validators with. Call one of the
    /// <c>AddIso20022Validators</c> overloads first — this method only wraps message types that
    /// are already registered; it does not itself add any <c>IValidator&lt;TMessage&gt;</c>.
    /// </param>
    /// <param name="lifetime">
    /// The DI lifetime to register payload validators with. Defaults to
    /// <see cref="ServiceLifetime.Scoped"/>.
    /// </param>
    /// <param name="messageAssemblies">
    /// The assemblies that hold the message records (<c>BeneficialStrategies.Iso20022</c>), when no record type has been used
    /// yet in the process; see <see cref="Iso20022MessageTypeRegistry.AddAssembly"/>.
    /// </param>
    /// <returns><paramref name="services"/>, for chaining.</returns>
    /// <remarks>
    /// Use this — resolving <c>IValidator&lt;XmlEnvelope&lt;TMessage&gt;&gt;</c> directly — when
    /// the target message type is known at the call site. When it isn't known until the payload
    /// itself is inspected, use <see cref="AddIso20022PayloadValidationDispatcher"/> instead; that
    /// path only needs the plain <c>IValidator&lt;TMessage&gt;</c> registrations and does not
    /// depend on this method having been called.
    /// </remarks>
    public static IServiceCollection AddIso20022PayloadValidators(
        this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Scoped,
        IEnumerable<Assembly>? messageAssemblies = null
    )
    {
        foreach (var assembly in messageAssemblies ?? [])
            Iso20022MessageTypeRegistry.AddAssembly(assembly);

        var registered = services
            .Where(sd => sd.ServiceType.IsGenericType && sd.ServiceType.GetGenericTypeDefinition() == typeof(IValidator<>))
            .Select(sd => sd.ServiceType.GetGenericArguments()[0])
            .Where(t => typeof(IOuterRecord).IsAssignableFrom(t))
            .Distinct()
            .ToList();

        // The validators are written for the message interfaces; the envelopes deserialize to the record, so the record's
        // validator is the one of its interface, forwarded.
        foreach (var messageInterface in registered.Where(t => t.IsInterface).ToList())
        {
            var record = MessageValidatorAdapters.RecordOf(messageInterface);
            if (record is null)
                continue;
            var adapter = typeof(MessageValidatorAdapter<,>).MakeGenericType(record, messageInterface);
            var inner = typeof(IValidator<>).MakeGenericType(messageInterface);
            services.TryAdd(
                new ServiceDescriptor(
                    typeof(IValidator<>).MakeGenericType(record),
                    sp => Activator.CreateInstance(adapter, sp.GetRequiredService(inner))!,
                    lifetime
                )
            );
            registered.Add(record);
        }

        // A message interface has an XML envelope of its own: the XML is read into the objects of the registered
        // IIsoDataFactory, so no record is needed. (JSON is read into records only.)
        foreach (var messageInterface in registered.Where(t => t.IsInterface).Distinct().ToList())
        {
            services.TryAdd(
                new ServiceDescriptor(
                    typeof(IValidator<>).MakeGenericType(typeof(XmlEnvelope<>).MakeGenericType(messageInterface)),
                    typeof(XmlEnvelopeValidator<>).MakeGenericType(messageInterface),
                    lifetime
                )
            );
        }

        foreach (var messageType in registered.Where(t => t.IsClass).Distinct().ToList())
        {
            var xmlEnvelopeType = typeof(XmlEnvelope<>).MakeGenericType(messageType);
            var xmlValidatorType = typeof(XmlEnvelopeValidator<>).MakeGenericType(messageType);
            services.TryAdd(
                new ServiceDescriptor(typeof(IValidator<>).MakeGenericType(xmlEnvelopeType), xmlValidatorType, lifetime)
            );

            var jsonEnvelopeType = typeof(JsonEnvelope<>).MakeGenericType(messageType);
            var jsonValidatorType = typeof(JsonEnvelopeValidator<>).MakeGenericType(messageType);
            services.TryAdd(
                new ServiceDescriptor(typeof(IValidator<>).MakeGenericType(jsonEnvelopeType), jsonValidatorType, lifetime)
            );
        }

        return services;
    }

    /// <summary>
    /// Registers <see cref="IIso20022PayloadValidationDispatcher"/>, for validating raw XML/JSON
    /// payloads whose message type isn't known until the payload (XML) or an out-of-band hint
    /// (JSON) is inspected — see that interface's remarks.
    /// </summary>
    /// <param name="services">
    /// The service collection to register the dispatcher with. Call one of the
    /// <c>AddIso20022Validators</c> overloads first so the dispatcher has message validators to
    /// resolve at runtime; it does not require <see cref="AddIso20022PayloadValidators"/>.
    /// </param>
    /// <param name="lifetime">
    /// The DI lifetime to register the dispatcher with. Defaults to
    /// <see cref="ServiceLifetime.Scoped"/>.
    /// </param>
    /// <returns><paramref name="services"/>, for chaining.</returns>
    public static IServiceCollection AddIso20022PayloadValidationDispatcher(
        this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Scoped
    )
    {
        services.TryAdd(
            new ServiceDescriptor(
                typeof(IIso20022PayloadValidationDispatcher),
                typeof(Iso20022PayloadValidationDispatcher),
                lifetime
            )
        );
        return services;
    }

}
