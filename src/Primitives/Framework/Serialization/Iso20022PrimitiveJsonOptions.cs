// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// JSON options for the primitive types (simple types, code sets, external codes, amounts) used alone, without the message records:
/// the converters those types need. <c>Iso20022JsonSerializerOptions.Default</c> of the BeneficialStrategies.Iso20022 package is these
/// plus the converter of the value lists and the naming policy of the records.
/// </summary>
public static class Iso20022PrimitiveJsonOptions
{
    /// <summary>Read-only options with the converters of the primitive types.</summary>
    public static readonly JsonSerializerOptions Default = Build();

    /// <summary>Adds the converters of the primitive types to <paramref name="options"/>, for a caller that builds its own.</summary>
    public static void AddConverters(JsonSerializerOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        options.Converters.Add(Iso20022EnumConverterFactory.Instance);
        options.Converters.Add(Iso20022DecimalJsonConverter.Instance);
        options.Converters.Add(new Iso20022XmlQualifiedNameJsonConverter());
    }

    private static JsonSerializerOptions Build()
    {
        var options = new JsonSerializerOptions(JsonSerializerOptions.Default);
        AddConverters(options);
        options.MakeReadOnly();
        return options;
    }
}
