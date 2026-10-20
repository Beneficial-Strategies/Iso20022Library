// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:NMTOKENS — a whitespace-separated list of one or more xs:NMTOKEN values.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:NMTOKENS</c> — a list type over <c>xs:NMTOKEN</c>. Each
/// whitespace-separated token has the same lexical shape as <see cref="XsdNMTOKEN"/> (see that
/// type's remarks for the ASCII-simplification caveat).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("NMTOKENS_ID")]
[Description(@"W3C XML Schema xs:NMTOKENS — a whitespace-separated list of one or more xs:NMTOKEN values.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<XsdNMTOKENS>))]
public readonly struct XsdNMTOKENS : IIsoSimpleValue<string>, IEquatable<XsdNMTOKENS>
{
    /// <summary>One or more whitespace-separated xs:NMTOKEN-shaped tokens (see type remarks).</summary>
    public const string Pattern = @"^[a-zA-Z0-9_:.\-]+(\s+[a-zA-Z0-9_:.\-]+)*$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public XsdNMTOKENS(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(XsdNMTOKENS), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNMTOKENS result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="string"/> as a <see cref="XsdNMTOKENS"/>.</summary>
    public static implicit operator XsdNMTOKENS(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying <see cref="string"/> value.</summary>
    public static implicit operator string(XsdNMTOKENS v) => v.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(XsdNMTOKENS other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNMTOKENS other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(XsdNMTOKENS a, XsdNMTOKENS b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdNMTOKENS a, XsdNMTOKENS b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdNMTOKENS a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNMTOKENS a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdNMTOKENS b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdNMTOKENS b) => a != b.Value;
}
