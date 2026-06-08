// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 10,000,000 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_8x-lgclWEeuJ35KoBRZFOg")]
[Description(@"Specifies a character string with a maximum length of 10,000,000 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max10MbText>))]
public readonly struct Max10MbText : IIsoSimpleValue<string>, IEquatable<Max10MbText>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 10000000;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Max10MbText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max10MbText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max10MbText), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max10MbText result)
    {
        if (value is { Length: >= MinLength and <= MaxLength })
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max10MbText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max10MbText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max10MbText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max10MbText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max10MbText a, Max10MbText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max10MbText a, Max10MbText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max10MbText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max10MbText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max10MbText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max10MbText b) => a != b.Value;
}
