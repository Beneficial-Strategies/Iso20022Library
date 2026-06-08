// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with an exact length of 1 character.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bHPiwFBdEfC5WMyGsBx7PA")]
[Description(@"Specifies a character string with an exact length of 1 character.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact1Text>))]
public readonly struct Exact1Text : IIsoSimpleValue<string>, IEquatable<Exact1Text>
{
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MaxLength = 1;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is not exactly 1.
    /// </exception>
    public Exact1Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact1Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact1Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is exactly 1 character.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact1Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact1Text"/>.</summary>
    public static implicit operator Exact1Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact1Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact1Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact1Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Exact1Text a, Exact1Text b) => a.Equals(b);
    public static bool operator !=(Exact1Text a, Exact1Text b) => !a.Equals(b);
    public static bool operator ==(Exact1Text a, string? b) => a.Value == b;
    public static bool operator !=(Exact1Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Exact1Text b) => a == b.Value;
    public static bool operator !=(string? a, Exact1Text b) => a != b.Value;
}
