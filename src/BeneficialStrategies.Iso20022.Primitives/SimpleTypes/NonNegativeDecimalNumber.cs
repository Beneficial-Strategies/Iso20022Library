// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Number of objects represented as a non negative decimal number, for example, 0.75 or 45.6.
/// </summary>
/// <remarks>
/// ISO 20022 Rate/Quantity data type <c>NonNegativeDecimalNumber</c>. Range: 0 (inclusive) and up, bounded by the totalDigits/fractionDigits facets below. Per XSD facet semantics,
/// totalDigits (18) and fractionDigits (17) are independent maximums,
/// not a fixed integer/fraction split — a value with fewer fraction digits than the fractionDigits
/// ceiling may use correspondingly more integer digits, up to totalDigits significant digits
/// total. (An earlier version of this type derived a fixed magnitude bound assuming
/// fractionDigits was always fully consumed, which incorrectly rejected valid whole numbers like
/// 141750 for types such as <see cref="DecimalNumber"/> — corrected to count actual digits used.)
/// (source: ISO 20022 MCP facets — minInclusive=0, totalDigits=18, fractionDigits=17).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_mX4tAyGwEeKjd4jizyIDGA")]
[Description(@"Number of objects represented as a non negative decimal number, for example, 0.75 or 45.6.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<NonNegativeDecimalNumber, decimal>))]
public readonly struct NonNegativeDecimalNumber : IIsoSimpleValue<decimal>, IEquatable<NonNegativeDecimalNumber>
{
    /// <summary>ISO 20022 totalDigits facet — the wire value may have at most this many significant digits (integer + fraction digits combined).</summary>
    public const int TotalDigits = 18;
    /// <summary>ISO 20022 fractionDigits facet — the wire value may have at most this many digits after the decimal point.</summary>
    public const int FractionDigits = 17;
    /// <summary>ISO 20022 minimum value (inclusive).</summary>
    public const decimal MinValue = 0m;

    /// <inheritdoc/>
    public decimal Value { get; }

    /// <summary>Initializes from the native <see cref="decimal"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is out of range or exceeds the totalDigits/fractionDigits facets.</exception>
    public NonNegativeDecimalNumber(decimal value)
    {
        if (value < MinValue)
            throw new Iso20022FormatException(typeof(NonNegativeDecimalNumber), value.ToString(CultureInfo.InvariantCulture), $"at least {MinValue}");

        var scale = GetScale(value);
        if (scale > FractionDigits)
            throw new Iso20022FormatException(typeof(NonNegativeDecimalNumber), value.ToString(CultureInfo.InvariantCulture), $"at most {FractionDigits} fraction digits");
        if (CountIntegerDigits(value) + scale > TotalDigits)
            throw new Iso20022FormatException(typeof(NonNegativeDecimalNumber), value.ToString(CultureInfo.InvariantCulture), $"at most {TotalDigits} significant digits total");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal string (e.g. <c>"0.75"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid decimal, out of range, or exceeds the digit facets.</exception>
    public NonNegativeDecimalNumber(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(NonNegativeDecimalNumber), value, "decimal string");
        this = new(parsed);
    }

    /// <summary>Extracts the number of digits actually stored after the decimal point (including trailing zeros).</summary>
    private static byte GetScale(decimal d) => (byte)((decimal.GetBits(d)[3] >> 16) & 0x7F);

    /// <summary>Counts the significant digits in the integer part of <paramref name="value"/> (minimum 1, even for zero).</summary>
    private static int CountIntegerDigits(decimal value)
    {
        var integerPart = Math.Truncate(Math.Abs(value));
        return integerPart == 0m ? 1 : integerPart.ToString(CultureInfo.InvariantCulture).Length;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range and precision.</summary>
    public static bool TryCreate(decimal value, [NotNullWhen(true)] out NonNegativeDecimalNumber result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range decimal.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NonNegativeDecimalNumber result)
    {
        if (value is not null && decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var parsed))
        {
            try
            { result = new(parsed); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a <see cref="decimal"/> as a <see cref="NonNegativeDecimalNumber"/>.</summary>
    public static implicit operator NonNegativeDecimalNumber(decimal value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="decimal"/> value.</summary>
    public static implicit operator decimal(NonNegativeDecimalNumber v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="NonNegativeDecimalNumber"/>.</summary>
    public static implicit operator NonNegativeDecimalNumber(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(NonNegativeDecimalNumber v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(NonNegativeDecimalNumber other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NonNegativeDecimalNumber other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(NonNegativeDecimalNumber a, NonNegativeDecimalNumber b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeDecimalNumber a, NonNegativeDecimalNumber b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(NonNegativeDecimalNumber a, decimal b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeDecimalNumber a, decimal b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(decimal a, NonNegativeDecimalNumber b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(decimal a, NonNegativeDecimalNumber b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(NonNegativeDecimalNumber a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeDecimalNumber a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, NonNegativeDecimalNumber b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, NonNegativeDecimalNumber b) => a != b.ToString();
}
