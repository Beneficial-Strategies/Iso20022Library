// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISONormalisedDateTime — an <see cref="ISODateTime"/> restricted to always be UTC.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "an ISODateTime whereby all timezoned dateTime values are
/// UTC." The dictionary's own pattern constraint is <c>.*Z</c> — the wire text must always end in
/// the UTC designator <c>"Z"</c>. The other two lexical forms permitted by plain
/// <see cref="ISODateTime"/> (an explicit non-UTC offset, or no timezone at all) are not valid
/// here — this type rejects both. Aligned with "XML Schema Part 2: Datatypes" (W3C xs:dateTime),
/// itself aligned with ISO 8601, restricted to the <c>"Z"</c> (UTC) designator.
///
/// Unlike <see cref="ISODateTime"/> there is no timezone variability to preserve alongside
/// <see cref="Value"/> — it is always UTC — but this type still implements
/// <see cref="IIsoCompositeSimpleValue"/> so the serializer always emits the mandatory trailing
/// <c>"Z"</c> via <see cref="ToString"/>, rather than falling through to the generic (non-"Z"
/// suffixed) <see cref="DateTime"/> formatter.
///
/// Deliberate scope limitation: as with <see cref="ISODateTime"/>, this type is backed by
/// <see cref="System.DateTime"/> and therefore only supports 4-digit, current-era years
/// (0001-9999), not the unbounded/negative years the raw W3C xs:dateTime grammar technically
/// permits.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YWPQN9p-Ed-ak6NoX_4Aeg_-842130097")]
[Description(@"an ISODateTime whereby all timezoned dateTime values are UTC. Pattern: .*Z")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISONormalisedDateTime, DateTime>))]
public readonly struct ISONormalisedDateTime : IIsoSimpleValue<DateTime>, IIsoCompositeSimpleValue, IEquatable<ISONormalisedDateTime>
{
    /// <summary>
    /// Pattern for the non-"Z" core of the lexical form: <c>YYYY-MM-DDThh:mm:ss</c>, with an
    /// optional fractional-seconds suffix. Per ISO 8601 / W3C xs:dateTime.
    /// </summary>
    public const string CorePattern = @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}(\.\d+)?$";

    /// <inheritdoc/>
    public DateTime Value { get; }

    /// <summary>Initializes from a native <see cref="DateTime"/> (always treated as UTC).</summary>
    public ISONormalisedDateTime(DateTime value)
    {
        Value = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }

    /// <summary>
    /// Initializes by parsing the ISO 20022 ISONormalisedDateTime lexical form: an ISO 8601 /
    /// W3C xs:dateTime date and time, mandatorily suffixed with the UTC designator <c>"Z"</c>
    /// (pattern <c>.*Z</c> per the ISO 20022 data dictionary).
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown when the string is not a valid ISONormalisedDateTime — including when it is a
    /// validly-formed <see cref="ISODateTime"/> that is missing the mandatory trailing "Z".
    /// </exception>
    public ISONormalisedDateTime(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!value.EndsWith('Z'))
            throw new Iso20022FormatException(typeof(ISONormalisedDateTime), value, "ISO 8601 date and time mandatorily suffixed with \"Z\" (pattern .*Z)");
        var core = value[..^1];
        if (!Regex.IsMatch(core, CorePattern))
            throw new Iso20022FormatException(typeof(ISONormalisedDateTime), value, "ISO 8601 \"YYYY-MM-DDThh:mm:ss[.sss]Z\"");
        Value = DateTime.SpecifyKind(
            DateTime.Parse(core, CultureInfo.InvariantCulture, DateTimeStyles.None),
            DateTimeKind.Utc
        );
    }

    /// <summary>Always succeeds — every <see cref="DateTime"/> is a valid ISONormalisedDateTime value.</summary>
    public static bool TryCreate(DateTime value, out ISONormalisedDateTime result)
    {
        result = new(value);
        return true;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISONormalisedDateTime lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISONormalisedDateTime result)
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

    /// <summary>Implicitly wraps a native <see cref="DateTime"/> as an <see cref="ISONormalisedDateTime"/> (treated as UTC).</summary>
    public static implicit operator ISONormalisedDateTime(DateTime value) => new(value);
    /// <summary>Implicitly unwraps to the native UTC <see cref="DateTime"/>.</summary>
    public static implicit operator DateTime(ISONormalisedDateTime v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISONormalisedDateTime"/>.</summary>
    public static implicit operator ISONormalisedDateTime(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISONormalisedDateTime v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => $"{Value.ToString("yyyy-MM-ddTHH:mm:ss.FFFFFFF", CultureInfo.InvariantCulture)}Z";
    /// <inheritdoc/>
    public bool Equals(ISONormalisedDateTime other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISONormalisedDateTime other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(ISONormalisedDateTime a, ISONormalisedDateTime b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISONormalisedDateTime a, ISONormalisedDateTime b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISONormalisedDateTime a, DateTime b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISONormalisedDateTime a, DateTime b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(DateTime a, ISONormalisedDateTime b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(DateTime a, ISONormalisedDateTime b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISONormalisedDateTime a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISONormalisedDateTime a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISONormalisedDateTime b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISONormalisedDateTime b) => a != b.ToString();
}
