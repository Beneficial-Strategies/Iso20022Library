// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an alphanumeric string with a length of 6 characters.
/// </summary>
/// <remarks>
/// Despite the name, the ISO spec pattern <c>[a-zA-Z0-9\s]{6}</c> also permits whitespace
/// characters (spaces, tabs, etc.) in addition to letters and digits.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_D9usQVKcEeeFcfYfFkVztg")]
[Description(@"Specifies an alphanumeric string with a length of 6 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact6AlphaNumericText>))]
public readonly struct Exact6AlphaNumericText : IIsoSimpleValue<string>, IEquatable<Exact6AlphaNumericText>
{
    /// <summary>ISO 20022 exact length constraint.</summary>
    public const int MinLength = 6;
    /// <summary>ISO 20022 exact length constraint.</summary>
    public const int MaxLength = 6;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given 6-character alphanumeric (including whitespace) string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (not alphanumeric or whitespace).
    /// </exception>
    public Exact6AlphaNumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact6AlphaNumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact6AlphaNumericText), value, MaxLength);
        foreach (var c in value)
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || char.IsWhiteSpace(c)))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact6AlphaNumericText), value, "a-z A-Z 0-9 whitespace");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact6AlphaNumericText result)
    {
        if (value is { Length: 6 })
        {
            foreach (var c in value)
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || char.IsWhiteSpace(c)))
                { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact6AlphaNumericText"/>.</summary>
    public static implicit operator Exact6AlphaNumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact6AlphaNumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact6AlphaNumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact6AlphaNumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact6AlphaNumericText a, Exact6AlphaNumericText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact6AlphaNumericText a, Exact6AlphaNumericText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact6AlphaNumericText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact6AlphaNumericText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact6AlphaNumericText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact6AlphaNumericText b) => a != b.Value;
}
