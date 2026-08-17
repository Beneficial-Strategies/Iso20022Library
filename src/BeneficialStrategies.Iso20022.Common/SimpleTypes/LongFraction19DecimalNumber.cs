// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Number of objects represented as a decimal number, such as 0.75 or 45.6.
/// </summary>
/// <remarks>
/// ISO 20022 Rate/Quantity data type <c>LongFraction19DecimalNumber</c>. Signed (no minInclusive facet); bounded by the totalDigits/fractionDigits facets below. Per XSD facet semantics,
/// totalDigits (25) and fractionDigits (19) are independent maximums,
/// not a fixed integer/fraction split — a value with fewer fraction digits than the fractionDigits
/// ceiling may use correspondingly more integer digits, up to totalDigits significant digits
/// total. (An earlier version of this type derived a fixed magnitude bound assuming
/// fractionDigits was always fully consumed, which incorrectly rejected valid whole numbers like
/// 141750 for types such as <see cref="DecimalNumber"/> — corrected to count actual digits used.)
/// (source: ISO 20022 MCP facets — no minInclusive facet (signed), totalDigits=25, fractionDigits=19).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_-J5vIQbIEeqrW7Meu5r3kQ")]
[Description(@"Number of objects represented as a decimal number, such as 0.75 or 45.6.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<LongFraction19DecimalNumber, decimal>))]
public readonly struct LongFraction19DecimalNumber : IIsoSimpleValue<decimal>, IEquatable<LongFraction19DecimalNumber>
{
    /// <summary>ISO 20022 totalDigits facet — the wire value may have at most this many significant digits (integer + fraction digits combined).</summary>
    public const int TotalDigits = 25;
    /// <summary>ISO 20022 fractionDigits facet — the wire value may have at most this many digits after the decimal point.</summary>
    public const int FractionDigits = 19;

    /// <inheritdoc/>
    public decimal Value { get; }

    /// <summary>Initializes from the native <see cref="decimal"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is out of range or exceeds the totalDigits/fractionDigits facets.</exception>
    public LongFraction19DecimalNumber(decimal value)
    {

        var scale = GetScale(value);
        if (scale > FractionDigits)
            throw new Iso20022FormatException(typeof(LongFraction19DecimalNumber), value.ToString(CultureInfo.InvariantCulture), $"at most {FractionDigits} fraction digits");
        if (CountIntegerDigits(value) + scale > TotalDigits)
            throw new Iso20022FormatException(typeof(LongFraction19DecimalNumber), value.ToString(CultureInfo.InvariantCulture), $"at most {TotalDigits} significant digits total");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal string (e.g. <c>"0.75"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid decimal, out of range, or exceeds the digit facets.</exception>
    public LongFraction19DecimalNumber(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(LongFraction19DecimalNumber), value, "decimal string");
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
    public static bool TryCreate(decimal value, [NotNullWhen(true)] out LongFraction19DecimalNumber result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range decimal.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out LongFraction19DecimalNumber result)
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

    /// <summary>Implicitly wraps a <see cref="decimal"/> as a <see cref="LongFraction19DecimalNumber"/>.</summary>
    public static implicit operator LongFraction19DecimalNumber(decimal value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="decimal"/> value.</summary>
    public static implicit operator decimal(LongFraction19DecimalNumber v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="LongFraction19DecimalNumber"/>.</summary>
    public static implicit operator LongFraction19DecimalNumber(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(LongFraction19DecimalNumber v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(LongFraction19DecimalNumber other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is LongFraction19DecimalNumber other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(LongFraction19DecimalNumber a, LongFraction19DecimalNumber b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(LongFraction19DecimalNumber a, LongFraction19DecimalNumber b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(LongFraction19DecimalNumber a, decimal b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(LongFraction19DecimalNumber a, decimal b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(decimal a, LongFraction19DecimalNumber b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(decimal a, LongFraction19DecimalNumber b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(LongFraction19DecimalNumber a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(LongFraction19DecimalNumber a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, LongFraction19DecimalNumber b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, LongFraction19DecimalNumber b) => a != b.ToString();
}
