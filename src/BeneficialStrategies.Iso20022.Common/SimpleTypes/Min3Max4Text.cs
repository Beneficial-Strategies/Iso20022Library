// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a minimum length of 3 characters, and a maximum length of 4 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_TQlEwwEcEeCQm6a_G2yO_w_-1714153360")]
[Description(@"Specifies a character string with a minimum length of 3 characters, and a maximum length of 4 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Min3Max4Text>))]
public readonly struct Min3Max4Text : IIsoSimpleValue<string>, IEquatable<Min3Max4Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 3;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 4;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Min3Max4Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Min3Max4Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Min3Max4Text), value, MaxLength);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out Min3Max4Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator Min3Max4Text(string value) => new(value);
    public static implicit operator string(Min3Max4Text t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(Min3Max4Text other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is Min3Max4Text other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(Min3Max4Text a, Min3Max4Text b) => a.Equals(b);
    public static bool operator !=(Min3Max4Text a, Min3Max4Text b) => !a.Equals(b);
    public static bool operator ==(Min3Max4Text a, string? b) => a.Value == b;
    public static bool operator !=(Min3Max4Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Min3Max4Text b) => a == b.Value;
    public static bool operator !=(string? a, Min3Max4Text b) => a != b.Value;
}
