// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a minimum length of 6 characters, and a maximum length of 8 characters.</summary>
[DataContract]
[Serializable]
[IsoId("_TQlExQEcEeCQm6a_G2yO_w_1570384117")]
[Description(@"Specifies a character string with a minimum length of 6 characters, and a maximum length of 8 characters.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Min6Max8Text>))]
public readonly struct Min6Max8Text : IIsoSimpleValue<string>, IEquatable<Min6Max8Text>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 6;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 8;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with TooShort or TooLong.</exception>
    public Min6Max8Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(Min6Max8Text), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(Min6Max8Text), value, MaxLength);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Min6Max8Text result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator Min6Max8Text(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Min6Max8Text t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Min6Max8Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Min6Max8Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Min6Max8Text a, Min6Max8Text b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Min6Max8Text a, Min6Max8Text b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Min6Max8Text a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Min6Max8Text a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Min6Max8Text b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Min6Max8Text b) => a != b.Value;
}
