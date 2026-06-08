// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 10 000 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_gaMnEEbOEeeIjf8aP9KbJA")]
[Description(@"Specifies a character string with a maximum length of 10 000 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max10KText>))]
public readonly struct Max10KText : IIsoSimpleValue<string>, IEquatable<Max10KText>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 10000;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Max10KText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Max10KText), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Max10KText), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max10KText result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max10KText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max10KText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max10KText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max10KText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max10KText a, Max10KText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max10KText a, Max10KText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max10KText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max10KText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max10KText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max10KText b) => a != b.Value;
}
