// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Number (max 9) of objects represented as an integer.
/// </summary>
/// <remarks>
/// ISO 20022 Quantity/Year data type <c>Max1Number</c>. Range: -9 to 9 (source: ISO 20022 MCP
/// Quantity facets — totalDigits=1, no minInclusive facet (signed)).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_4Sy68BIfEeamBoux7a_UUg")]
[Description(@"Number (max 9) of objects represented as an integer.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<Max1Number, long>))]
public readonly struct Max1Number : IIsoSimpleValue<long>, IEquatable<Max1Number>
{
    /// <summary>ISO 20022 minimum value (inclusive).</summary>
    public const long MinValue = -9L;
    /// <summary>ISO 20022 maximum value (inclusive).</summary>
    public const long MaxValue = 9L;

    /// <inheritdoc/>
    public long Value { get; }

    /// <summary>Initializes from the native <see cref="long"/> value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when the value is outside [<see cref="MinValue"/>, <see cref="MaxValue"/>].</exception>
    public Max1Number(long value)
    {
        if (value < MinValue || value > MaxValue)
            throw new Iso20022FormatException(typeof(Max1Number), value.ToString(CultureInfo.InvariantCulture), $"{MinValue} to {MaxValue}");
        Value = value;
    }

    /// <summary>Initializes by parsing the wire decimal integer string (e.g. <c>"42"</c>).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid integer, or out of range.</exception>
    public Max1Number(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
            throw new Iso20022FormatException(typeof(Max1Number), value, "decimal integer string");
        this = new(parsed);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within range.</summary>
    public static bool TryCreate(long value, [NotNullWhen(true)] out Max1Number result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> parses to a valid, in-range integer.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max1Number result)
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

    /// <summary>Implicitly wraps a <see cref="long"/> as a <see cref="Max1Number"/>.</summary>
    public static implicit operator Max1Number(long value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="long"/> value.</summary>
    public static implicit operator long(Max1Number v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="Max1Number"/>.</summary>
    public static implicit operator Max1Number(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(Max1Number v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(Max1Number other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max1Number other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(Max1Number a, Max1Number b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(Max1Number a, Max1Number b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(Max1Number a, long b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max1Number a, long b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(long a, Max1Number b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(long a, Max1Number b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(Max1Number a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(Max1Number a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max1Number b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max1Number b) => a != b.ToString();
}
