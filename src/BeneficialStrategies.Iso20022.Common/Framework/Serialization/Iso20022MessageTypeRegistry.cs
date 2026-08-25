// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Process-wide registry of every <see cref="IOuterRecord"/> message type in this assembly, keyed
/// by the identifiers that appear on (or alongside) the wire: the ISO 20022 message identifier
/// (e.g. <c>"pacs.008.001.14"</c>) and the XML document namespace (e.g.
/// <c>"urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14"</c>).
/// </summary>
/// <remarks>
/// Built once via a single reflection scan of this assembly on first access (<see cref="Lazy{T}"/>),
/// not per call — subsequent lookups are plain dictionary reads.
/// <para>
/// There is no equivalent self-describing discriminator for JSON payloads. ISO 20022's JSON
/// binding carries no root element/namespace analogous to the XML <c>&lt;Document xmlns="..."&gt;</c>
/// wrapper, so a JSON payload alone cannot say which message type it is — dispatching JSON to the
/// correct type always requires an out-of-band hint (a queue header, HTTP content-type parameter,
/// enclosing envelope, or similar) resolved via <see cref="TryGetByIsoIdentifier"/>, not sniffed
/// from the payload the way <see cref="TryGetByDocumentNamespace"/> sniffs XML.
/// </para>
/// </remarks>
public static class Iso20022MessageTypeRegistry
{
    /// <summary>
    /// Every <see cref="IOuterRecord"/> message type in this assembly, keyed by its
    /// <c>IsoIdentifier</c> constant (e.g. <c>"pacs.008.001.14"</c>).
    /// </summary>
    public static IReadOnlyDictionary<string, Type> ByIsoIdentifier => RegistryValue.Value.ByIsoIdentifier;

    /// <summary>
    /// Every <see cref="IOuterRecord"/> message type in this assembly, keyed by its
    /// <c>DocumentNamespace</c> constant (e.g. <c>"urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14"</c>).
    /// </summary>
    public static IReadOnlyDictionary<string, Type> ByDocumentNamespace => RegistryValue.Value.ByDocumentNamespace;

    /// <summary>
    /// Attempts to resolve a message type from its XML document namespace — e.g. the root
    /// element's <c>xmlns</c> attribute value.
    /// </summary>
    public static bool TryGetByDocumentNamespace(
        string documentNamespace,
        [NotNullWhen(true)] out Type? messageType
    ) => ByDocumentNamespace.TryGetValue(documentNamespace, out messageType);

    /// <summary>
    /// Attempts to resolve a message type from its ISO 20022 message identifier (e.g.
    /// <c>"pacs.008.001.14"</c>).
    /// </summary>
    public static bool TryGetByIsoIdentifier(string isoIdentifier, [NotNullWhen(true)] out Type? messageType) =>
        ByIsoIdentifier.TryGetValue(isoIdentifier, out messageType);

    private static readonly Lazy<(
        IReadOnlyDictionary<string, Type> ByIsoIdentifier,
        IReadOnlyDictionary<string, Type> ByDocumentNamespace
    )> RegistryValue = new(Build);

    private static (
        IReadOnlyDictionary<string, Type> ByIsoIdentifier,
        IReadOnlyDictionary<string, Type> ByDocumentNamespace
    ) Build()
    {
        var byId = new Dictionary<string, Type>(StringComparer.Ordinal);
        var byNamespace = new Dictionary<string, Type>(StringComparer.Ordinal);

        foreach (var type in typeof(IOuterRecord).Assembly.GetTypes())
        {
            if (type.IsAbstract || !typeof(IOuterRecord).IsAssignableFrom(type))
                continue;

            if (GetStaticStringConstant(type, "IsoIdentifier") is { } id)
                byId[id] = type;
            if (GetStaticStringConstant(type, "DocumentNamespace") is { } ns)
                byNamespace[ns] = type;
        }

        return (byId, byNamespace);
    }

    private static string? GetStaticStringConstant(Type type, string fieldName) =>
        type.GetField(fieldName, BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as string;
}
