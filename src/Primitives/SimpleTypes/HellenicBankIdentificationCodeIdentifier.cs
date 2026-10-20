// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Hellenic Bank Identification Code Identifier. Identifies Greek financial institutions on the Greek national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYer59p-Ed-ak6NoX_4Aeg_527753128")]
[Description(@"Hellenic Bank Identification Code Identifier. Identifies Greek financial institutions on the Greek national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<HellenicBankIdentificationCodeIdentifier>))]
public readonly struct HellenicBankIdentificationCodeIdentifier : IIsoSimpleValue<string>, IEquatable<HellenicBankIdentificationCodeIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^GR[0-9]{7,7}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public HellenicBankIdentificationCodeIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(HellenicBankIdentificationCodeIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out HellenicBankIdentificationCodeIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="HellenicBankIdentificationCodeIdentifier"/>.</summary>
    public static implicit operator HellenicBankIdentificationCodeIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(HellenicBankIdentificationCodeIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(HellenicBankIdentificationCodeIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is HellenicBankIdentificationCodeIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(HellenicBankIdentificationCodeIdentifier a, HellenicBankIdentificationCodeIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(HellenicBankIdentificationCodeIdentifier a, HellenicBankIdentificationCodeIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(HellenicBankIdentificationCodeIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(HellenicBankIdentificationCodeIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, HellenicBankIdentificationCodeIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, HellenicBankIdentificationCodeIdentifier b) => a != b.Value;
}
