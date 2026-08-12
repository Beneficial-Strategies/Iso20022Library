// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:anyURI — a URI reference (absolute or relative), per RFC 3986.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:anyURI</c>. Validated with <see cref="Uri.TryCreate(string, UriKind, out Uri?)"/>
/// using <see cref="UriKind.RelativeOrAbsolute"/> — the empty string is also permitted, per the
/// XSD lexical space, to denote a same-document reference. Kept as a validated <see cref="string"/>
/// wrapper rather than a native <see cref="Uri"/> to match this library's other text-identifier
/// primitives.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("anyURI_ID")]
[Description(@"W3C XML Schema xs:anyURI — a URI reference (absolute or relative), per RFC 3986.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdAnyURI>))]
public readonly struct XsdAnyURI : IIsoSimpleValue<string>, IEquatable<XsdAnyURI>
{
    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the value is not a syntactically valid URI reference.</exception>
    public XsdAnyURI(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length > 0 && !Uri.TryCreate(value, UriKind.RelativeOrAbsolute, out _))
            throw new Iso20022FormatException(typeof(XsdAnyURI), value, "xs:anyURI — a syntactically valid URI reference (RFC 3986), absolute or relative");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a syntactically valid URI reference.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdAnyURI result)
    {
        if (value is not null)
        {
            try
            { result = new(value); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdAnyURI"/>.</summary>
    public static implicit operator XsdAnyURI(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdAnyURI v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdAnyURI other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdAnyURI other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdAnyURI a, XsdAnyURI b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdAnyURI a, XsdAnyURI b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdAnyURI a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdAnyURI a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdAnyURI b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdAnyURI b) => a != b.Value;
}
