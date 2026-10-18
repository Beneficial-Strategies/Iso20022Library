// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an alphanumeric string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YXlUBdp-Ed-ak6NoX_4Aeg_-2067559309")]
[Description(@"Specifies an alphanumeric string with a maximum length of 4 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max4AlphaNumericText>))]
public readonly struct Max4AlphaNumericText : IIsoSimpleValue<string>, IEquatable<Max4AlphaNumericText>
{
    /// <summary>ISO 20022 minimum length constraint (a-z A-Z 0-9).</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint (a-z A-Z 0-9).</summary>
    public const int MaxLength = 4;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given alphanumeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-alphanumeric character).
    /// </exception>
    public Max4AlphaNumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max4AlphaNumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max4AlphaNumericText), value, MaxLength);
        foreach (var c in value)
            if (c is (< '0' or > '9') and (< 'a' or > 'z') and (< 'A' or > 'Z'))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Max4AlphaNumericText), value, "a-z A-Z 0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max4AlphaNumericText result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value)
                if (c is (< '0' or > '9') and (< 'a' or > 'z') and (< 'A' or > 'Z'))
                { result = default; return false; }
            result = new(value);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Max4AlphaNumericText"/>.</summary>
    public static implicit operator Max4AlphaNumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max4AlphaNumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max4AlphaNumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max4AlphaNumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Max4AlphaNumericText a, Max4AlphaNumericText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max4AlphaNumericText a, Max4AlphaNumericText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max4AlphaNumericText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max4AlphaNumericText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max4AlphaNumericText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max4AlphaNumericText b) => a != b.Value;
}
