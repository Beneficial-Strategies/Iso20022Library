// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Data Universal Numbering System. A unique identification number provided by Dun and Bradstreet to identify an organization.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YX4O8tp-Ed-ak6NoX_4Aeg_-1333426749")]
[Description(@"Data Universal Numbering System. A unique identification number provided by Dun and Bradstreet to identify an organization.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<DunsIdentifier>))]
public readonly struct DunsIdentifier : IIsoSimpleValue<string>, IEquatable<DunsIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[0-9]{9,9}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public DunsIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(DunsIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out DunsIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="DunsIdentifier"/>.</summary>
    public static implicit operator DunsIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(DunsIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(DunsIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DunsIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(DunsIdentifier a, DunsIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(DunsIdentifier a, DunsIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(DunsIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(DunsIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, DunsIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, DunsIdentifier b) => a != b.Value;
}
