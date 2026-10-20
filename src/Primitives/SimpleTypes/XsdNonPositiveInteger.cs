// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:nonPositiveInteger — integer less than or equal to zero.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:nonPositiveInteger</c>.
/// Wire format: decimal integer string (e.g. <c>"42"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="long"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("nonPositiveInteger_ID")]
[Description(@"W3C XML Schema xs:nonPositiveInteger — integer less than or equal to zero.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdNonPositiveInteger, long>))]
public readonly struct XsdNonPositiveInteger : IIsoSimpleValue<long>, IEquatable<XsdNonPositiveInteger>
{
    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside the allowed range.</exception>
    public XsdNonPositiveInteger(long value)
    {
        if (!(value <= 0))
            throw new Iso20022FormatException(typeof(XsdNonPositiveInteger), value.ToString(System.Globalization.CultureInfo.InvariantCulture), "xs:nonPositiveInteger — must be <= 0");
        Value = value;
    }

    /// <summary>Initializes by parsing the W3C XSD decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid long.</exception>
    public XsdNonPositiveInteger(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(XsdNonPositiveInteger), value, "xs:nonPositiveInteger — long decimal integer");
        this = new(parsed); // delegate to native ctor for range check
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out XsdNonPositiveInteger result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid long.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdNonPositiveInteger result)
    {
        if (value is not null && long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            try
            { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="XsdNonPositiveInteger"/>.</summary>
    public static implicit operator XsdNonPositiveInteger(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(XsdNonPositiveInteger v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdNonPositiveInteger"/>.</summary>
    public static implicit operator XsdNonPositiveInteger(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdNonPositiveInteger v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(XsdNonPositiveInteger other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdNonPositiveInteger other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdNonPositiveInteger a, XsdNonPositiveInteger b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdNonPositiveInteger a, XsdNonPositiveInteger b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdNonPositiveInteger a, long b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNonPositiveInteger a, long b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(long a, XsdNonPositiveInteger b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(long a, XsdNonPositiveInteger b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdNonPositiveInteger a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdNonPositiveInteger a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdNonPositiveInteger b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdNonPositiveInteger b) => a != b.ToString();
}
