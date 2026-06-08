// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 34 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ' + .
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XZJV1tp-Ed-ak6NoX_4Aeg_-1792709131")]
[Description(@"Specifies a character string with a maximum length of 34 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ' + .")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINX2Max34Text>))]
public readonly struct RestrictedFINX2Max34Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINX2Max34Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 34;

    /// <summary>ISO 20022 allowed character set: 0-9 a-z A-Z / - ? : ( ) . , ' + SPACE</summary>
    public const string AllowedCharacters = "0-9 a-z A-Z / - ? : ( ) . , ' + SPACE";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance restricted to SWIFT character set X.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (character outside set X).
    /// </exception>
    public RestrictedFINX2Max34Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINX2Max34Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINX2Max34Text), value, MaxLength);
        foreach (var c in value)
            if (!IsCharSetX(c))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(RestrictedFINX2Max34Text), value, AllowedCharacters);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINX2Max34Text result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value) if (!IsCharSetX(c)) { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    private static bool IsCharSetX(char c) =>
        (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
        c == '/' || c == '-' || c == '?' || c == ':' || c == '(' || c == ')' ||
        c == '.' || c == ',' || c == '\'' || c == '+' || c == ' ';

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINX2Max34Text"/>.</summary>
    public static implicit operator RestrictedFINX2Max34Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINX2Max34Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINX2Max34Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINX2Max34Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINX2Max34Text a, RestrictedFINX2Max34Text b) => a.Equals(b);
    public static bool operator !=(RestrictedFINX2Max34Text a, RestrictedFINX2Max34Text b) => !a.Equals(b);
    public static bool operator ==(RestrictedFINX2Max34Text a, string? b) => a.Value == b;
    public static bool operator !=(RestrictedFINX2Max34Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINX2Max34Text b) => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINX2Max34Text b) => a != b.Value;
}
