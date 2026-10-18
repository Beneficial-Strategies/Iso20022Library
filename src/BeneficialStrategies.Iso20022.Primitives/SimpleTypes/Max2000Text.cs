// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 2000 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYn11dp-Ed-ak6NoX_4Aeg_2132907481")]
[Description(@"Specifies a character string with a maximum length of 2000 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max2000Text>))]
public readonly struct Max2000Text : IIsoSimpleValue<string>, IEquatable<Max2000Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 2000;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> when the value is shorter than
    /// <see cref="MinLength"/> characters, or <see cref="Iso20022FormatViolation.TooLong"/> when
    /// it exceeds <see cref="MaxLength"/> characters.
    /// </exception>
    public Max2000Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max2000Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max2000Text), value, MaxLength);
        Value = value;
    }

    /// <summary>
    /// Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies
    /// the length constraints; otherwise <see langword="false"/>.
    /// </summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max2000Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        {
            result = new(value);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Max2000Text"/>.</summary>
    public static implicit operator Max2000Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max2000Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max2000Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max2000Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Max2000Text a, Max2000Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max2000Text a, Max2000Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max2000Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max2000Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max2000Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max2000Text b) => a != b.Value;
}
