// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISOYearMonth — a month within a particular calendar year.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "Month within a particular calendar year represented by
/// YYYY-MM (ISO 8601)." Unlike <see cref="XsdGYearMonth"/> (the W3C xs:gYearMonth builtin this
/// otherwise closely resembles), ISO 20022's own definition text does not mention an optional
/// timezone suffix, so this type omits <see cref="IIsoTimezoneQualifiedValue"/> — just the bare
/// composite <c>(Year, Month)</c> pair, which still needs <see cref="IIsoCompositeSimpleValue"/>
/// since the generic per-<c>T</c> leaf formatter can't reconstruct <c>"YYYY-MM"</c> from a tuple's
/// default <see cref="object.ToString"/> (e.g. <c>"(2026, 8)"</c>). Before this type existed,
/// <c>IsoISOYearMonth</c> was aliased to <see cref="System.UInt16"/>, which cannot hold a
/// "YYYY-MM"-shaped value at all — UInt16's own maximum (65535) is smaller than even a single
/// plausible <c>YYYYMM</c> encoding (e.g. 202608).
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYU64tp-Ed-ak6NoX_4Aeg_-1824134999")]
[Description(@"Month within a particular calendar year represented by YYYY-MM (ISO 8601).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISOYearMonth, (int Year, int Month)>))]
public readonly struct ISOYearMonth : IIsoSimpleValue<(int Year, int Month)>, IIsoCompositeSimpleValue, IEquatable<ISOYearMonth>
{
    /// <summary>Pattern for the lexical form: <c>YYYY-MM</c>.</summary>
    public const string Pattern = @"^(\d{4,})-(0[1-9]|1[0-2])$";

    /// <inheritdoc/>
    public (int Year, int Month) Value { get; }

    /// <summary>Initializes from the native year and month.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="month"/> is outside 1-12.</exception>
    public ISOYearMonth(int year, int month)
    {
        if (month is < 1 or > 12)
            throw new Iso20022FormatException(typeof(ISOYearMonth), month.ToString(CultureInfo.InvariantCulture), "month 1-12");
        Value = (year, month);
    }

    /// <summary>Initializes by parsing the ISO 20022 ISOYearMonth lexical form: <c>"YYYY-MM"</c>.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ISOYearMonth.</exception>
    public ISOYearMonth(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var match = Regex.Match(value, Pattern);
        if (!match.Success)
            throw new Iso20022FormatException(typeof(ISOYearMonth), value, "\"YYYY-MM\"");
        Value = (int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture), int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture));
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="month"/> is within 1-12.</summary>
    public static bool TryCreate(int year, int month, [NotNullWhen(true)] out ISOYearMonth result)
    {
        try
        { result = new(year, month); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/>'s <c>Month</c> is within 1-12.</summary>
    public static bool TryCreate((int Year, int Month) value, [NotNullWhen(true)] out ISOYearMonth result) =>
        TryCreate(value.Year, value.Month, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISOYearMonth lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISOYearMonth result)
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

    /// <summary>Implicitly wraps a wire string as an <see cref="ISOYearMonth"/>.</summary>
    public static implicit operator ISOYearMonth(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISOYearMonth v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        $"{Value.Year.ToString("D4", CultureInfo.InvariantCulture)}-{Value.Month:D2}";
    /// <inheritdoc/>
    public bool Equals(ISOYearMonth other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOYearMonth other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(ISOYearMonth a, ISOYearMonth b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISOYearMonth a, ISOYearMonth b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISOYearMonth a, (int Year, int Month) b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOYearMonth a, (int Year, int Month) b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==((int Year, int Month) a, ISOYearMonth b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=((int Year, int Month) a, ISOYearMonth b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISOYearMonth a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOYearMonth a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOYearMonth b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOYearMonth b) => a != b.ToString();
}
