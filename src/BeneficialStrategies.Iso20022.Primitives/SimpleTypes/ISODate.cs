// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISODate — a calendar date, written and read as <c>YYYY-MM-DD</c> and nothing else.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "A particular point in the progression of time in a calendar year expressed in the
/// YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28
/// October 2004" which is aligned with ISO 8601." The format is <c>YYYY-MM-DD</c>; this type carries no timezone (unlike
/// <see cref="ISOTime"/> and <see cref="ISODateTime"/>, whose formats include one), so a text with a timezone suffix such as
/// <c>2026-10-18Z</c> is refused rather than read and dropped. Before this type existed, ISODate was a bare
/// <see cref="DateOnly"/>, which refused a timezone for the wrong reason and accepted text that is not ISO 8601 at all
/// (<c>10/18/2026</c>, <c>2026-1-8</c>, padded blanks).
///
/// It is an <see cref="IIsoCompositeSimpleValue"/> only so that the XML serializer hands the whole text to the <c>(string)</c>
/// constructor: parsing it into a <see cref="DateOnly"/> first would read <c>10/18/2026</c> and padded text as dates.
///
/// The year must be 0001 to 9999 (the range of <see cref="DateOnly"/>). Equality is that of the date, which is exactly what the
/// text preserves: two values are equal if and only if they are written as the same text.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXSZFtp-Ed-ak6NoX_4Aeg_2032498111")]
[Description(
    @"A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in ""XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004"" which is aligned with ISO 8601."
)]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISODate, DateOnly>))]
public readonly struct ISODate : IIsoSimpleValue<DateOnly>, IIsoCompositeSimpleValue, IEquatable<ISODate>
{
    /// <summary>
    /// Pattern of the lexical form: <c>YYYY-MM-DD</c>, nothing before or after it (<c>\z</c>, not <c>$</c>, which would also
    /// allow a trailing line break).
    /// </summary>
    public const string Pattern = @"^\d{4}-\d{2}-\d{2}\z";

    /// <inheritdoc/>
    public DateOnly Value { get; }

    /// <summary>Initializes from a native <see cref="DateOnly"/>; every <see cref="DateOnly"/> is a valid ISODate.</summary>
    public ISODate(DateOnly value)
    {
        Value = value;
    }

    /// <summary>Initializes by parsing the ISO 20022 ISODate lexical form, <c>YYYY-MM-DD</c>.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid ISODate.</exception>
    public ISODate(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISODate), value, "ISO 8601 \"YYYY-MM-DD\"");
        if (!DateOnly.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
            throw new Iso20022FormatException(typeof(ISODate), value, "an existing date from 0001-01-01 to 9999-12-31, as \"YYYY-MM-DD\"");
        Value = date;
    }

    /// <summary>Always succeeds — every <see cref="DateOnly"/> is a valid ISODate value.</summary>
    public static bool TryCreate(DateOnly value, out ISODate result)
    {
        result = new(value);
        return true;
    }

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

    /// <summary>Implicitly wraps a native <see cref="DateOnly"/> as an <see cref="ISODate"/>.</summary>
    public static implicit operator ISODate(DateOnly value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="DateOnly"/>.</summary>
    public static implicit operator DateOnly(ISODate v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISODate"/>.</summary>
    public static implicit operator ISODate(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISODate v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() =>
        Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(ISODate other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISODate other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

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
