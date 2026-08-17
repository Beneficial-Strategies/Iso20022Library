// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70% with 13 fractional digits maximum and 14 total digits.
/// </summary>
/// <remarks>
/// ISO 20022 Rate/Quantity data type <c>BaseOne14Rate</c>. Signed (no minInclusive facet); bounded by the totalDigits/fractionDigits facets below. Per XSD facet semantics,
/// totalDigits (14) and fractionDigits (13) are independent maximums,
/// not a fixed integer/fraction split — a value with fewer fraction digits than the fractionDigits
/// ceiling may use correspondingly more integer digits, up to totalDigits significant digits
/// total. (An earlier version of this type derived a fixed magnitude bound assuming
/// fractionDigits was always fully consumed, which incorrectly rejected valid whole numbers like
/// 141750 for types such as <see cref="DecimalNumber"/> — corrected to count actual digits used.)
/// (source: ISO 20022 MCP facets — no minInclusive facet (signed), totalDigits=14, fractionDigits=13. baseValue=1.0).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_k8XskCqhEeObprHJy8Zrxg")]
[Description(@"Rate expressed as a decimal, for example, 0.7 is 7/10 and 70% with 13 fractional digits maximum and 14 total digits.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<BaseOne14Rate, decimal>))]
public readonly struct BaseOne14Rate : IIsoSimpleValue<decimal>, IEquatable<BaseOne14Rate>
{
    /// <summary>ISO 20022 totalDigits facet — the wire value may have at most this many significant digits (integer + fraction digits combined).</summary>
    public const int TotalDigits = 14;
    /// <summary>ISO 20022 fractionDigits facet — the wire value may have at most this many digits after the decimal point.</summary>
    public const int FractionDigits = 13;

    /// <inheritdoc/>
    public decimal Value { get; }

    /// <summary>Initializes from the native <see cref="decimal"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is out of range or exceeds the totalDigits/fractionDigits facets.</exception>
    public BaseOne14Rate(decimal value)
    {

        var scale = GetScale(value);
        if (scale > FractionDigits)
            throw new Iso20022FormatException(typeof(BaseOne14Rate), value.ToString(CultureInfo.InvariantCulture), $"at most {FractionDigits} fraction digits");
        if (CountIntegerDigits(value) + scale > TotalDigits)
            throw new Iso20022FormatException(typeof(BaseOne14Rate), value.ToString(CultureInfo.InvariantCulture), $"at most {TotalDigits} significant digits total");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal string (e.g. <c>"0.75"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid decimal, out of range, or exceeds the digit facets.</exception>
    public BaseOne14Rate(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(BaseOne14Rate), value, "decimal string");
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
    public static bool TryCreate(decimal value, [NotNullWhen(true)] out BaseOne14Rate result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range decimal.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BaseOne14Rate result)
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

    /// <summary>Implicitly wraps a <see cref="decimal"/> as a <see cref="BaseOne14Rate"/>.</summary>
    public static implicit operator BaseOne14Rate(decimal value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="decimal"/> value.</summary>
    public static implicit operator decimal(BaseOne14Rate v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="BaseOne14Rate"/>.</summary>
    public static implicit operator BaseOne14Rate(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(BaseOne14Rate v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(BaseOne14Rate other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BaseOne14Rate other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(BaseOne14Rate a, BaseOne14Rate b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(BaseOne14Rate a, BaseOne14Rate b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(BaseOne14Rate a, decimal b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BaseOne14Rate a, decimal b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(decimal a, BaseOne14Rate b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(decimal a, BaseOne14Rate b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(BaseOne14Rate a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(BaseOne14Rate a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BaseOne14Rate b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, BaseOne14Rate b) => a != b.ToString();
}
