// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes a <see cref="XmlQualifiedName"/> as a JSON string, in the same
/// "namespace:localName" (or bare "localName" when the namespace is empty) form
/// <see cref="XmlQualifiedName.ToString()"/> itself produces.
/// </summary>
/// <remarks>
/// Unlike XML, JSON has no ambient default-namespace scoping to resolve a bare or prefixed name
/// against, so there's no XML-serializer-style prefix-resolution problem here (contrast
/// <c>Iso20022XmlSerializer</c>'s <c>FormatQName</c>/<c>ParseQName</c>, which must resolve against
/// the document's in-scope namespace declarations) — the namespace, when present, is embedded
/// directly in the string. Registered globally via
/// <see cref="Iso20022JsonSerializerOptions"/> rather than a per-type <c>[JsonConverter]</c>
/// attribute, since <see cref="XmlQualifiedName"/> is a BCL type this library doesn't own.
/// <para>
/// Splits on the LAST colon when reading, not the first: <see cref="XmlQualifiedName.Name"/> is
/// always NCName-shaped by construction (never contains a colon), while
/// <see cref="XmlQualifiedName.Namespace"/> — typically a URI — often does (e.g.
/// <c>"http://example.com/schema:Foo"</c>), so splitting on the first colon would misparse it.
/// </para>
/// </remarks>
public sealed class Iso20022XmlQualifiedNameJsonConverter : JsonConverter<XmlQualifiedName>
{
    /// <inheritdoc/>
    public override XmlQualifiedName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString()
            ?? throw new JsonException($"Expected a string value for {nameof(XmlQualifiedName)}.");
        var colonIndex = str.LastIndexOf(':');
        return colonIndex < 0
            ? new XmlQualifiedName(str)
            : new XmlQualifiedName(str[(colonIndex + 1)..], str[..colonIndex]);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, XmlQualifiedName value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString());
}
