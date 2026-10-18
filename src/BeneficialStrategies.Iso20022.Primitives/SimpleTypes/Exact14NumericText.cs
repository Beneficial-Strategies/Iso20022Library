// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a numeric string with an exact length of 14 digits (YYYYMMDDHHMMSS).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nToUYWaIEfCX7uJiAWHfoQ")]
[Description(@"Specifies a numeric string with an exact length of 14 digits (YYYYMMDDHHMMSS).")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact14NumericText>))]
public readonly struct Exact14NumericText : IIsoSimpleValue<string>, IEquatable<Exact14NumericText>
{
    /// <summary>ISO 20022 minimum length constraint (digits 0-9).</summary>
    public const int MinLength = 14;
    /// <summary>ISO 20022 maximum length constraint (digits 0-9).</summary>
    public const int MaxLength = 14;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given numeric string.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/>,
    /// <see cref="Iso20022FormatViolation.TooLong"/>, or
    /// <see cref="Iso20022FormatViolation.InvalidCharacter"/> (non-digit character).
    /// </exception>
    public Exact14NumericText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact14NumericText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact14NumericText), value, MaxLength);
        foreach (var c in value)
            if (c < '0' || c > '9')
                throw Iso20022FormatException.ForInvalidCharacter(typeof(Exact14NumericText), value, "0-9");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact14NumericText result)
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

    /// <summary>Implicitly wraps a string as a <see cref="Exact14NumericText"/>.</summary>
    public static implicit operator Exact14NumericText(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact14NumericText text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact14NumericText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact14NumericText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact14NumericText a, Exact14NumericText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact14NumericText a, Exact14NumericText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact14NumericText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact14NumericText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact14NumericText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact14NumericText b) => a != b.Value;
}
