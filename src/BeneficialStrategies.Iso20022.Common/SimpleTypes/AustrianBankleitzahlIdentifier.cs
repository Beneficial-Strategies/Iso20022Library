// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Austrian Bankleitzahl. Identifies Austrian financial institutions on the Austrian national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3GNp-Ed-ak6NoX_4Aeg_-870708049")]
[Description(@"Austrian Bankleitzahl. Identifies Austrian financial institutions on the Austrian national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<AustrianBankleitzahlIdentifier>))]
public readonly struct AustrianBankleitzahlIdentifier : IIsoSimpleValue<string>, IEquatable<AustrianBankleitzahlIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^AT[0-9]{5,5}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public AustrianBankleitzahlIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(AustrianBankleitzahlIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out AustrianBankleitzahlIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="AustrianBankleitzahlIdentifier"/>.</summary>
    public static implicit operator AustrianBankleitzahlIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(AustrianBankleitzahlIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(AustrianBankleitzahlIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is AustrianBankleitzahlIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(AustrianBankleitzahlIdentifier a, AustrianBankleitzahlIdentifier b) => a.Equals(b);
    public static bool operator !=(AustrianBankleitzahlIdentifier a, AustrianBankleitzahlIdentifier b) => !a.Equals(b);
    public static bool operator ==(AustrianBankleitzahlIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(AustrianBankleitzahlIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, AustrianBankleitzahlIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, AustrianBankleitzahlIdentifier b) => a != b.Value;
}
