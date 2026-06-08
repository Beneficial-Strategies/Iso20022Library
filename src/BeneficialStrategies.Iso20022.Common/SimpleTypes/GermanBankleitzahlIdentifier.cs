// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// German Bankleitzahl. Identifies German financial institutions on the German national clearing systems.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3Fdp-Ed-ak6NoX_4Aeg_-870708070")]
[Description(@"German Bankleitzahl. Identifies German financial institutions on the German national clearing systems.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<GermanBankleitzahlIdentifier>))]
public readonly struct GermanBankleitzahlIdentifier : IIsoSimpleValue<string>, IEquatable<GermanBankleitzahlIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^BL[0-9]{8,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public GermanBankleitzahlIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(GermanBankleitzahlIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out GermanBankleitzahlIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="GermanBankleitzahlIdentifier"/>.</summary>
    public static implicit operator GermanBankleitzahlIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(GermanBankleitzahlIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(GermanBankleitzahlIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is GermanBankleitzahlIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(GermanBankleitzahlIdentifier a, GermanBankleitzahlIdentifier b)  => a.Equals(b);
    public static bool operator !=(GermanBankleitzahlIdentifier a, GermanBankleitzahlIdentifier b)  => !a.Equals(b);
    public static bool operator ==(GermanBankleitzahlIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(GermanBankleitzahlIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, GermanBankleitzahlIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, GermanBankleitzahlIdentifier b)  => a != b.Value;
}
