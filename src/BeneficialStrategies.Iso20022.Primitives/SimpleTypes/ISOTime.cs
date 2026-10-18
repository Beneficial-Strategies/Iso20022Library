// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISOTime — a particular point in time within a calendar day, optionally qualified
/// with a timezone.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "A particular point in the progression of time in a
/// calendar day expressed in either UTC time format (hh:mm:ss.sssZ), local time with UTC offset
/// format (hh:mm:ss.sss+/-hh:mm), or local time format (hh:mm:ss.sss)." Aligned with "XML Schema
/// Part 2: Datatypes" (W3C xs:time), itself aligned with ISO 8601. This is exactly the same
/// 3-wire-form problem as <see cref="ISODateTime"/> (see that type for the full rationale) minus
/// the date component — before this type existed, <c>IsoISOTime</c> was aliased directly to
/// <see cref="System.TimeOnly"/>, which cannot represent the timezone at all.
///
/// Three wire forms are permitted, and are preserved separately here (not collapsed):
/// <list type="bullet">
///   <item><description>UTC — text ends in <c>"Z"</c> — <see cref="TimezoneOffset"/> is <see cref="TimeSpan.Zero"/>.</description></item>
///   <item><description>Local with an explicit offset — text ends in <c>"+hh:mm"</c> or
///     <c>"-hh:mm"</c> — <see cref="TimezoneOffset"/> carries that offset.</description></item>
///   <item><description>Local, unqualified — no timezone suffix at all — <see cref="TimezoneOffset"/> is <see langword="null"/>.</description></item>
/// </list>
/// <see cref="Value"/> alone cannot capture which of the three forms was on the wire, so — exactly
/// like <see cref="ISODateTime"/> and the <c>xs:gYear</c> family — this type implements
/// <see cref="IIsoTimezoneQualifiedValue"/> so the serializer defers to <see cref="ToString"/> /
/// the <c>(string)</c> constructor instead of trying to round-trip <see cref="Value"/> alone.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYU64dp-Ed-ak6NoX_4Aeg_-1253016814")]
[Description(
    @"A particular point in the progression of time in a calendar day expressed in either UTC time format (hh:mm:ss.sssZ), local time with UTC offset format (hh:mm:ss.sss+/-hh:mm), or local time format (hh:mm:ss.sss). These representations are defined in ""XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004"" which is aligned with ISO 8601."
)]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISOTime, TimeOnly>))]
public readonly struct ISOTime : IIsoSimpleValue<TimeOnly>, IIsoTimezoneQualifiedValue, IEquatable<ISOTime>
{
    /// <summary>
    /// Pattern for the non-timezone core of the lexical form: <c>hh:mm:ss</c>, with an optional
    /// fractional-seconds suffix. Per ISO 8601 / W3C xs:time.
    /// </summary>
    public const string CorePattern = @"^\d{2}:\d{2}:\d{2}(\.\d+)?$";

    /// <inheritdoc/>
    public TimeOnly Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from a native <see cref="TimeOnly"/>, with an optional timezone offset.</summary>
    public ISOTime(TimeOnly value, TimeSpan? timezoneOffset = null)
    {
        Value = value;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the ISO 20022 ISOTime lexical form: an ISO 8601 / W3C xs:time time,
    /// optionally followed by a timezone (<c>Z</c>, <c>+HH:MM</c>, <c>-HH:MM</c>).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ISOTime.</exception>
    public ISOTime(string value)
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
            throw new Iso20022FormatException(typeof(ISOTime), value, "ISO 8601 time with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(ISOTime), value, "ISO 8601 \"hh:mm:ss[.sss]\" with an optional timezone");
        Value = TimeOnly.Parse(core, CultureInfo.InvariantCulture, DateTimeStyles.None);
        TimezoneOffset = tz;
    }

    /// <summary>Always succeeds — every <see cref="TimeOnly"/> is a valid ISOTime value.</summary>
    public static bool TryCreate(TimeOnly value, TimeSpan? timezoneOffset, out ISOTime result)
    {
        result = new(value, timezoneOffset);
        return true;
    }

    /// <summary>Always succeeds — every <see cref="TimeOnly"/> is a valid ISOTime value.</summary>
    public static bool TryCreate(TimeOnly value, out ISOTime result) => TryCreate(value, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISOTime lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISOTime result)
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

    /// <summary>Implicitly wraps a native <see cref="TimeOnly"/> as an <see cref="ISOTime"/> (no timezone).</summary>
    public static implicit operator ISOTime(TimeOnly value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="TimeOnly"/>, discarding any timezone.</summary>
    public static implicit operator TimeOnly(ISOTime v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISOTime"/>.</summary>
    public static implicit operator ISOTime(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISOTime v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        $"{Value.ToString("HH:mm:ss.FFFFFFF", CultureInfo.InvariantCulture)}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(ISOTime other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOTime other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(ISOTime a, ISOTime b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISOTime a, ISOTime b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISOTime a, TimeOnly b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOTime a, TimeOnly b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(TimeOnly a, ISOTime b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(TimeOnly a, ISOTime b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISOTime a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOTime a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOTime b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOTime b) => a != b.ToString();
}
