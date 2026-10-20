// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Number of objects represented as an integer.
/// </summary>
/// <remarks>
/// ISO 20022 Quantity/Year data type <c>Number</c>. Range: -999999999999999999 to 999999999999999999 (source: ISO 20022 MCP
/// Quantity facets — totalDigits=18, no minInclusive facet (signed)).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXbjBtp-Ed-ak6NoX_4Aeg_1560899033")]
[Description(@"Number of objects represented as an integer.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<Number, long>))]
public readonly struct Number : IIsoSimpleValue<long>, IEquatable<Number>
{
    /// <summary>ISO 20022 minimum value (inclusive).</summary>
    public const long MinValue = -999999999999999999L;
    /// <summary>ISO 20022 maximum value (inclusive).</summary>
    public const long MaxValue = 999999999999999999L;

    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside [<see cref="MinValue"/>, <see cref="MaxValue"/>].</exception>
    public Number(long value)
    {
        if (value < MinValue || value > MaxValue)
            throw new Iso20022FormatException(typeof(Number), value.ToString(CultureInfo.InvariantCulture), $"{MinValue} to {MaxValue}");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid integer, or out of range.</exception>
    public Number(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(Number), value, "decimal integer string");
        this = new(parsed);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out Number result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range integer.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Number result)
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

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="Number"/>.</summary>
    public static implicit operator Number(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(Number v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="Number"/>.</summary>
    public static implicit operator Number(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(Number v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(Number other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Number other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(Number a, Number b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(Number a, Number b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(Number a, long b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Number a, long b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(long a, Number b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(long a, Number b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(Number a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(Number a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Number b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, Number b) => a != b.ToString();
}
