// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:gDay — a Gregorian calendar day of the month (01 to 31), optionally timezone-qualified.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:gDay</c>.
/// Wire format: <c>"---DD"</c> (e.g. <c>"---15"</c>), optionally followed by a timezone suffix
/// (<c>"Z"</c>, <c>"+05:00"</c>, <c>"-05:00"</c>).
/// Programmatic access via <see cref="Value"/> returns the native day number (1-31);
/// <see cref="TimezoneOffset"/> exposes the optional timezone separately.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("gDay_ID")]
[Description(@"W3C XML Schema xs:gDay — a Gregorian calendar day of the month (01 to 31), optionally timezone-qualified.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdGDay, byte>))]
public readonly struct XsdGDay : IIsoSimpleValue<byte>, IIsoTimezoneQualifiedValue, IEquatable<XsdGDay>
{
    /// <summary>Pattern for the non-timezone core of the lexical form: <c>---DD</c>.</summary>
    public const string CorePattern = @"^---(0[1-9]|[12]\d|3[01])$";

    /// <inheritdoc/>
    public byte Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from the native day number (1-31), with an optional timezone offset.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="day"/> is outside 1-31.</exception>
    public XsdGDay(byte day, TimeSpan? timezoneOffset = null)
    {
        if (day is < 1 or > 31)
            throw new Iso20022FormatException(typeof(XsdGDay), day.ToString(CultureInfo.InvariantCulture), "xs:gDay — day 1-31");
        Value = day;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:gDay lexical form: <c>"---DD"</c>, optionally
    /// followed by a timezone.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:gDay.</exception>
    public XsdGDay(string value)
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
            throw new Iso20022FormatException(typeof(XsdGDay), value, "xs:gDay — \"---DD\" with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(XsdGDay), value, "xs:gDay — \"---DD\" (day 01-31) with an optional timezone");
        Value = byte.Parse(core.AsSpan(3, 2), CultureInfo.InvariantCulture);
        TimezoneOffset = tz;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="day"/> is within 1-31.</summary>
    public static bool TryCreate(byte day, TimeSpan? timezoneOffset, [NotNullWhen(true)] out XsdGDay result)
    {
        try
        { result = new(day, timezoneOffset); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="day"/> is within 1-31.</summary>
    public static bool TryCreate(byte day, [NotNullWhen(true)] out XsdGDay result) => TryCreate(day, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:gDay lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdGDay result)
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

    /// <summary>Implicitly wraps a native day number as a <see cref="XsdGDay"/> (no timezone).</summary>
    public static implicit operator XsdGDay(byte day) => new(day);
    /// <summary>Implicitly unwraps to the native day number, discarding any timezone.</summary>
    public static implicit operator byte(XsdGDay v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdGDay"/>.</summary>
    public static implicit operator XsdGDay(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdGDay v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => $"---{Value:D2}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(XsdGDay other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdGDay other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(XsdGDay a, XsdGDay b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdGDay a, XsdGDay b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdGDay a, byte b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGDay a, byte b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(byte a, XsdGDay b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(byte a, XsdGDay b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdGDay a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGDay a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdGDay b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdGDay b) => a != b.ToString();
}
