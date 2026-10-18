// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Non negative integer.
/// </summary>
/// <remarks>
/// ISO 20022 Quantity/Year data type <c>NonNegativeNumber</c>. Range: 0 to 999999999999999999 (source: ISO 20022 MCP
/// Quantity facets — minInclusive=0, totalDigits=18).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_UJsWsFGuEeeqtLmveSCYmA")]
[Description(@"Non negative integer.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<NonNegativeNumber, long>))]
public readonly struct NonNegativeNumber : IIsoSimpleValue<long>, IEquatable<NonNegativeNumber>
{
    /// <summary>ISO 20022 minimum value (inclusive).</summary>
    public const long MinValue = 0L;
    /// <summary>ISO 20022 maximum value (inclusive).</summary>
    public const long MaxValue = 999999999999999999L;

    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside [<see cref="MinValue"/>, <see cref="MaxValue"/>].</exception>
    public NonNegativeNumber(long value)
    {
        if (value < MinValue || value > MaxValue)
            throw new Iso20022FormatException(typeof(NonNegativeNumber), value.ToString(CultureInfo.InvariantCulture), $"{MinValue} to {MaxValue}");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid integer, or out of range.</exception>
    public NonNegativeNumber(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(NonNegativeNumber), value, "decimal integer string");
        this = new(parsed);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out NonNegativeNumber result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range integer.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NonNegativeNumber result)
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

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="NonNegativeNumber"/>.</summary>
    public static implicit operator NonNegativeNumber(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(NonNegativeNumber v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="NonNegativeNumber"/>.</summary>
    public static implicit operator NonNegativeNumber(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(NonNegativeNumber v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(NonNegativeNumber other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NonNegativeNumber other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(NonNegativeNumber a, NonNegativeNumber b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeNumber a, NonNegativeNumber b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(NonNegativeNumber a, long b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeNumber a, long b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(long a, NonNegativeNumber b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(long a, NonNegativeNumber b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(NonNegativeNumber a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(NonNegativeNumber a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, NonNegativeNumber b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, NonNegativeNumber b) => a != b.ToString();
}
