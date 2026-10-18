// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Native decomposed value carried by <see cref="XsdDuration"/> — the individual designator
/// components of a W3C XSD <c>xs:duration</c> value. Component magnitudes are always
/// non-negative; the overall sign is carried separately by <see cref="IsNegative"/>.
/// </summary>
/// <param name="IsNegative">Whether the duration is negative (a leading <c>"-"</c> in the lexical form).</param>
/// <param name="Years">The years component (0 if absent).</param>
/// <param name="Months">The months component (0 if absent).</param>
/// <param name="Days">The days component (0 if absent).</param>
/// <param name="Hours">The hours component (0 if absent).</param>
/// <param name="Minutes">The minutes component (0 if absent).</param>
/// <param name="Seconds">The seconds component (0 if absent); may carry a fractional part.</param>
public readonly record struct XsdDurationValue(bool IsNegative, int Years, int Months, int Days, int Hours, int Minutes, decimal Seconds);

/// <summary>
/// W3C XML Schema xs:duration — a duration of time expressed in years, months, days, hours,
/// minutes, and seconds.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:duration</c>. <see cref="System.TimeSpan"/> cannot
/// represent this faithfully — years and months are calendar-relative, not fixed durations — so
/// this wraps the decomposed <see cref="XsdDurationValue"/> instead.
/// Wire format: <c>"-?PnYnMnDTnHnMnS"</c> (e.g. <c>"P1Y2M3DT4H5M6.5S"</c>), with at least one
/// designator present, and — if <c>"T"</c> appears — at least one of the H/M/S designators
/// following it. Unlike the <c>xs:g*</c> types, <c>xs:duration</c> has no timezone component.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("duration_ID")]
[Description(@"W3C XML Schema xs:duration — a duration of time expressed in years, months, days, hours, minutes, and seconds.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdDuration, XsdDurationValue>))]
public readonly struct XsdDuration : IIsoSimpleValue<XsdDurationValue>, IIsoCompositeSimpleValue, IEquatable<XsdDuration>
{
    private static readonly Regex Pattern = new(
        @"^(-)?P(?:(\d+)Y)?(?:(\d+)M)?(?:(\d+)D)?(?:T(?:(\d+)H)?(?:(\d+)M)?(?:(\d+(?:\.\d+)?)S)?)?$",
        RegexOptions.Compiled);

    /// <inheritdoc/>
    public XsdDurationValue Value { get; }

    /// <summary>Initializes from the native decomposed duration components.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when any component magnitude is negative.</exception>
    public XsdDuration(XsdDurationValue value)
    {
        if (value.Years < 0 || value.Months < 0 || value.Days < 0 || value.Hours < 0 || value.Minutes < 0 || value.Seconds < 0)
            throw new Iso20022FormatException(
                typeof(XsdDuration), value.ToString(),
                "xs:duration — component magnitudes must be non-negative; use IsNegative for the overall sign");
        Value = value;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD xs:duration lexical form: <c>"-?PnYnMnDTnHnMnS"</c>,
    /// with at least one designator present.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:duration.</exception>
    public XsdDuration(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var match = Pattern.Match(value);
        var hasAnyDesignator = match.Success
            && (match.Groups[2].Success || match.Groups[3].Success || match.Groups[4].Success
                || match.Groups[5].Success || match.Groups[6].Success || match.Groups[7].Success);
        var hasTimeComponent = match.Success && (match.Groups[5].Success || match.Groups[6].Success || match.Groups[7].Success);
        if (!hasAnyDesignator || (value.Contains('T') && !hasTimeComponent))
            throw new Iso20022FormatException(
                typeof(XsdDuration), value, "xs:duration — \"-?PnYnMnDTnHnMnS\", at least one designator required");

        Value = new XsdDurationValue(
            IsNegative: match.Groups[1].Success,
            Years: ParseIntGroup(match.Groups[2]),
            Months: ParseIntGroup(match.Groups[3]),
            Days: ParseIntGroup(match.Groups[4]),
            Hours: ParseIntGroup(match.Groups[5]),
            Minutes: ParseIntGroup(match.Groups[6]),
            Seconds: match.Groups[7].Success ? decimal.Parse(match.Groups[7].Value, CultureInfo.InvariantCulture) : 0m);
    }

    private static int ParseIntGroup(Group group) => group.Success ? int.Parse(group.Value, CultureInfo.InvariantCulture) : 0;

    /// <summary>Returns <see langword="true"/> when every component magnitude in <paramref name="value"/> is non-negative.</summary>
    public static bool TryCreate(XsdDurationValue value, [NotNullWhen(true)] out XsdDuration result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:duration lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdDuration result)
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

    /// <summary>Implicitly wraps a <see cref="XsdDurationValue"/> as a <see cref="XsdDuration"/>.</summary>
    public static implicit operator XsdDuration(XsdDurationValue value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="XsdDurationValue"/>.</summary>
    public static implicit operator XsdDurationValue(XsdDuration v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdDuration"/>.</summary>
    public static implicit operator XsdDuration(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdDuration v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString()
    {
        var v = Value;
        if (v is { Years: 0, Months: 0, Days: 0, Hours: 0, Minutes: 0, Seconds: 0 })
            return "P0D"; // canonical zero-duration form

        var sb = new StringBuilder();
        if (v.IsNegative) sb.Append('-');
        sb.Append('P');
        if (v.Years != 0) sb.Append(v.Years).Append('Y');
        if (v.Months != 0) sb.Append(v.Months).Append('M');
        if (v.Days != 0) sb.Append(v.Days).Append('D');
        if (v.Hours != 0 || v.Minutes != 0 || v.Seconds != 0)
        {
            sb.Append('T');
            if (v.Hours != 0) sb.Append(v.Hours).Append('H');
            if (v.Minutes != 0) sb.Append(v.Minutes).Append('M');
            if (v.Seconds != 0) sb.Append(v.Seconds.ToString(CultureInfo.InvariantCulture)).Append('S');
        }
        return sb.ToString();
    }
    /// <inheritdoc/>
    public bool Equals(XsdDuration other) => Value.Equals(other.Value);
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdDuration other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdDuration a, XsdDuration b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdDuration a, XsdDuration b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdDuration a, XsdDurationValue b) => a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(XsdDuration a, XsdDurationValue b) => !a.Value.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(XsdDurationValue a, XsdDuration b) => a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator !=(XsdDurationValue a, XsdDuration b) => !a.Equals(b.Value);
    /// <inheritdoc/>
    public static bool operator ==(XsdDuration a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdDuration a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdDuration b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdDuration b) => a != b.ToString();
}
