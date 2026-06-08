// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 24 characters limited to
/// character set X (a-z A-Z / - ? : ( ) . , ' + SPACE), with no leading slash, no
/// trailing slash, and no double slash (//) within the value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XZTG0Np-Ed-ak6NoX_4Aeg_1416778243")]
[Description(@"Specifies a character string with a maximum length of 24 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ' + , and disable the use of slash ""/"" at the beginning and end of line and double slash ""//"" within the line.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINXMax24Text>))]
public readonly struct RestrictedFINXMax24Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINXMax24Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 24;

    /// <summary>ISO 20022 allowed character set X; no leading, trailing, or double slash.</summary>
    public const string AllowedCharacters = "0-9 a-z A-Z / - ? : ( ) . , ' + SPACE (no leading/trailing/double slash)";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance restricted to SWIFT character set X with slash constraints.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>,
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (character outside set X), or
    /// <see cref="Iso20022FormatViolation.PatternMismatch"/> (leading, trailing, or double slash).
    /// </exception>
    public RestrictedFINXMax24Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINXMax24Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINXMax24Text), value, MaxLength);
        foreach (var c in value)
            if (!IsCharSetX(c))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(RestrictedFINXMax24Text), value, AllowedCharacters);
        if (value[0] == '/')
            throw new Iso20022FormatException(typeof(RestrictedFINXMax24Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value[^1] == '/')
            throw new Iso20022FormatException(typeof(RestrictedFINXMax24Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value.Contains("//"))
            throw new Iso20022FormatException(typeof(RestrictedFINXMax24Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINXMax24Text result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value) if (!IsCharSetX(c)) { result = default; return false; }
            if (value[0] == '/' || value[^1] == '/' || value.Contains("//"))
                { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    private static bool IsCharSetX(char c) =>
        (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
        c == '/' || c == '-' || c == '?' || c == ':' || c == '(' || c == ')' ||
        c == '.' || c == ',' || c == '\'' || c == '+' || c == ' ';

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINXMax24Text"/>.</summary>
    public static implicit operator RestrictedFINXMax24Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINXMax24Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINXMax24Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINXMax24Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINXMax24Text a, RestrictedFINXMax24Text b)  => a.Equals(b);
    public static bool operator !=(RestrictedFINXMax24Text a, RestrictedFINXMax24Text b)  => !a.Equals(b);
    public static bool operator ==(RestrictedFINXMax24Text a, string? b)  => a.Value == b;
    public static bool operator !=(RestrictedFINXMax24Text a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINXMax24Text b)  => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINXMax24Text b)  => a != b.Value;
}
