// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISODate — a calendar date, optionally qualified with a timezone.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "A particular point in the progression of time in a calendar year expressed in the
/// YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28
/// October 2004" which is aligned with ISO 8601." That is W3C <c>xs:date</c>, whose lexical form may end in a timezone
/// (<c>Z</c>, <c>+hh:mm</c>, <c>-hh:mm</c>). This is the same problem as <see cref="ISOTime"/> and <see cref="ISODateTime"/>
/// (see <see cref="ISODateTime"/> for the full rationale): <see cref="Value"/> alone cannot capture which wire form was
/// read, so this type implements <see cref="IIsoTimezoneQualifiedValue"/> and the serializer defers to <see cref="ToString"/>
/// and the <c>(string)</c> constructor. Before this type existed, ISODate was a bare <see cref="DateOnly"/>, which refused a
/// date with a timezone and accepted text that is not ISO 8601 at all (<c>10/18/2026</c>, <c>2026-1-8</c>).
///
/// Only the lexical form <c>YYYY-MM-DD</c> with an optional timezone is read: no padding blanks, no time part, no other
/// date format. The year must be 0001 to 9999 (the range of <see cref="DateOnly"/>).
/// Two values are equal when both the date and the timezone are equal: <c>2026-10-18Z</c> is not <c>2026-10-18</c>, so a
/// value always writes back the text it was read from. Compare <see cref="Value"/> to compare the date alone.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXSZFtp-Ed-ak6NoX_4Aeg_2032498111")]
[Description(
    @"A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in ""XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004"" which is aligned with ISO 8601."
)]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISODate, DateOnly>))]
public readonly struct ISODate : IIsoSimpleValue<DateOnly>, IIsoTimezoneQualifiedValue, IEquatable<ISODate>
{
    /// <summary>
    /// Pattern for the non-timezone core of the lexical form: <c>YYYY-MM-DD</c>, nothing before or after it (<c>\z</c>, not
    /// <c>$</c>, which would also allow a trailing line break). Per ISO 8601 / W3C xs:date.
    /// </summary>
    public const string CorePattern = @"^\d{4}-\d{2}-\d{2}\z";

    /// <inheritdoc/>
    public DateOnly Value { get; }

    /// <inheritdoc/>
    public TimeSpan? TimezoneOffset { get; }

    /// <summary>Initializes from a native <see cref="DateOnly"/>, with an optional timezone offset.</summary>
    public ISODate(DateOnly value, TimeSpan? timezoneOffset = null)
    {
        Value = value;
        TimezoneOffset = timezoneOffset;
    }

    /// <summary>
    /// Initializes by parsing the ISO 20022 ISODate lexical form: <c>YYYY-MM-DD</c>, optionally followed by a timezone
    /// (<c>Z</c>, <c>+HH:MM</c>, <c>-HH:MM</c>).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ISODate.</exception>
    public ISODate(string value)
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
            throw new Iso20022FormatException(typeof(ISODate), value, "ISO 8601 date with an optional timezone", ex);
        }
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(ISODate), value, "ISO 8601 \"YYYY-MM-DD\" with an optional timezone");
        if (!DateOnly.TryParseExact(core, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
            throw new Iso20022FormatException(typeof(ISODate), value, "an existing date from 0001-01-01 to 9999-12-31, as \"YYYY-MM-DD\" with an optional timezone");
        Value = date;
        TimezoneOffset = tz;
    }

    /// <summary>Always succeeds — every <see cref="DateOnly"/> is a valid ISODate value.</summary>
    public static bool TryCreate(DateOnly value, TimeSpan? timezoneOffset, out ISODate result)
    {
        result = new(value, timezoneOffset);
        return true;
    }

    /// <summary>Always succeeds — every <see cref="DateOnly"/> is a valid ISODate value.</summary>
    public static bool TryCreate(DateOnly value, out ISODate result) => TryCreate(value, null, out result);

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISODate lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISODate result)
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

    /// <summary>Implicitly wraps a native <see cref="DateOnly"/> as an <see cref="ISODate"/> (no timezone).</summary>
    public static implicit operator ISODate(DateOnly value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="DateOnly"/>, discarding any timezone.</summary>
    public static implicit operator DateOnly(ISODate v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISODate"/>.</summary>
    public static implicit operator ISODate(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISODate v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        $"{Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}{XsdTimezone.Format(TimezoneOffset)}";
    /// <inheritdoc/>
    public bool Equals(ISODate other) => Value == other.Value && TimezoneOffset == other.TimezoneOffset;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISODate other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Value, TimezoneOffset);

    /// <inheritdoc/>
    public static bool operator ==(ISODate a, ISODate b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISODate a, ISODate b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISODate a, DateOnly b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISODate a, DateOnly b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(DateOnly a, ISODate b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(DateOnly a, ISODate b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISODate a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISODate a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISODate b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISODate b) => a != b.ToString();
}
