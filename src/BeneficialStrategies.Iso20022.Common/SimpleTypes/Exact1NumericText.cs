// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a numeric string with an exact length of 1 digit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQbTwAEcEeCQm6a_G2yO_w_1224443793")]
[Description(@"Specifies a numeric string with an exact length of 1 digit.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact1NumericText>))]
public readonly struct Exact1NumericText : IIsoSimpleValue<string>, IEquatable<Exact1NumericText>
{
    /// <summary>ISO 20022 minimum length constraint (digits 0-9).</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint (digits 0-9).</summary>
    public const int MaxLength = 1;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given numeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-digit character).
    /// </exception>
    public Exact1NumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact1NumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact1NumericText), value, MaxLength);
        foreach (var c in value)
            if (c < '0' || c > '9')
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact1NumericText), value, "0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact1NumericText result)
    {
        if (value is not null && value.Length >= MinLength && value.Length <= MaxLength)
        {
            foreach (var c in value)
                if (c < '0' || c > '9')
                { result = default; return false; }
            result = new(value);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact1NumericText"/>.</summary>
    public static implicit operator Exact1NumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact1NumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact1NumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact1NumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact1NumericText a, Exact1NumericText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact1NumericText a, Exact1NumericText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact1NumericText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact1NumericText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact1NumericText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact1NumericText b) => a != b.Value;
}
