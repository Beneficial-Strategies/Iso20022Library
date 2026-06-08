// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 210 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOybhNp-Ed-ak6NoX_4Aeg_292402720")]
[Description(@"Specifies a character string with a maximum length of 210 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINMax210Text>))]
public readonly struct RestrictedFINMax210Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINMax210Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 210;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..210].
    /// </exception>
    public RestrictedFINMax210Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINMax210Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINMax210Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies the length constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINMax210Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINMax210Text"/>.</summary>
    public static implicit operator RestrictedFINMax210Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINMax210Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINMax210Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINMax210Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINMax210Text a, RestrictedFINMax210Text b)  => a.Equals(b);
    public static bool operator !=(RestrictedFINMax210Text a, RestrictedFINMax210Text b)  => !a.Equals(b);
    public static bool operator ==(RestrictedFINMax210Text a, string? b)  => a.Value == b;
    public static bool operator !=(RestrictedFINMax210Text a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINMax210Text b)  => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINMax210Text b)  => a != b.Value;
}
