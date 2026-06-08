// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 70 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ' + .
/// </summary>
/// <remarks>
/// The ISO 20022 pattern additionally permits newline (\n) and carriage-return (\r)
/// characters, making this suitable for multi-line address and narrative fields.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_XZTG19p-Ed-ak6NoX_4Aeg_621110266")]
[Description(@"Specifies a character string with a maximum length of 70 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ' + .")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINXMax70Text>))]
public readonly struct RestrictedFINXMax70Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINXMax70Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 70;

    /// <summary>ISO 20022 allowed character set: 0-9 a-z A-Z / - ? : ( ) . , ' + SPACE \n \r</summary>
    public const string AllowedCharacters = @"0-9 a-z A-Z / - ? : ( ) . , ' + SPACE 
 ";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance restricted to SWIFT character set X (with newlines).</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (character outside set X or newlines).
    /// </exception>
    public RestrictedFINXMax70Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINXMax70Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINXMax70Text), value, MaxLength);
        foreach (var c in value)
            if (!IsCharSetXWithNewlines(c))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(RestrictedFINXMax70Text), value, AllowedCharacters);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINXMax70Text result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value) if (!IsCharSetXWithNewlines(c)) { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    private static bool IsCharSetX(char c) =>
        (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
        c == '/' || c == '-' || c == '?' || c == ':' || c == '(' || c == ')' ||
        c == '.' || c == ',' || c == '\'' || c == '+' || c == ' ';

    private static bool IsCharSetXWithNewlines(char c) =>
        IsCharSetX(c) || c == '\n' || c == '\r';

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINXMax70Text"/>.</summary>
    public static implicit operator RestrictedFINXMax70Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINXMax70Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINXMax70Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINXMax70Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINXMax70Text a, RestrictedFINXMax70Text b) => a.Equals(b);
    public static bool operator !=(RestrictedFINXMax70Text a, RestrictedFINXMax70Text b) => !a.Equals(b);
    public static bool operator ==(RestrictedFINXMax70Text a, string? b) => a.Value == b;
    public static bool operator !=(RestrictedFINXMax70Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINXMax70Text b) => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINXMax70Text b) => a != b.Value;
}
