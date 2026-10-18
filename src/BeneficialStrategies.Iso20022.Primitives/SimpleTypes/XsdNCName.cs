// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:NCName — a "non-colonized" XML name (a <see cref="XsdName"/> that may not
/// contain a colon).
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:NCName</c>, restricting <c>xs:Name</c> (which itself
/// restricts <c>xs:token</c>) to exclude the colon character. Per the XML 1.0 <c>Name</c>
/// production: starts with a letter or underscore, followed by letters, digits, underscore,
/// hyphen, or period. The real W3C production permits a very large range of Unicode
/// <c>NameStartChar</c>/<c>NameChar</c> code points beyond ASCII; this implementation validates
/// the common ASCII-range subset only, matching this library's existing practical-simplification
/// convention for other XSD name-shaped types. Tighten (or rather, extend the character class) if
/// a non-ASCII NCName is ever encountered in practice.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("NCName_ID")]
[Description(@"W3C XML Schema xs:NCName — an XML name that does not contain a colon.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdNCName>))]
public readonly struct XsdNCName : IIsoSimpleValue<string>, IEquatable<XsdNCName>
{
    /// <summary>ASCII-range approximation of the xs:NCName lexical space (see type remarks).</summary>
    public const string Pattern = @"^[a-zA-Z_][a-zA-Z0-9_.\-]*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdNCName(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdNCName), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNCName result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdNCName"/>.</summary>
    public static implicit operator XsdNCName(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdNCName v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdNCName other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNCName other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdNCName a, XsdNCName b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdNCName a, XsdNCName b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdNCName a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNCName a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdNCName b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdNCName b) => a != b.Value;
}
