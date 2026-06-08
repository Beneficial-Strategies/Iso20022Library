// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 8 binary bytes (16 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.</summary>
[DataContract]
[Serializable]
[IsoId("_9kUNMZcnEeme5LKU36W8xA")]
[Description(@"Specifies a character string with a maximum length of 8 binary bytes (16 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max8HexBinaryText>))]
public readonly struct Max8HexBinaryText : IIsoSimpleValue<string>, IEquatable<Max8HexBinaryText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([0-9A-F][0-9A-F]){1,8}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Max8HexBinaryText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Max8HexBinaryText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max8HexBinaryText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max8HexBinaryText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max8HexBinaryText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max8HexBinaryText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max8HexBinaryText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max8HexBinaryText a, Max8HexBinaryText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max8HexBinaryText a, Max8HexBinaryText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max8HexBinaryText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max8HexBinaryText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max8HexBinaryText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max8HexBinaryText b) => a != b.Value;
}
