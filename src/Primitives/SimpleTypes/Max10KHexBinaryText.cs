// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 10000 binary bytes (20000 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.</summary>
[DataContract]
[Serializable]
[IsoId("_gsRgsJKOEempjNUC7bi_Ng")]
[Description(@"Specifies a character string with a maximum length of 10000 binary bytes (20000 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max10KHexBinaryText>))]
public readonly struct Max10KHexBinaryText : IIsoSimpleValue<string>, IEquatable<Max10KHexBinaryText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([0-9A-F][0-9A-F]){1,10000}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Max10KHexBinaryText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Max10KHexBinaryText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max10KHexBinaryText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max10KHexBinaryText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max10KHexBinaryText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max10KHexBinaryText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max10KHexBinaryText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max10KHexBinaryText a, Max10KHexBinaryText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max10KHexBinaryText a, Max10KHexBinaryText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max10KHexBinaryText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max10KHexBinaryText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max10KHexBinaryText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max10KHexBinaryText b) => a != b.Value;
}
