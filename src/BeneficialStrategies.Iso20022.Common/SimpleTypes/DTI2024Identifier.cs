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
[IsoId("_W1-MobBoEe6MwO7YY4latA")]
[Description(@"The Digital Token Identifier (DTI) is an 8 character code assigned to fungible digital assets as described in ISO 24165.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<DTI2024Identifier>))]
public readonly struct DTI2024Identifier : IIsoSimpleValue<string>, IEquatable<DTI2024Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public DTI2024Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(DTI2024Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out DTI2024Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="DTI2024Identifier"/>.</summary>
    public static implicit operator DTI2024Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(DTI2024Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(DTI2024Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DTI2024Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(DTI2024Identifier a, DTI2024Identifier b) => a.Equals(b);
    public static bool operator !=(DTI2024Identifier a, DTI2024Identifier b) => !a.Equals(b);
    public static bool operator ==(DTI2024Identifier a, string? b) => a.Value == b;
    public static bool operator !=(DTI2024Identifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, DTI2024Identifier b) => a == b.Value;
    public static bool operator !=(string? a, DTI2024Identifier b) => a != b.Value;
}
