// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Pre-configured <see cref="JsonSerializerOptions"/> for ISO 20022 message records,
/// conforming to the ISO 20022 JSON binding specification (Annex A, 2018 whitepaper).
/// </summary>
/// <remarks>
/// Applies four conventions:
/// <list type="bullet">
///   <item>Property names use <c>snake_case</c> derived from C# PascalCase names
///         (<see cref="Iso20022JsonNamingPolicy"/>).</item>
///   <item>Enum values serialize as their ISO wire codes (e.g. <c>"CHEC"</c>) via
///         <see cref="EnumMemberAttribute"/> (<see cref="Iso20022EnumConverterFactory"/>).</item>
///   <item>Collection properties (<see cref="ValueList{T}"/>, <see cref="SimpleValueList{T}"/>,
///         <see cref="ImmutableValueList{T}"/>) serialize as JSON arrays
///         (<see cref="ImmutableValueListConverterFactory"/>).</item>
///   <item><see cref="System.Xml.XmlQualifiedName"/> (the BCL type backing <c>IsoQName</c>, per
///         CLAUDE.md's W3C-standard exception) serializes as a single "namespace:localName" string
///         rather than System.Text.Json's default reflection-based object shape
///         (<see cref="Iso20022XmlQualifiedNameJsonConverter"/>).</item>
/// </list>
/// Register once; reuse everywhere.
/// </remarks>
public static class Iso20022JsonSerializerOptions
{
    /// <summary>
    /// Singleton <see cref="JsonSerializerOptions"/> configured for ISO 20022 JSON serialization.
    /// </summary>
    public static readonly JsonSerializerOptions Default = BuildDefault();

    private static JsonSerializerOptions BuildDefault()
    {
        var opts = new JsonSerializerOptions(JsonSerializerOptions.Default)
        {
            PropertyNamingPolicy = Iso20022JsonNamingPolicy.Instance,
        };
        opts.Converters.Add(ImmutableValueListConverterFactory.Instance);
        opts.Converters.Add(Iso20022EnumConverterFactory.Instance);
        opts.Converters.Add(Iso20022DecimalJsonConverter.Instance);
        opts.Converters.Add(new Iso20022XmlQualifiedNameJsonConverter());
        opts.MakeReadOnly();
        return opts;
    }
}
