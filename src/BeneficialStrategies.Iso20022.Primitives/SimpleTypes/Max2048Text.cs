// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with a maximum length of 2048 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYxm1dp-Ed-ak6NoX_4Aeg_-227354214")]
[Description(@"Specifies a character string with a maximum length of 2048 characters.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max2048Text>))]
public readonly struct Max2048Text : IIsoSimpleValue<string>, IEquatable<Max2048Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 2048;

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given text.</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> when the value is shorter than
    /// <see cref="MinLength"/> characters, or <see cref="Iso20022FormatViolation.TooLong"/> when
    /// it exceeds <see cref="MaxLength"/> characters.
    /// </exception>
    public Max2048Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max2048Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max2048Text), value, MaxLength);
        Value = value;
    }

    /// <summary>
    /// Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies
    /// the length constraints; otherwise <see langword="false"/>.
    /// </summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max2048Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        {
            result = new(value);
            return true;
        }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="Max2048Text"/>.</summary>
    public static implicit operator Max2048Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(Max2048Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max2048Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max2048Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(Max2048Text a, Max2048Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max2048Text a, Max2048Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max2048Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max2048Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max2048Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max2048Text b) => a != b.Value;
}
