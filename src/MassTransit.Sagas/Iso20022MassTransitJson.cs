// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>Makes MassTransit's JSON serializer read and write the ISO 20022 types of the events and saga state.</summary>
public static class Iso20022MassTransitJson
{
    /// <summary>
    /// Registers on the bus the converters of <see cref="Iso20022JsonSerializerOptions"/> (lists, simple types, code sets, amounts)
    /// and, when a factory is given, the converter that reads the model's interfaces into the objects that factory makes.
    /// </summary>
    /// <remarks>
    /// MassTransit keeps one set of JSON options for the whole process, so the registration is process-wide and may be repeated: a
    /// converter that is already there is not added again. Only one factory can be in force; asking for a different one throws.
    /// The names on the wire stay MassTransit's own.
    /// </remarks>
    /// <param name="configurator">The bus being configured.</param>
    /// <param name="factory">What makes the objects for the interfaces; <see langword="null"/> when the events use records only.</param>
    public static void ConfigureIso20022Json(this IBusFactoryConfigurator configurator, IIsoDataFactory? factory = null)
    {
        ArgumentNullException.ThrowIfNull(configurator);
        configurator.ConfigureJsonSerializerOptions(options =>
        {
            Register(options, factory);
            return options;
        });
    }

    /// <summary>The registration itself, on any options. See <see cref="ConfigureIso20022Json"/>.</summary>
    public static void Register(JsonSerializerOptions options, IIsoDataFactory? factory = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        foreach (var converter in Iso20022JsonSerializerOptions.Default.Converters)
            if (!options.Converters.Any(c => c.GetType() == converter.GetType()))
                options.Converters.Add(converter);

        if (factory is null)
            return;
        var present = options.Converters.OfType<Iso20022InterfaceJsonConverterFactory>().FirstOrDefault();
        if (present is null)
            options.Converters.Add(new Iso20022InterfaceJsonConverterFactory(factory));
        else if (!ReferenceEquals(present.Factory, factory))
            throw new InvalidOperationException(
                "MassTransit's JSON options are shared by the whole process and already read the ISO 20022 interfaces through another factory; use one factory for all buses.");
    }
}
