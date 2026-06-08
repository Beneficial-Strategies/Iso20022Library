// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 23 characters.
/// Any Unicode character is permitted; slash is restricted: no leading slash,
/// no trailing slash, and no double slash (//).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WN5DqNp-Ed-ak6NoX_4Aeg_-191272700")]
[Description(@"Specifies a character string with a maximum length of 23 characters. It has a pattern that disables the use of slash ""/"" at the beginning and end of line and double slash ""//"" within the line.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINMax23Text>))]
public readonly struct RestrictedFINMax23Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINMax23Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 23;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance; any character permitted but no leading/trailing/double slash.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.PatternMismatch"/> (slash rule violation).
    /// </exception>
    public RestrictedFINMax23Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINMax23Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINMax23Text), value, MaxLength);
        ValidateSlash(typeof(RestrictedFINMax23Text), value);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINMax23Text result)
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

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINMax23Text"/>.</summary>
    public static implicit operator RestrictedFINMax23Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINMax23Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINMax23Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINMax23Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINMax23Text a, RestrictedFINMax23Text b)  => a.Equals(b);
    public static bool operator !=(RestrictedFINMax23Text a, RestrictedFINMax23Text b)  => !a.Equals(b);
    public static bool operator ==(RestrictedFINMax23Text a, string? b)  => a.Value == b;
    public static bool operator !=(RestrictedFINMax23Text a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINMax23Text b)  => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINMax23Text b)  => a != b.Value;
}
