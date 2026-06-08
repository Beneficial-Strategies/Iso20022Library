// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:nonNegativeInteger — integer greater than or equal to zero.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:nonNegativeInteger</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="long"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("nonNegativeInteger_ID")]
[Description(@"W3C XML Schema xs:nonNegativeInteger — integer greater than or equal to zero.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdNonNegativeInteger, long>))]
public readonly struct XsdNonNegativeInteger : IIsoSimpleValue<long>, IEquatable<XsdNonNegativeInteger>
{
    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdNonNegativeInteger(long value)
    {
        if (!(value >= 0))
            throw new Iso20022FormatException(typeof(XsdNonNegativeInteger), value.ToString(System.Globalization.CultureInfo.InvariantCulture), "xs:nonNegativeInteger — must be >= 0");
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid long.</exception>
    public XsdNonNegativeInteger(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdNonNegativeInteger), value, "xs:nonNegativeInteger — long decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out XsdNonNegativeInteger result)
    {
        try { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid long.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNonNegativeInteger result)
    {
        if (value is not null && long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="XsdNonNegativeInteger"/>.</summary>
    public static implicit operator XsdNonNegativeInteger(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(XsdNonNegativeInteger v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdNonNegativeInteger"/>.</summary>
    public static implicit operator XsdNonNegativeInteger(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdNonNegativeInteger v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdNonNegativeInteger other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNonNegativeInteger other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(XsdNonNegativeInteger a, XsdNonNegativeInteger b) => a.Value == b.Value;
    public static bool operator !=(XsdNonNegativeInteger a, XsdNonNegativeInteger b) => a.Value != b.Value;
    public static bool operator ==(XsdNonNegativeInteger a, long b) => a.Value == b;
    public static bool operator !=(XsdNonNegativeInteger a, long b) => a.Value != b;
    public static bool operator ==(long a, XsdNonNegativeInteger b) => a == b.Value;
    public static bool operator !=(long a, XsdNonNegativeInteger b) => a != b.Value;
    public static bool operator ==(XsdNonNegativeInteger a, string? b) => a.ToString() == b;
    public static bool operator !=(XsdNonNegativeInteger a, string? b) => a.ToString() != b;
    public static bool operator ==(string? a, XsdNonNegativeInteger b) => a == b.ToString();
    public static bool operator !=(string? a, XsdNonNegativeInteger b) => a != b.ToString();
}
