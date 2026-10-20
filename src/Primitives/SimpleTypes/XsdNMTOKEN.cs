// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:NMTOKEN — an XML "name token", per the XML 1.0 <c>Nmtoken</c> production.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:NMTOKEN</c>, restricting <c>xs:token</c> to the XML 1.0
/// <c>Nmtoken</c> production: one or more <c>NameChar</c> characters. Unlike <see cref="XsdName"/>,
/// there is no "must start with a letter/underscore/colon" restriction — an NMTOKEN may start with
/// a digit, hyphen, or period. The real W3C production permits a very large range of Unicode
/// <c>NameChar</c> code points beyond ASCII; this implementation validates the common ASCII-range
/// subset only, matching this library's existing practical-simplification convention for other
/// XSD name-shaped types.
/// </remarks>
/// <seealso cref="XsdName"/>
[DataContract]
[Serializable]
[IsoId("NMTOKEN_ID")]
[Description(@"W3C XML Schema xs:NMTOKEN — an XML name token, per the XML 1.0 Nmtoken production.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdNMTOKEN>))]
public readonly struct XsdNMTOKEN : IIsoSimpleValue<string>, IEquatable<XsdNMTOKEN>
{
    /// <summary>ASCII-range approximation of the xs:NMTOKEN lexical space (see type remarks).</summary>
    public const string Pattern = @"^[a-zA-Z0-9_:.\-]+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdNMTOKEN(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdNMTOKEN), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNMTOKEN result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdNMTOKEN"/>.</summary>
    public static implicit operator XsdNMTOKEN(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdNMTOKEN v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdNMTOKEN other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNMTOKEN other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdNMTOKEN a, XsdNMTOKEN b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdNMTOKEN a, XsdNMTOKEN b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdNMTOKEN a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNMTOKEN a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdNMTOKEN b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdNMTOKEN b) => a != b.Value;
}
