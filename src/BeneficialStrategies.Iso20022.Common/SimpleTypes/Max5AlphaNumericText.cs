// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an alphanumeric string with a maximum length of 5 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9RFOBlO6EeGs_NnqHXQZkw")]
[Description(@"Specifies an alphanumeric string with a maximum length of 5 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max5AlphaNumericText>))]
public readonly struct Max5AlphaNumericText : IIsoSimpleValue<string>, IEquatable<Max5AlphaNumericText>
{
    /// <summary>ISO 20022 minimum length constraint (a-z A-Z 0-9).</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint (a-z A-Z 0-9).</summary>
    public const int MaxLength = 5;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given alphanumeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-alphanumeric character).
    /// </exception>
    public Max5AlphaNumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max5AlphaNumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max5AlphaNumericText), value, MaxLength);
        foreach (var c in value)
            if (c is (< '0' or > '9') and (< 'a' or > 'z') and (< 'A' or > 'Z'))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Max5AlphaNumericText), value, "a-z A-Z 0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max5AlphaNumericText result)
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

    /// <summary>Implicitly wraps a string as a <see cref="Max5AlphaNumericText"/>.</summary>
    public static implicit operator Max5AlphaNumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max5AlphaNumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max5AlphaNumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max5AlphaNumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Max5AlphaNumericText a, Max5AlphaNumericText b)  => a.Equals(b);
    public static bool operator !=(Max5AlphaNumericText a, Max5AlphaNumericText b)  => !a.Equals(b);
    public static bool operator ==(Max5AlphaNumericText a, string? b)  => a.Value == b;
    public static bool operator !=(Max5AlphaNumericText a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, Max5AlphaNumericText b)  => a == b.Value;
    public static bool operator !=(string? a, Max5AlphaNumericText b)  => a != b.Value;
}
