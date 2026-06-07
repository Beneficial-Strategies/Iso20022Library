// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a numeric string with a maximum length of 8 digits.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2Azj0EqXEeenp6hmNprBHg")]
[Description(@"Specifies a numeric string with a maximum length of 8 digits.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max8NumericText>))]
public readonly struct Max8NumericText : IIsoSimpleValue<string>, IEquatable<Max8NumericText>
{
    /// <summary>ISO 20022 minimum length constraint (digits 0-9).</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint (digits 0-9).</summary>
    public const int MaxLength = 8;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given numeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-digit character).
    /// </exception>
    public Max8NumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max8NumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max8NumericText), value, MaxLength);
        foreach (var c in value)
            if (c < '0' || c > '9')
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Max8NumericText), value, "0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max8NumericText result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value) if (c < '0' || c > '9') { result = default; return false; }
            result = new(value);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Max8NumericText"/>.</summary>
    public static implicit operator Max8NumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max8NumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max8NumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max8NumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Max8NumericText a, Max8NumericText b)  => a.Equals(b);
    public static bool operator !=(Max8NumericText a, Max8NumericText b)  => !a.Equals(b);
    public static bool operator ==(Max8NumericText a, string? b)  => a.Value == b;
    public static bool operator !=(Max8NumericText a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, Max8NumericText b)  => a == b.Value;
    public static bool operator !=(string? a, Max8NumericText b)  => a != b.Value;
}
