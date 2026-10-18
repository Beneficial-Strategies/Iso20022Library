// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:gYearMonth — a Gregorian calendar year and month, optionally timezone-qualified.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:gYearMonth</c>.
/// Wire format: <c>"YYYY-MM"</c> (e.g. <c>"2026-08"</c>), the year optionally prefixed with
/// <c>"-"</c> for BCE and having more than four digits, optionally followed by a timezone suffix
/// (<c>"Z"</c>, <c>"+05:00"</c>, <c>"-05:00"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <c>(Year, Month)</c> pair;
/// <see cref="TimezoneOffset"/> exposes the optional timezone separately.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("gYearMonth_ID")]
[Description(@"W3C XML Schema xs:gYearMonth — a Gregorian calendar year and month, optionally timezone-qualified.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdGYearMonth, (int Year, byte Month)>))]
public readonly struct XsdGYearMonth
    : IIsoSimpleValue<(int Year, byte Month)>, IIsoTimezoneQualifiedValue, IEquatable<XsdGYearMonth>
{
    /// <summary>Pattern for the non-timezone core of the lexical form: <c>YYYY-MM</c>.</summary>
    public const string CorePattern = @"^(-?\d{4,})-(0[1-9]|1[0-2])$";

    /// <inheritdoc/>
    public (int Year, byte Month) Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from the native year and month, with an optional timezone offset.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="month"/> is outside 1-12.</exception>
    public XsdGYearMonth(int year, byte month, TimeSpan? timezoneOffset = null)
    {
        if (month is < 1 or > 12)
            throw new Iso20022FormatException(typeof(XsdGYearMonth), month.ToString(CultureInfo.InvariantCulture), "xs:gYearMonth — month 1-12");
        Value = (year, month);
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:gYearMonth lexical form: <c>"YYYY-MM"</c>,
    /// optionally followed by a timezone.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:gYearMonth.</exception>
    public XsdGYearMonth(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        string core;
        TimeSpan? tz;
        try
        {
            (core, tz) = XsdTimezone.SplitTrailingTimezone(value);
        }
        catch (FormatException ex)
        {
            throw new Iso20022FormatException(typeof(XsdGYearMonth), value, "xs:gYearMonth — \"YYYY-MM\" with an optional timezone", ex);
        }
        var match = Regex.Match(core, CorePattern);
        if (!match.Success)
            throw new Iso20022FormatException(typeof(XsdGYearMonth), value, "xs:gYearMonth — \"YYYY-MM\" with an optional timezone");
        Value = (int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture), byte.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture));
        TimezoneOffset = tz;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="month"/> is within 1-12.</summary>
    public static bool TryCreate(int year, byte month, TimeSpan? timezoneOffset, [NotNullWhen(true)] out XsdGYearMonth result)
    {
        try
        { result = new(year, month, timezoneOffset); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/>'s <c>Month</c> is within 1-12.</summary>
    public static bool TryCreate((int Year, byte Month) value, [NotNullWhen(true)] out XsdGYearMonth result) =>
        TryCreate(value.Year, value.Month, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:gYearMonth lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdGYearMonth result)
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

    /// <summary>Implicitly wraps a wire string as a <see cref="XsdGYearMonth"/>.</summary>
    public static implicit operator XsdGYearMonth(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdGYearMonth v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString()
    {
        var digits = Math.Abs(Value.Year).ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');
        var sign = Value.Year < 0 ? "-" : "";
        return $"{sign}{digits}-{Value.Month:D2}{XsdTimezone.Format(TimezoneOffset)}";
    }
    /// <inheritdoc/>
    public bool Equals(XsdGYearMonth other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdGYearMonth other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(XsdGYearMonth a, XsdGYearMonth b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdGYearMonth a, XsdGYearMonth b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdGYearMonth a, (int Year, byte Month) b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGYearMonth a, (int Year, byte Month) b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==((int Year, byte Month) a, XsdGYearMonth b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=((int Year, byte Month) a, XsdGYearMonth b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdGYearMonth a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGYearMonth a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdGYearMonth b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdGYearMonth b) => a != b.ToString();
}
