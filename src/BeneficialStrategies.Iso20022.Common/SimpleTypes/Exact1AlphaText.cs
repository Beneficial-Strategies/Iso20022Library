// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an alpha string with a length of 1 character.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2AdqUWaKEfCX7uJiAWHfoQ")]
[Description(@"Specifies an alpha string with a length of 1 character.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact1AlphaText>))]
public readonly struct Exact1AlphaText : IIsoSimpleValue<string>, IEquatable<Exact1AlphaText>
{
    /// <summary>ISO 20022 exact length — one alphabetic character a-z A-Z.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 exact length — one alphabetic character a-z A-Z.</summary>
    public const int MaxLength = 1;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given single alphabetic character.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-alpha character).
    /// </exception>
    public Exact1AlphaText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact1AlphaText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact1AlphaText), value, MaxLength);
        var c = value[0];
        if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
            throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact1AlphaText), value, "a-z A-Z");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact1AlphaText result)
    {
        if (value is { Length: 1 })
        {
            var c = value[0];
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            { result = new(value); return true; }
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact1AlphaText"/>.</summary>
    public static implicit operator Exact1AlphaText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact1AlphaText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact1AlphaText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact1AlphaText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact1AlphaText a, Exact1AlphaText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact1AlphaText a, Exact1AlphaText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact1AlphaText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact1AlphaText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact1AlphaText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact1AlphaText b) => a != b.Value;
}
