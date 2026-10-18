// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 RestrictedMonthExact2Number — a two-digit restricted list for representing calendar
/// months.
/// </summary>
/// <remarks>
/// ISO 20022 Quantity data type <c>RestrictedMonthExact2Number</c>. Per its MCP facets:
/// minInclusive=1, maxInclusive=12, totalDigits=2, fractionDigits=0, pattern <c>"[0-9]{2,2}"</c> —
/// the explicit pattern facet means the wire form is always exactly 2 digits, zero-padded (e.g.
/// month 1 is <c>"01"</c>, not <c>"1"</c>). Implements <see cref="IIsoCompositeSimpleValue"/> to
/// force the serializer to defer to this type's own zero-padded <see cref="ToString"/> rather
/// than the generic unpadded integer formatter that the previous
/// <c>IsoRestrictedMonthExact2Number = System.UInt64</c> alias would have used.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_QlWQYCTBEeWsI5Sp3-B3zg")]
[Description(@"Two digit restricted list for use representing calendar months.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<RestrictedMonthExact2Number, int>))]
public readonly struct RestrictedMonthExact2Number : IIsoSimpleValue<int>, IIsoCompositeSimpleValue, IEquatable<RestrictedMonthExact2Number>
{
    /// <summary>Pattern for the lexical form: exactly 2 digits, per the ISO 20022 facet.</summary>
    public const string Pattern = @"^[0-9]{2}$";

    /// <inheritdoc/>
    public int Value { get; }

    /// <summary>Initializes from the native month value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> is outside 1-12.</exception>
    public RestrictedMonthExact2Number(int value)
    {
        if (value is < 1 or > 12)
            throw new Iso20022FormatException(typeof(RestrictedMonthExact2Number), value.ToString(CultureInfo.InvariantCulture), "1 to 12");
        Value = value;
    }

    /// <summary>Initializes by parsing the ISO 20022 lexical form: exactly 2 digits, "01" to "12".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid 2-digit month.</exception>
    public RestrictedMonthExact2Number(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(RestrictedMonthExact2Number), value, Pattern);
        this = new(int.Parse(value, CultureInfo.InvariantCulture));
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within 1-12.</summary>
    public static bool TryCreate(int value, [NotNullWhen(true)] out RestrictedMonthExact2Number result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid 2-digit month.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedMonthExact2Number result)
    {
        if (value is not null)
        {
            try
            { result = new(value); return true; }
            catch (Iso20022FormatException) { }
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a native <see cref="int"/> as a <see cref="RestrictedMonthExact2Number"/>.</summary>
    public static implicit operator RestrictedMonthExact2Number(int value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="int"/> value.</summary>
    public static implicit operator int(RestrictedMonthExact2Number v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="RestrictedMonthExact2Number"/>.</summary>
    public static implicit operator RestrictedMonthExact2Number(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(RestrictedMonthExact2Number v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString("D2", CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(RestrictedMonthExact2Number other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedMonthExact2Number other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(RestrictedMonthExact2Number a, RestrictedMonthExact2Number b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedMonthExact2Number a, RestrictedMonthExact2Number b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(RestrictedMonthExact2Number a, int b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedMonthExact2Number a, int b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(int a, RestrictedMonthExact2Number b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(int a, RestrictedMonthExact2Number b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(RestrictedMonthExact2Number a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedMonthExact2Number a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, RestrictedMonthExact2Number b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, RestrictedMonthExact2Number b) => a != b.ToString();
}
