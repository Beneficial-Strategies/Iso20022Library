// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Pre-configured <see cref="JsonSerializerOptions"/> for ISO 20022 message records.
/// </summary>
/// <remarks>
/// Registers <see cref="ImmutableValueListConverterFactory"/> so that
/// <see cref="ValueList{T}"/>, <see cref="SimpleValueList{T}"/>, and
/// <see cref="ImmutableValueList{T}"/> collection properties round-trip correctly.
/// This is required for MassTransit (or any STJ-based serializer) to use ISO 20022
/// records as message bodies.
/// </remarks>
public static class Iso20022JsonSerializerOptions
{
    /// <summary>
    /// Singleton <see cref="JsonSerializerOptions"/> configured for ISO 20022 serialization.
    /// Register once; reuse everywhere.
    /// </summary>
    public static readonly JsonSerializerOptions Default = BuildDefault();

    private static JsonSerializerOptions BuildDefault()
    {
        var opts = new JsonSerializerOptions(JsonSerializerOptions.Default);
        opts.Converters.Add(ImmutableValueListConverterFactory.Instance);
        opts.MakeReadOnly();
        return opts;
    }
}
