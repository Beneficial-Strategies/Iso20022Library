// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 50 characters.
/// Any Unicode character is permitted; slash is restricted: no leading slash,
/// no trailing slash, and no double slash (//).
/// </summary>
[DataContract]
[Serializable]
[IsoId("__W3msVdJEeyoCqAHUMv0iA")]
[Description(@"Specifies a character string with a maximum length of 50 characters. It has a pattern that disables the use of slash ""/"" at the beginning and end of line and double slash ""//"" within the line.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINMax50Text>))]
public readonly struct RestrictedFINMax50Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINMax50Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 50;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance; any character permitted but no leading/trailing/double slash.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.PatternMismatch"/> (slash rule violation).
    /// </exception>
    public RestrictedFINMax50Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINMax50Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINMax50Text), value, MaxLength);
        ValidateSlash(typeof(RestrictedFINMax50Text), value);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINMax50Text result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength
            && value[0] != '/' && value[^1] != '/' && !value.Contains("//"))
        { result = new(value); return true; }
        result = default; return false;
    }

    private static void ValidateSlash(Type type, string value)
    {
        if (value[0] == '/')
            throw new Iso20022FormatException(type, value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value[^1] == '/')
            throw new Iso20022FormatException(type, value,
                "no leading slash, no trailing slash, no double slash (//)");
        if (value.Contains("//"))
            throw new Iso20022FormatException(type, value,
                "no leading slash, no trailing slash, no double slash (//)");
    }

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINMax50Text"/>.</summary>
    public static implicit operator RestrictedFINMax50Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINMax50Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINMax50Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINMax50Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINMax50Text a, RestrictedFINMax50Text b)  => a.Equals(b);
    public static bool operator !=(RestrictedFINMax50Text a, RestrictedFINMax50Text b)  => !a.Equals(b);
    public static bool operator ==(RestrictedFINMax50Text a, string? b)  => a.Value == b;
    public static bool operator !=(RestrictedFINMax50Text a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINMax50Text b)  => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINMax50Text b)  => a != b.Value;
}
