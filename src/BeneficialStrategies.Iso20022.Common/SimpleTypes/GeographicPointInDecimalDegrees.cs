// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Identifies a geographic point or location by geographic coordinates expressed in latitude/longitude decimal degrees only.</summary>
[DataContract]
[Serializable]
[IsoId("_tpibgMWMEeuhguwJmlgagQ")]
[Description(@"Identifies a geographic point or location by geographic coordinates expressed in latitude/longitude decimal degrees only.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<GeographicPointInDecimalDegrees>))]
public readonly struct GeographicPointInDecimalDegrees : IIsoSimpleValue<string>, IEquatable<GeographicPointInDecimalDegrees>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^(\+|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+|-)?[\d]{1,3}(\.[\d]{1,8})?$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public GeographicPointInDecimalDegrees(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(GeographicPointInDecimalDegrees), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out GeographicPointInDecimalDegrees result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator GeographicPointInDecimalDegrees(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(GeographicPointInDecimalDegrees t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(GeographicPointInDecimalDegrees other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is GeographicPointInDecimalDegrees other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(GeographicPointInDecimalDegrees a, GeographicPointInDecimalDegrees b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(GeographicPointInDecimalDegrees a, GeographicPointInDecimalDegrees b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(GeographicPointInDecimalDegrees a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(GeographicPointInDecimalDegrees a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, GeographicPointInDecimalDegrees b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, GeographicPointInDecimalDegrees b) => a != b.Value;
}
