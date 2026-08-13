// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:normalizedString — a string with no literal tab, newline, or carriage
/// return characters.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:normalizedString</c> — a restriction of <c>xs:string</c>
/// with the <c>whiteSpace</c> facet set to <c>replace</c>. Unlike <c>xs:token</c> (see
/// <see cref="XsdToken"/>), leading/trailing spaces and internal runs of multiple spaces are
/// still permitted; only literal <c>\t</c>, <c>\n</c>, and <c>\r</c> are rejected.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("normalizedString_ID")]
[Description(@"W3C XML Schema xs:normalizedString — a string with no literal tab, newline, or carriage return characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdNormalizedString>))]
public readonly struct XsdNormalizedString : IIsoSimpleValue<string>, IEquatable<XsdNormalizedString>
{
    /// <summary>ISO 20022 format constraint for this type: no tab, newline, or carriage return.</summary>
    public const string Pattern = @"^[^\t\n\r]*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> contains a tab, newline, or carriage return.</exception>
    public XsdNormalizedString(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdNormalizedString), value, "xs:normalizedString — no tab, newline, or carriage return characters");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> contains no tab, newline, or carriage return.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNormalizedString result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdNormalizedString"/>.</summary>
    public static implicit operator XsdNormalizedString(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdNormalizedString v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdNormalizedString other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNormalizedString other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdNormalizedString a, XsdNormalizedString b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdNormalizedString a, XsdNormalizedString b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdNormalizedString a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNormalizedString a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdNormalizedString b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdNormalizedString b) => a != b.Value;
}
