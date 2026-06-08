// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 15 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOpRkNp-Ed-ak6NoX_4Aeg_1507303120")]
[Description(@"Specifies a character string with a maximum length of 15 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINMax15Text>))]
public readonly struct RestrictedFINMax15Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINMax15Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 15;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..15].
    /// </exception>
    public RestrictedFINMax15Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(RestrictedFINMax15Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(RestrictedFINMax15Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies the length constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINMax15Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINMax15Text"/>.</summary>
    public static implicit operator RestrictedFINMax15Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINMax15Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINMax15Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINMax15Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINMax15Text a, RestrictedFINMax15Text b) => a.Equals(b);
    public static bool operator !=(RestrictedFINMax15Text a, RestrictedFINMax15Text b) => !a.Equals(b);
    public static bool operator ==(RestrictedFINMax15Text a, string? b) => a.Value == b;
    public static bool operator !=(RestrictedFINMax15Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINMax15Text b) => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINMax15Text b) => a != b.Value;
}
