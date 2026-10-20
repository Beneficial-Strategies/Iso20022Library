// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Number of objects represented as a positive integer.
/// </summary>
/// <remarks>
/// ISO 20022 Quantity/Year data type <c>PositiveNumber</c>. Range: 1 to 999999999999999999 (source: ISO 20022 MCP
/// Quantity facets — minInclusive=1, totalDigits=18).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_AlfR4c_dEeWjSMe6YTKHlQ")]
[Description(@"Number of objects represented as a positive integer.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<PositiveNumber, long>))]
public readonly struct PositiveNumber : IIsoSimpleValue<long>, IEquatable<PositiveNumber>
{
    /// <summary>ISO 20022 minimum value (inclusive).</summary>
    public const long MinValue = 1L;
    /// <summary>ISO 20022 maximum value (inclusive).</summary>
    public const long MaxValue = 999999999999999999L;

    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside [<see cref="MinValue"/>, <see cref="MaxValue"/>].</exception>
    public PositiveNumber(long value)
    {
        if (value < MinValue || value > MaxValue)
            throw new Iso20022FormatException(typeof(PositiveNumber), value.ToString(CultureInfo.InvariantCulture), $"{MinValue} to {MaxValue}");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid integer, or out of range.</exception>
    public PositiveNumber(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(PositiveNumber), value, "decimal integer string");
        this = new(parsed);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out PositiveNumber result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range integer.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out PositiveNumber result)
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

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="PositiveNumber"/>.</summary>
    public static implicit operator PositiveNumber(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(PositiveNumber v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="PositiveNumber"/>.</summary>
    public static implicit operator PositiveNumber(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(PositiveNumber v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(PositiveNumber other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PositiveNumber other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(PositiveNumber a, PositiveNumber b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(PositiveNumber a, PositiveNumber b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(PositiveNumber a, long b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(PositiveNumber a, long b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(long a, PositiveNumber b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(long a, PositiveNumber b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(PositiveNumber a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(PositiveNumber a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, PositiveNumber b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, PositiveNumber b) => a != b.ToString();
}
