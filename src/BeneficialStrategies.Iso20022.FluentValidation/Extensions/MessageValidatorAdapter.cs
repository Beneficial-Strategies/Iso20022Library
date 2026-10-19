// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Lets the validator of a message interface be resolved as <c>IValidator&lt;TheRecord&gt;</c>, so code that
/// validates one of our message records (and the XML and JSON envelope validators, which deserialize to the record)
/// keeps working. All rules are those of the interface validator; the adapter only forwards.
/// </summary>
internal sealed class MessageValidatorAdapter<TRecord, TInterface> : AbstractValidator<TRecord>
    where TRecord : class, TInterface
    where TInterface : class
{
    private readonly IValidator<TInterface> _inner;

    public MessageValidatorAdapter(IValidator<TInterface> inner) => _inner = inner;

    public override ValidationResult Validate(ValidationContext<TRecord> context) =>
        _inner.Validate(new ValidationContext<TInterface>(context.InstanceToValidate));

    public override Task<ValidationResult> ValidateAsync(
        ValidationContext<TRecord> context,
        CancellationToken cancellation = default
    ) => _inner.ValidateAsync(new ValidationContext<TInterface>(context.InstanceToValidate), cancellation);
}

/// <summary>Finds the record of a message interface and registers the adapter for it.</summary>
internal static class MessageValidatorAdapters
{
    private static readonly Lazy<Dictionary<Type, Type>> RecordOfInterface = new(() =>
    {
        var map = new Dictionary<Type, Type>();
        foreach (var record in typeof(Iso20022XmlSerializer).Assembly.GetTypes())
        {
            if (!record.IsClass || record.IsAbstract || !typeof(IOuterRecord).IsAssignableFrom(record))
                continue;
            var iface = record.GetInterfaces().FirstOrDefault(i => i.Name == "I" + record.Name && typeof(IOuterRecord).IsAssignableFrom(i));
            if (iface is not null)
                map[iface] = record;
        }
        return map;
    });

    /// <summary>The message interface for a record, or the type itself when it already is an interface.</summary>
    public static Type ToInterface(Type type) =>
        type.IsInterface
            ? type
            : RecordOfInterface.Value.FirstOrDefault(p => p.Value == type).Key ?? type;

    public static IServiceCollection AddMessageValidatorAdapters(
        this IServiceCollection services,
        ServiceLifetime lifetime,
        IEnumerable<Type> validatedTypes
    )
    {
        foreach (var validated in validatedTypes)
        {
            if (!RecordOfInterface.Value.TryGetValue(validated, out var record))
                continue;
            var inner = typeof(IValidator<>).MakeGenericType(validated);
            var adapter = typeof(MessageValidatorAdapter<,>).MakeGenericType(record, validated);
            services.TryAdd(
                new ServiceDescriptor(
                    typeof(IValidator<>).MakeGenericType(record),
                    sp => Activator.CreateInstance(adapter, sp.GetRequiredService(inner))!,
                    lifetime
                )
            );
        }
        return services;
    }
}
