// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Identifies a geographic point or location by geographic coordinates expressed in latitude/longitude decimal degrees only.</summary>
[DataContract]
[Serializable]
[IsoId("_vd424J7tEfCkRtw9IJ2_Zw")]
[Description(@"Identifies a geographic point or location by geographic coordinates expressed in latitude/longitude decimal degrees only.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<GeographicPointInDecimalDegreesText>))]
public readonly struct GeographicPointInDecimalDegreesText : IIsoSimpleValue<string>, IEquatable<GeographicPointInDecimalDegreesText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^(\+|-)?[\d]{1,3}(\.[\d]{1,8})?/(\+|-)?[\d]{1,3}(\.[\d]{1,8})?$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public GeographicPointInDecimalDegreesText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(GeographicPointInDecimalDegreesText), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out GeographicPointInDecimalDegreesText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator GeographicPointInDecimalDegreesText(string value) => new(value);
    public static implicit operator string(GeographicPointInDecimalDegreesText t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(GeographicPointInDecimalDegreesText other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is GeographicPointInDecimalDegreesText other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(GeographicPointInDecimalDegreesText a, GeographicPointInDecimalDegreesText b) => a.Equals(b);
    public static bool operator !=(GeographicPointInDecimalDegreesText a, GeographicPointInDecimalDegreesText b) => !a.Equals(b);
    public static bool operator ==(GeographicPointInDecimalDegreesText a, string? b) => a.Value == b;
    public static bool operator !=(GeographicPointInDecimalDegreesText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, GeographicPointInDecimalDegreesText b) => a == b.Value;
    public static bool operator !=(string? a, GeographicPointInDecimalDegreesText b) => a != b.Value;
}
