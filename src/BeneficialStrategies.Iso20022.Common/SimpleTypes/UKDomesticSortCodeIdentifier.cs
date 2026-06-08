// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// United Kingdom Sort Code. Identifies British financial institutions on the British national clearing systems.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXIoEtp-Ed-ak6NoX_4Aeg_-870708017")]
[Description(@"United Kingdom Sort Code. Identifies British financial institutions on the British national clearing systems.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<UKDomesticSortCodeIdentifier>))]
public readonly struct UKDomesticSortCodeIdentifier : IIsoSimpleValue<string>, IEquatable<UKDomesticSortCodeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^SC[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public UKDomesticSortCodeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(UKDomesticSortCodeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out UKDomesticSortCodeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="UKDomesticSortCodeIdentifier"/>.</summary>
    public static implicit operator UKDomesticSortCodeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(UKDomesticSortCodeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(UKDomesticSortCodeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is UKDomesticSortCodeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(UKDomesticSortCodeIdentifier a, UKDomesticSortCodeIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(UKDomesticSortCodeIdentifier a, UKDomesticSortCodeIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(UKDomesticSortCodeIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(UKDomesticSortCodeIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, UKDomesticSortCodeIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, UKDomesticSortCodeIdentifier b) => a != b.Value;
}
