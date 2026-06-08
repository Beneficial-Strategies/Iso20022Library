// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// South African National Clearing Code. Identifies South African financial institutions on the South African national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3Ftp-Ed-ak6NoX_4Aeg_-870708067")]
[Description(@"South African National Clearing Code. Identifies South African financial institutions on the South African national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SouthAfricanNCCIdentifier>))]
public readonly struct SouthAfricanNCCIdentifier : IIsoSimpleValue<string>, IEquatable<SouthAfricanNCCIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^ZA[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public SouthAfricanNCCIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SouthAfricanNCCIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SouthAfricanNCCIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SouthAfricanNCCIdentifier"/>.</summary>
    public static implicit operator SouthAfricanNCCIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SouthAfricanNCCIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SouthAfricanNCCIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SouthAfricanNCCIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(SouthAfricanNCCIdentifier a, SouthAfricanNCCIdentifier b) => a.Equals(b);
    public static bool operator !=(SouthAfricanNCCIdentifier a, SouthAfricanNCCIdentifier b) => !a.Equals(b);
    public static bool operator ==(SouthAfricanNCCIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(SouthAfricanNCCIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, SouthAfricanNCCIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, SouthAfricanNCCIdentifier b) => a != b.Value;
}
