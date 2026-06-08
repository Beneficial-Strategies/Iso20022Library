// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 34 characters limited to
/// character set X (a-z A-Z / - ? : ( ) . , ' + SPACE), with no leading slash, no
/// trailing slash, and no double slash (//) within the value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XZTG1Np-Ed-ak6NoX_4Aeg_-2016982080")]
[Description(@"Specifies a character string with a maximum length of 34 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ' + , and disable the use of slash ""/"" at the beginning and end of line and double slash ""//"" within the line.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINXMax34Text>))]
public readonly struct RestrictedFINXMax34Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINXMax34Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 34;

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
    public RestrictedFINXMax34Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINXMax34Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINXMax34Text), value, MaxLength);
        foreach (var c in value)
            if (!IsCharSetX(c))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(RestrictedFINXMax34Text), value, AllowedCharacters);
        if (value[0] == '/')
            throw new Iso20022FormatException(typeof(RestrictedFINXMax34Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value[^1] == '/')
            throw new Iso20022FormatException(typeof(RestrictedFINXMax34Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value.Contains("//"))
            throw new Iso20022FormatException(typeof(RestrictedFINXMax34Text), value,
                "no leading slash, no trailing slash, no double slash (//)");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINXMax34Text result)
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

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINXMax34Text"/>.</summary>
    public static implicit operator RestrictedFINXMax34Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINXMax34Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINXMax34Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINXMax34Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINXMax34Text a, RestrictedFINXMax34Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINXMax34Text a, RestrictedFINXMax34Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINXMax34Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINXMax34Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, RestrictedFINXMax34Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, RestrictedFINXMax34Text b) => a != b.Value;
}
