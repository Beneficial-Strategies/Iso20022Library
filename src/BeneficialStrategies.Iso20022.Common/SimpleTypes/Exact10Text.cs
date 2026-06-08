// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with an exact length of 10 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQRizwEcEeCQm6a_G2yO_w_597239000")]
[Description(@"Specifies a character string with an exact length of 10 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Exact10Text>))]
public readonly struct Exact10Text : IIsoSimpleValue<string>, IEquatable<Exact10Text>
{
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MinLength = 10;
    /// <summary>ISO 20022 exact length constraint — any Unicode character.</summary>
    public const int MaxLength = 10;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is not exactly 10.
    /// </exception>
    public Exact10Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Exact10Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Exact10Text), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is exactly 10 characters.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Exact10Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Exact10Text"/>.</summary>
    public static implicit operator Exact10Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Exact10Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Exact10Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Exact10Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(Exact10Text a, Exact10Text b) => a.Equals(b);
    public static bool operator !=(Exact10Text a, Exact10Text b) => !a.Equals(b);
    public static bool operator ==(Exact10Text a, string? b) => a.Value == b;
    public static bool operator !=(Exact10Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Exact10Text b) => a == b.Value;
    public static bool operator !=(string? a, Exact10Text b) => a != b.Value;
}
