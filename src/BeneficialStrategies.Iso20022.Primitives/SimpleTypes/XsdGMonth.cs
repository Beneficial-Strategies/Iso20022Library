// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:gMonth — a Gregorian calendar month (01 to 12), optionally timezone-qualified.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:gMonth</c>.
/// Wire format: <c>"--MM"</c> (e.g. <c>"--06"</c>), optionally followed by a timezone suffix
/// (<c>"Z"</c>, <c>"+05:00"</c>, <c>"-05:00"</c>).
/// Programmatic access via <see cref="Value"/> returns the native month number (1-12);
/// <see cref="TimezoneOffset"/> exposes the optional timezone separately.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("gMonth_ID")]
[Description(@"W3C XML Schema xs:gMonth — a Gregorian calendar month (01 to 12), optionally timezone-qualified.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdGMonth, byte>))]
public readonly struct XsdGMonth : IIsoSimpleValue<byte>, IIsoTimezoneQualifiedValue, IEquatable<XsdGMonth>
{
    /// <summary>Pattern for the non-timezone core of the lexical form: <c>--MM</c>.</summary>
    public const string CorePattern = @"^--(0[1-9]|1[0-2])$";

    /// <inheritdoc/>
    public byte Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from the native month number (1-12), with an optional timezone offset.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="month"/> is outside 1-12.</exception>
    public XsdGMonth(byte month, TimeSpan? timezoneOffset = null)
    {
        if (month is < 1 or > 12)
            throw new Iso20022FormatException(typeof(XsdGMonth), month.ToString(CultureInfo.InvariantCulture), "xs:gMonth — month 1-12");
        Value = month;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:gMonth lexical form: <c>"--MM"</c>, optionally
    /// followed by a timezone.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:gMonth.</exception>
    public XsdGMonth(string value)
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
            throw new Iso20022FormatException(typeof(XsdGMonth), value, "xs:gMonth — \"--MM\" with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(XsdGMonth), value, "xs:gMonth — \"--MM\" (month 01-12) with an optional timezone");
        Value = byte.Parse(core.AsSpan(2, 2), CultureInfo.InvariantCulture);
        TimezoneOffset = tz;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="month"/> is within 1-12.</summary>
    public static bool TryCreate(byte month, TimeSpan? timezoneOffset, [NotNullWhen(true)] out XsdGMonth result)
    {
        try
        { result = new(month, timezoneOffset); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="month"/> is within 1-12.</summary>
    public static bool TryCreate(byte month, [NotNullWhen(true)] out XsdGMonth result) => TryCreate(month, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:gMonth lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdGMonth result)
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

    /// <summary>Implicitly wraps a native month number as a <see cref="XsdGMonth"/> (no timezone).</summary>
    public static implicit operator XsdGMonth(byte month) => new(month);
    /// <summary>Implicitly unwraps to the native month number, discarding any timezone.</summary>
    public static implicit operator byte(XsdGMonth v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdGMonth"/>.</summary>
    public static implicit operator XsdGMonth(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdGMonth v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => $"--{Value:D2}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(XsdGMonth other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdGMonth other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(XsdGMonth a, XsdGMonth b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonth a, XsdGMonth b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdGMonth a, byte b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonth a, byte b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(byte a, XsdGMonth b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(byte a, XsdGMonth b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdGMonth a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGMonth a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdGMonth b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdGMonth b) => a != b.ToString();
}
