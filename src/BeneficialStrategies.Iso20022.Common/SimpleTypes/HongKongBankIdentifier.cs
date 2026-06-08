// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Hong Kong Bank Code. Identifies Hong Kong financial institutions on the Hong Kong local clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXSZENp-Ed-ak6NoX_4Aeg_-870707946")]
[Description(@"Hong Kong Bank Code. Identifies Hong Kong financial institutions on the Hong Kong local clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<HongKongBankIdentifier>))]
public readonly struct HongKongBankIdentifier : IIsoSimpleValue<string>, IEquatable<HongKongBankIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^HK[0-9]{3,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public HongKongBankIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(HongKongBankIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out HongKongBankIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="HongKongBankIdentifier"/>.</summary>
    public static implicit operator HongKongBankIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(HongKongBankIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(HongKongBankIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is HongKongBankIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(HongKongBankIdentifier a, HongKongBankIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(HongKongBankIdentifier a, HongKongBankIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(HongKongBankIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(HongKongBankIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, HongKongBankIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, HongKongBankIdentifier b) => a != b.Value;
}
