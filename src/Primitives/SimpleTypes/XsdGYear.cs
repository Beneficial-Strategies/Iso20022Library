// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:gYear — a Gregorian calendar year, optionally timezone-qualified.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:gYear</c>.
/// Wire format: four or more digits (e.g. <c>"2026"</c>), optionally prefixed with <c>"-"</c>
/// for a BCE year, and optionally followed by a timezone suffix (<c>"Z"</c>, <c>"+05:00"</c>,
/// <c>"-05:00"</c>).
/// Programmatic access via <see cref="Value"/> returns the native year number (negative for
/// BCE); <see cref="TimezoneOffset"/> exposes the optional timezone separately.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("gYear_ID")]
[Description(@"W3C XML Schema xs:gYear — a Gregorian calendar year, optionally timezone-qualified.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdGYear, int>))]
public readonly struct XsdGYear : IIsoSimpleValue<int>, IIsoTimezoneQualifiedValue, IEquatable<XsdGYear>
{
    /// <summary>Pattern for the non-timezone core of the lexical form: <c>-?\d{4,}</c>.</summary>
    public const string CorePattern = @"^-?\d{4,}$";

    /// <inheritdoc/>
    public int Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from the native year number (negative for BCE), with an optional timezone offset.</summary>
    public XsdGYear(int year, TimeSpan? timezoneOffset = null)
    {
        Value = year;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:gYear lexical form: four or more digits, optionally
    /// prefixed with <c>"-"</c>, and optionally followed by a timezone.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:gYear.</exception>
    public XsdGYear(string value)
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
            throw new Iso20022FormatException(typeof(XsdGYear), value, "xs:gYear — 4+ digits with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(XsdGYear), value, "xs:gYear — 4+ digits, optionally prefixed \"-\", with an optional timezone");
        Value = int.Parse(core, CultureInfo.InvariantCulture);
        TimezoneOffset = tz;
    }

    /// <summary>Always succeeds — every <see cref="int"/> is a valid xs:gYear value.</summary>
    public static bool TryCreate(int year, TimeSpan? timezoneOffset, out XsdGYear result)
    {
        result = new(year, timezoneOffset);
        return true;
    }

    /// <summary>Always succeeds — every <see cref="int"/> is a valid xs:gYear value.</summary>
    public static bool TryCreate(int year, out XsdGYear result) => TryCreate(year, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:gYear lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdGYear result)
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

    /// <summary>Implicitly wraps a native year number as a <see cref="XsdGYear"/> (no timezone).</summary>
    public static implicit operator XsdGYear(int year) => new(year);
    /// <summary>Implicitly unwraps to the native year number, discarding any timezone.</summary>
    public static implicit operator int(XsdGYear v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdGYear"/>.</summary>
    public static implicit operator XsdGYear(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdGYear v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString()
    {
        var digits = Math.Abs(Value).ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');
        var sign = Value < 0 ? "-" : "";
        return $"{sign}{digits}{XsdTimezone.Format(TimezoneOffset)}";
    }
    /// <inheritdoc/>
    public bool Equals(XsdGYear other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdGYear other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(XsdGYear a, XsdGYear b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdGYear a, XsdGYear b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdGYear a, int b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGYear a, int b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(int a, XsdGYear b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(int a, XsdGYear b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdGYear a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdGYear a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdGYear b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdGYear b) => a != b.ToString();
}
