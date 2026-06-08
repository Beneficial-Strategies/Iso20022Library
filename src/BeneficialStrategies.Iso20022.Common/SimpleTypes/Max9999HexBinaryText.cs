// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with a maximum length of 9999 binary bytes (19998 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.</summary>
[DataContract]
[Serializable]
[IsoId("_TwhAATFWEemqWbBf8xprQQ")]
[Description(@"Specifies a character string with a maximum length of 9999 binary bytes (19998 hexadecimal text characters). Used only for hex binary data, supports only characters A-F and 0-9.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<Max9999HexBinaryText>))]
public readonly struct Max9999HexBinaryText : IIsoSimpleValue<string>, IEquatable<Max9999HexBinaryText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([0-9A-F][0-9A-F]){1,9999}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public Max9999HexBinaryText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(Max9999HexBinaryText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out Max9999HexBinaryText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <inheritdoc/>
    public static implicit operator Max9999HexBinaryText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(Max9999HexBinaryText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(Max9999HexBinaryText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Max9999HexBinaryText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(Max9999HexBinaryText a, Max9999HexBinaryText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(Max9999HexBinaryText a, Max9999HexBinaryText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(Max9999HexBinaryText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(Max9999HexBinaryText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, Max9999HexBinaryText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, Max9999HexBinaryText b) => a != b.Value;
}
