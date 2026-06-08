// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// ISO 20022 Message identifier of an MX message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YWr8JNp-Ed-ak6NoX_4Aeg_2141066595")]
[Description(@"ISO 20022 Message identifier of an MX message.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ISO20022MessageIdentificationText>))]
public readonly struct ISO20022MessageIdentificationText : IIsoSimpleValue<string>, IEquatable<ISO20022MessageIdentificationText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ISO20022MessageIdentificationText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO20022MessageIdentificationText), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ISO20022MessageIdentificationText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO20022MessageIdentificationText"/>.</summary>
    public static implicit operator ISO20022MessageIdentificationText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ISO20022MessageIdentificationText id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO20022MessageIdentificationText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO20022MessageIdentificationText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ISO20022MessageIdentificationText a, ISO20022MessageIdentificationText b)  => a.Equals(b);
    public static bool operator !=(ISO20022MessageIdentificationText a, ISO20022MessageIdentificationText b)  => !a.Equals(b);
    public static bool operator ==(ISO20022MessageIdentificationText a, string? b)  => a.Value == b;
    public static bool operator !=(ISO20022MessageIdentificationText a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, ISO20022MessageIdentificationText b)  => a == b.Value;
    public static bool operator !=(string? a, ISO20022MessageIdentificationText b)  => a != b.Value;
}
