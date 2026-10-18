// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:Name — an XML name, per the XML 1.0 <c>Name</c> production.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:Name</c>, restricting <c>xs:token</c> to the XML 1.0
/// <c>Name</c> production: starts with a letter, underscore, or colon, followed by letters,
/// digits, underscore, colon, hyphen, or period. The real W3C production permits a very large
/// range of Unicode <c>NameStartChar</c>/<c>NameChar</c> code points beyond ASCII; this
/// implementation validates the common ASCII-range subset only, matching this library's existing
/// practical-simplification convention for other XSD name-shaped types (see also
/// <see cref="XsdNCName"/>, the colon-excluding restriction of this type).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("Name_ID")]
[Description(@"W3C XML Schema xs:Name — an XML name, per the XML 1.0 Name production.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdName>))]
public readonly struct XsdName : IIsoSimpleValue<string>, IEquatable<XsdName>
{
    /// <summary>ASCII-range approximation of the xs:Name lexical space (see type remarks).</summary>
    public const string Pattern = @"^[a-zA-Z_:][a-zA-Z0-9_:.\-]*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdName(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdName), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdName result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdName"/>.</summary>
    public static implicit operator XsdName(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdName v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdName other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdName other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdName a, XsdName b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdName a, XsdName b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdName a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdName a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdName b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdName b) => a != b.Value;
}
