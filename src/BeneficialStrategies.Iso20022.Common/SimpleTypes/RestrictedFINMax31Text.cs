// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 31 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOpRkdp-Ed-ak6NoX_4Aeg_1774570072")]
[Description(@"Specifies a character string with a maximum length of 31 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINMax31Text>))]
public readonly struct RestrictedFINMax31Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINMax31Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 31;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..31].
    /// </exception>
    public RestrictedFINMax31Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINMax31Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINMax31Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies the length constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINMax31Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINMax31Text"/>.</summary>
    public static implicit operator RestrictedFINMax31Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINMax31Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINMax31Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINMax31Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINMax31Text a, RestrictedFINMax31Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINMax31Text a, RestrictedFINMax31Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(RestrictedFINMax31Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(RestrictedFINMax31Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, RestrictedFINMax31Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, RestrictedFINMax31Text b) => a != b.Value;
}
