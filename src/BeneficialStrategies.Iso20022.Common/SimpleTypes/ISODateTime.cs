// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISODateTime — a particular point in time, defined by a mandatory date and a
/// mandatory time component, optionally qualified with a timezone.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "A particular point in the progression of time defined by
/// a mandatory date and a mandatory time component, expressed in either UTC time format
/// (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format
/// (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss)." Aligned
/// with "XML Schema Part 2: Datatypes" (W3C xs:dateTime), itself aligned with ISO 8601.
///
/// Three wire forms are permitted, and are preserved separately here (not collapsed):
/// <list type="bullet">
///   <item><description>UTC — text ends in <c>"Z"</c> — <see cref="TimezoneOffset"/> is <see cref="TimeSpan.Zero"/>.</description></item>
///   <item><description>Local with an explicit offset — text ends in <c>"+hh:mm"</c> or
///     <c>"-hh:mm"</c> — <see cref="TimezoneOffset"/> carries that offset.</description></item>
///   <item><description>Local, unqualified — no timezone suffix at all — <see cref="TimezoneOffset"/> is <see langword="null"/>.</description></item>
/// </list>
/// <see cref="Value"/> alone (a <see cref="DateTime"/>, always <see cref="DateTimeKind.Unspecified"/>
/// here since the timezone rides separately in <see cref="TimezoneOffset"/>) cannot capture which
/// of the three forms was on the wire, so — exactly like the <c>xs:gYear</c>/<c>xs:gMonth</c>/
/// <c>xs:gYearMonth</c> family (see <see cref="XsdGYear"/> for the sibling this pattern was
/// copied from) — this type implements <see cref="IIsoTimezoneQualifiedValue"/> so the
/// serializer defers to <see cref="ToString"/> / the <c>(string)</c> constructor instead of
/// trying to round-trip <see cref="Value"/> alone.
///
/// Deliberate scope limitation: unlike <c>xs:gYear</c>, ISO 20022 dateTime values in practice are
/// always 4-digit-year, current-era timestamps, and <see cref="System.DateTime"/> cannot
/// represent years outside 0001-9999 or negative (BCE) years at all. This type does not attempt
/// to support the wider year range the raw W3C xs:dateTime grammar technically permits.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YW1tKtp-Ed-ak6NoX_4Aeg_-1624336183")]
[Description(
    @"A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in ""XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004"" which is aligned with ISO 8601."
)]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISODateTime, DateTime>))]
public readonly struct ISODateTime : IIsoSimpleValue<DateTime>, IIsoTimezoneQualifiedValue, IEquatable<ISODateTime>
{
    /// <summary>
    /// Pattern for the non-timezone core of the lexical form: <c>YYYY-MM-DDThh:mm:ss</c>, with an
    /// optional fractional-seconds suffix. Per ISO 8601 / W3C xs:dateTime.
    /// </summary>
    public const string CorePattern = @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}(\.\d+)?$";

    /// <inheritdoc/>
    public DateTime Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from a native <see cref="DateTime"/>, with an optional timezone offset.</summary>
    public ISODateTime(DateTime value, TimeSpan? timezoneOffset = null)
    {
        Value = value;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the ISO 20022 ISODateTime lexical form: an ISO 8601 / W3C
    /// xs:dateTime date and time, optionally followed by a timezone (<c>Z</c>, <c>+HH:MM</c>,
    /// <c>-HH:MM</c>).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ISODateTime.</exception>
    public ISODateTime(string value)
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
            throw new Iso20022FormatException(typeof(ISODateTime), value, "ISO 8601 date and time with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(ISODateTime), value, "ISO 8601 \"YYYY-MM-DDThh:mm:ss[.sss]\" with an optional timezone");
        Value = DateTime.Parse(core, CultureInfo.InvariantCulture, DateTimeStyles.None);
        TimezoneOffset = tz;
    }

    /// <summary>Always succeeds — every <see cref="DateTime"/> is a valid ISODateTime value.</summary>
    public static bool TryCreate(DateTime value, TimeSpan? timezoneOffset, out ISODateTime result)
    {
        result = new(value, timezoneOffset);
        return true;
    }

    /// <summary>Always succeeds — every <see cref="DateTime"/> is a valid ISODateTime value.</summary>
    public static bool TryCreate(DateTime value, out ISODateTime result) => TryCreate(value, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISODateTime lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISODateTime result)
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

    /// <summary>Implicitly wraps a native <see cref="DateTime"/> as an <see cref="ISODateTime"/> (no timezone).</summary>
    public static implicit operator ISODateTime(DateTime value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="DateTime"/>, discarding any timezone.</summary>
    public static implicit operator DateTime(ISODateTime v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISODateTime"/>.</summary>
    public static implicit operator ISODateTime(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISODateTime v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        $"{Value.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFF", CultureInfo.InvariantCulture)}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(ISODateTime other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISODateTime other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(ISODateTime a, ISODateTime b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISODateTime a, ISODateTime b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISODateTime a, DateTime b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISODateTime a, DateTime b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(DateTime a, ISODateTime b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(DateTime a, ISODateTime b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISODateTime a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISODateTime a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISODateTime b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISODateTime b) => a != b.ToString();
}
