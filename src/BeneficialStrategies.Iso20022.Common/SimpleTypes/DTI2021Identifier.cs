// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// The Digital Token Identifier (DTI) is an 8 character code assigned to fungible digital assets as described in ISO 24165.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_COrK4V2YEeyCc_hbMo6fDA")]
[Description(@"The Digital Token Identifier (DTI) is an 8 character code assigned to fungible digital assets as described in ISO 24165.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<DTI2021Identifier>))]
public readonly struct DTI2021Identifier : IIsoSimpleValue<string>, IEquatable<DTI2021Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[1-9B-DF-HJ-NP-XZ][0-9B-DF-HJ-NP-XZ]{8,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public DTI2021Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(DTI2021Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out DTI2021Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="DTI2021Identifier"/>.</summary>
    public static implicit operator DTI2021Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(DTI2021Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(DTI2021Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DTI2021Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(DTI2021Identifier a, DTI2021Identifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(DTI2021Identifier a, DTI2021Identifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(DTI2021Identifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(DTI2021Identifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, DTI2021Identifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, DTI2021Identifier b) => a != b.Value;
}
