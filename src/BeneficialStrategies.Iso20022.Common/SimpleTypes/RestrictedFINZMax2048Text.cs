// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 2048 characters
/// limited to SWIFT character set Z.
/// </summary>
/// <remarks>
/// Character set Z: <c>0-9 a-z A-Z ! " % &amp; * ; &lt; &gt; SPACE . , ( ) \n \r / = ' + : ? @ # { - _</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_GtejUA-IEeqIo4c3ferchw")]
[Description(@"Specifies a character string with a maximum length of 2048 characters limited to character set Z: a-z A-Z / - ? : ( ) . , ' += ! ""% & * < > ; @ # .")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINZMax2048Text>))]
public readonly struct RestrictedFINZMax2048Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINZMax2048Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 2048;

    /// <summary>ISO 20022 allowed character set Z (superset of X, adds ! % &amp; * ; &lt; &gt; = @ # { - _).</summary>
    public const string AllowedCharacters = @"0-9 a-z A-Z ! % & * ; < > SPACE . , ( ) \n \r / = ' + : ? @ # { - _";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance restricted to SWIFT character set Z.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (character outside set Z).
    /// </exception>
    public RestrictedFINZMax2048Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINZMax2048Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINZMax2048Text), value, MaxLength);
        foreach (var c in value)
            if (!IsCharSetZ(c))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(RestrictedFINZMax2048Text), value, AllowedCharacters);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINZMax2048Text result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value) if (!IsCharSetZ(c)) { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    private static bool IsCharSetZ(char c) =>
        (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') ||
        c == '!' || c == '"' || c == '%' || c == '&' || c == '*' || c == ';' ||
        c == '<' || c == '>' || c == ' ' || c == '.' || c == ',' || c == '(' ||
        c == ')' || c == '\n' || c == '\r' || c == '/' || c == '=' || c == '\'' ||
        c == '+' || c == ':' || c == '?' || c == '@' || c == '#' || c == '{' ||
        c == '-' || c == '_';

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINZMax2048Text"/>.</summary>
    public static implicit operator RestrictedFINZMax2048Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINZMax2048Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINZMax2048Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINZMax2048Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINZMax2048Text a, RestrictedFINZMax2048Text b) => a.Equals(b);
    public static bool operator !=(RestrictedFINZMax2048Text a, RestrictedFINZMax2048Text b) => !a.Equals(b);
    public static bool operator ==(RestrictedFINZMax2048Text a, string? b) => a.Value == b;
    public static bool operator !=(RestrictedFINZMax2048Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINZMax2048Text b) => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINZMax2048Text b) => a != b.Value;
}
