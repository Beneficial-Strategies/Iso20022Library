// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an upper case alphabetic non numeric string with an exact length of two characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KfOYUevdEeicVrqVCtzH5g")]
[Description(@"Specifies an upper case alphabetic non numeric string with an exact length of two characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact2UpperCaseAlphaText>))]
public readonly struct Exact2UpperCaseAlphaText : IIsoSimpleValue<string>, IEquatable<Exact2UpperCaseAlphaText>
{
    /// <summary>ISO 20022 exact length — two uppercase letters A-Z.</summary>
    public const int MinLength = 2;
    /// <summary>ISO 20022 exact length — two uppercase letters A-Z.</summary>
    public const int MaxLength = 2;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given two-character uppercase alpha string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non uppercase alpha).
    /// </exception>
    public Exact2UpperCaseAlphaText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact2UpperCaseAlphaText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact2UpperCaseAlphaText), value, MaxLength);
        foreach (var c in value)
            if (c < 'A' || c > 'Z')
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact2UpperCaseAlphaText), value, "A-Z");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact2UpperCaseAlphaText result)
    {
        if (value is { Length: 2 })
        {
            foreach (var c in value) if (c < 'A' || c > 'Z') { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact2UpperCaseAlphaText"/>.</summary>
    public static implicit operator Exact2UpperCaseAlphaText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact2UpperCaseAlphaText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact2UpperCaseAlphaText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact2UpperCaseAlphaText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact2UpperCaseAlphaText a, Exact2UpperCaseAlphaText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact2UpperCaseAlphaText a, Exact2UpperCaseAlphaText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact2UpperCaseAlphaText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact2UpperCaseAlphaText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact2UpperCaseAlphaText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact2UpperCaseAlphaText b) => a != b.Value;
}
