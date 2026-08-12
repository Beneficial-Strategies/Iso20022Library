// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:gMonthDay — a recurring Gregorian calendar month and day, optionally timezone-qualified.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:gMonthDay</c>.
/// Wire format: <c>"--MM-DD"</c> (e.g. <c>"--08-15"</c>), optionally followed by a timezone
/// suffix (<c>"Z"</c>, <c>"+05:00"</c>, <c>"-05:00"</c>). The day is validated against the
/// month's maximum length in a leap year (so <c>"--02-29"</c> is always accepted).
/// Programmatic access via <see cref="Value"/> returns the native <c>(Month, Day)</c> pair;
/// <see cref="TimezoneOffset"/> exposes the optional timezone separately.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("gMonthDay_ID")]
[Description(@"W3C XML Schema xs:gMonthDay — a recurring Gregorian calendar month and day, optionally timezone-qualified.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdGMonthDay, (byte Month, byte Day)>))]
public readonly struct XsdGMonthDay
    : IIsoSimpleValue<(byte Month, byte Day)>, IIsoTimezoneQualifiedValue, IEquatable<XsdGMonthDay>
{
    /// <summary>Pattern for the non-timezone core of the lexical form: <c>--MM-DD</c>.</summary>
    public const string CorePattern = @"^--(0[1-9]|1[0-2])-(\d{2})$";

    /// <inheritdoc/>
    public (byte Month, byte Day) Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from the native month and day, with an optional timezone offset.</summary>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when <paramref name="month"/> is outside 1-12, or <paramref name="day"/> exceeds
    /// that month's maximum length in a leap year.
    /// </exception>
    public XsdGMonthDay(byte month, byte day, TimeSpan? timezoneOffset = null)
    {
        if (month is < 1 or > 12)
            throw new Iso20022FormatException(typeof(XsdGMonthDay), $"{month}-{day}", "xs:gMonthDay — month 1-12");
        var maxDay = MaxDayForMonth(month);
        if (day < 1 || day > maxDay)
            throw new Iso20022FormatException(typeof(XsdGMonthDay), $"{month}-{day}", $"xs:gMonthDay — day 1-{maxDay} for month {month}");
        Value = (month, day);
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:gMonthDay lexical form: <c>"--MM-DD"</c>,
    /// optionally followed by a timezone.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:gMonthDay.</exception>
    public XsdGMonthDay(string value)
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
            throw new Iso20022FormatException(typeof(XsdGMonthDay), value, "xs:gMonthDay — \"--MM-DD\" with an optional timezone", ex);
        }
        var match = Regex.Match(core, CorePattern);
        if (!match.Success)
            throw new Iso20022FormatException(typeof(XsdGMonthDay), value, "xs:gMonthDay — \"--MM-DD\" with an optional timezone");
        var month = byte.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
        var day = byte.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
        var maxDay = MaxDayForMonth(month);
        if (day < 1 || day > maxDay)
            throw new Iso20022FormatException(typeof(XsdGMonthDay), value, $"xs:gMonthDay — day 1-{maxDay} for month {month}");
        Value = (month, day);
        TimezoneOffset = tz;
    }

    // Uses the leap-year maximum (Feb → 29) since gMonthDay is a recurring date with no year of its own.
    private static byte MaxDayForMonth(byte month) =>
        month switch
        {
            2 => 29,
            4 or 6 or 9 or 11 => 30,
            _ => 31,
        };

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="month"/>/<paramref name="day"/> form
    /// a valid xs:gMonthDay.
    /// </summary>
    public static bool TryCreate(byte month, byte day, TimeSpan? timezoneOffset, [NotNullWhen(true)] out XsdGMonthDay result)
    {
        try
        { result = new(month, day, timezoneOffset); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>
    /// Returns <see langword="true"/> when <paramref name="value"/>'s <c>Month</c>/<c>Day</c>
    /// form a valid xs:gMonthDay.
    /// </summary>
    public static bool TryCreate((byte Month, byte Day) value, [NotNullWhen(true)] out XsdGMonthDay result) =>
        TryCreate(value.Month, value.Day, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:gMonthDay lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdGMonthDay result)
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

    /// <summary>Implicitly wraps a wire string as a <see cref="XsdGMonthDay"/>.</summary>
    public static implicit operator XsdGMonthDay(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdGMonthDay v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => $"--{Value.Month:D2}-{Value.Day:D2}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(XsdGMonthDay other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdGMonthDay other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(XsdGMonthDay a, XsdGMonthDay b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonthDay a, XsdGMonthDay b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdGMonthDay a, (byte Month, byte Day) b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonthDay a, (byte Month, byte Day) b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==((byte Month, byte Day) a, XsdGMonthDay b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=((byte Month, byte Day) a, XsdGMonthDay b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdGMonthDay a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonthDay a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdGMonthDay b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdGMonthDay b) => a != b.ToString();
}
