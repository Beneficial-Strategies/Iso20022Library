// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a minimum length of 5 characters, and a maximum length of 8 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_MWBC8GZ-EfCX7uJiAWHfoQ")]
[Description(@"Specifies a character string with a minimum length of 5 characters, and a maximum length of 8 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Min5Max8Text>))]
public readonly struct Min5Max8Text : IIsoSimpleValue<string>, IEquatable<Min5Max8Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 5;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 8;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Min5Max8Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Min5Max8Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Min5Max8Text), value, MaxLength);
        Value = value;
    }

    public static bool TryCreate(string? value, [NotNullWhen(true)] out Min5Max8Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    public static implicit operator Min5Max8Text(string value) => new(value);
    public static implicit operator string(Min5Max8Text t) => t.Value;
    public override string ToString() => Value ?? string.Empty;
    public bool Equals(Min5Max8Text other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is Min5Max8Text other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    public static bool operator ==(Min5Max8Text a, Min5Max8Text b) => a.Equals(b);
    public static bool operator !=(Min5Max8Text a, Min5Max8Text b) => !a.Equals(b);
    public static bool operator ==(Min5Max8Text a, string? b) => a.Value == b;
    public static bool operator !=(Min5Max8Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, Min5Max8Text b) => a == b.Value;
    public static bool operator !=(string? a, Min5Max8Text b) => a != b.Value;
}
