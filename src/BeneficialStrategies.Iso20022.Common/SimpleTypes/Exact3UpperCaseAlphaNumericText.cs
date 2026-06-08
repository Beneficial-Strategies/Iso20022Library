// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies an upper case alphanumeric string with a length of three characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YWr8I9p-Ed-ak6NoX_4Aeg_-581282758")]
[Description(@"Specifies an upper case alphanumeric string with a length of three characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact3UpperCaseAlphaNumericText>))]
public readonly struct Exact3UpperCaseAlphaNumericText : IIsoSimpleValue<string>, IEquatable<Exact3UpperCaseAlphaNumericText>
{
    /// <summary>ISO 20022 exact length — three uppercase alphanumeric characters A-Z 0-9.</summary>
    public const int MinLength = 3;
    /// <summary>ISO 20022 exact length — three uppercase alphanumeric characters A-Z 0-9.</summary>
    public const int MaxLength = 3;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given three-character uppercase alphanumeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non uppercase alphanumeric).
    /// </exception>
    public Exact3UpperCaseAlphaNumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact3UpperCaseAlphaNumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact3UpperCaseAlphaNumericText), value, MaxLength);
        foreach (var c in value)
            if (!((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact3UpperCaseAlphaNumericText), value, "A-Z 0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact3UpperCaseAlphaNumericText result)
    {
        if (value is { Length: 3 })
        {
            foreach (var c in value)
                if (!((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                { result = default; return false; }
            result = new(value); return true;
        }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact3UpperCaseAlphaNumericText"/>.</summary>
    public static implicit operator Exact3UpperCaseAlphaNumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact3UpperCaseAlphaNumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact3UpperCaseAlphaNumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact3UpperCaseAlphaNumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Exact3UpperCaseAlphaNumericText a, Exact3UpperCaseAlphaNumericText b) => a.Equals(b);
    public static bool operator !=(Exact3UpperCaseAlphaNumericText a, Exact3UpperCaseAlphaNumericText b) => !a.Equals(b);
    public static bool operator ==(Exact3UpperCaseAlphaNumericText a, string? b) => a.Value == b;
    public static bool operator !=(Exact3UpperCaseAlphaNumericText a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Exact3UpperCaseAlphaNumericText b) => a == b.Value;
    public static bool operator !=(string? a, Exact3UpperCaseAlphaNumericText b) => a != b.Value;
}
