// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with an exact length of 42 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Az7e4CjAEeKnA5P_jl2DUw")]
[Description(@"Specifies a character string with an exact length of 42 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact42Text>))]
public readonly struct Exact42Text : IIsoSimpleValue<string>, IEquatable<Exact42Text>
{
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MinLength = 42;
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MaxLength = 42;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is not exactly 42.
    /// </exception>
    public Exact42Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact42Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact42Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is exactly 42 characters.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact42Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact42Text"/>.</summary>
    public static implicit operator Exact42Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact42Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact42Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact42Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Exact42Text a, Exact42Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Exact42Text a, Exact42Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Exact42Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Exact42Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Exact42Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Exact42Text b) => a != b.Value;
}
