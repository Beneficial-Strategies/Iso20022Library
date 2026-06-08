// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with hexadecimal text characters. Used for hex binary data only, supports only characters A-F, a-f and 0-9.</summary>
[DataContract]
[Serializable]
[IsoId("_fSB70eUrEe-hiLO2BySjZw")]
[Description(@"Specifies a character string with hexadecimal text characters. Used for hex binary data only, supports only characters A-F, a-f and 0-9.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<HexBinaryText>))]
public readonly struct HexBinaryText : IIsoSimpleValue<string>, IEquatable<HexBinaryText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[0-9a-fA-F]+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public HexBinaryText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(HexBinaryText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out HexBinaryText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator HexBinaryText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(HexBinaryText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(HexBinaryText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is HexBinaryText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(HexBinaryText a, HexBinaryText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(HexBinaryText a, HexBinaryText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(HexBinaryText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(HexBinaryText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, HexBinaryText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, HexBinaryText b) => a != b.Value;
}
