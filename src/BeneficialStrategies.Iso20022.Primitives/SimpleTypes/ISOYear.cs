// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 ISOYear — a calendar year.
/// </summary>
/// <remarks>
/// Per the ISO 20022 data dictionary: "Year represented by YYYY (ISO 8601)." No minInclusive/
/// maxInclusive facet is given (unlike the narrower <see cref="ISORestrictedYear"/>, bounded to
/// 1900-2099) — any year fitting <see cref="int"/> is accepted here. The deviation this type
/// exists to fix is the wire format, not the range: "YYYY" per ISO 8601 is always 4 digits,
/// zero-padded for years below 1000 (e.g. year 99 is <c>"0099"</c>, not <c>"99"</c>) — the plain
/// <see cref="int"/>/<see cref="ushort"/> this was previously aliased to would format without
/// that padding. Implements <see cref="IIsoCompositeSimpleValue"/> purely to force the serializer
/// to defer to this type's own zero-padded <see cref="ToString"/> rather than the generic
/// unpadded <see cref="int"/> formatter, even though <see cref="Value"/> itself isn't composite.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YX4O89p-Ed-ak6NoX_4Aeg_272574874")]
[Description(@"Year represented by YYYY (ISO 8601).")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<ISOYear, int>))]
public readonly struct ISOYear : IIsoSimpleValue<int>, IIsoCompositeSimpleValue, IEquatable<ISOYear>
{
    /// <summary>Pattern for the lexical form: exactly 4 digits.</summary>
    public const string Pattern = @"^\d{4}$";

    /// <inheritdoc/>
    public int Value { get; }

    /// <summary>Initializes from the native year value.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> is outside 0-9999 (what a 4-digit wire form can represent).</exception>
    public ISOYear(int value)
    {
        if (value is < 0 or > 9999)
            throw new Iso20022FormatException(typeof(ISOYear), value.ToString(CultureInfo.InvariantCulture), "0 to 9999 (a 4-digit YYYY wire form)");
        Value = value;
    }

    /// <summary>Initializes by parsing the ISO 20022 ISOYear lexical form: exactly 4 digits.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid 4-digit year.</exception>
    public ISOYear(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISOYear), value, Pattern);
        Value = int.Parse(value, CultureInfo.InvariantCulture);
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is within 0-9999.</summary>
    public static bool TryCreate(int value, [NotNullWhen(true)] out ISOYear result)
    {
        try
        { result = new(value); return true; }
        catch (Iso20022FormatException) { result = default; return false; }
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid ISOYear lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISOYear result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(int.Parse(value, CultureInfo.InvariantCulture)); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a native <see cref="int"/> as an <see cref="ISOYear"/>.</summary>
    public static implicit operator ISOYear(int value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="int"/> value.</summary>
    public static implicit operator int(ISOYear v) => v.Value;
    /// <summary>Implicitly wraps a wire string as an <see cref="ISOYear"/>.</summary>
    public static implicit operator ISOYear(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(ISOYear v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value.ToString("D4", CultureInfo.InvariantCulture);
    /// <inheritdoc/>
    public bool Equals(ISOYear other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOYear other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(ISOYear a, ISOYear b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(ISOYear a, ISOYear b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISOYear a, int b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOYear a, int b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(int a, ISOYear b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(int a, ISOYear b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(ISOYear a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOYear a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOYear b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOYear b) => a != b.ToString();
}
