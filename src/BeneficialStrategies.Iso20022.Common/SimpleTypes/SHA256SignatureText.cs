// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>Specifies a character string with an exact length of 32 binary bytes (64 hexadecimal text characters). Used only for hex binary data only, supports only characters A-F and 0-9.</summary>
[DataContract]
[Serializable]
[IsoId("_GG-XID6vEe-QZYT2pcGFZw")]
[Description(@"Specifies a character string with an exact length of 32 binary bytes (64 hexadecimal text characters). Used only for hex binary data only, supports only characters A-F and 0-9.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SHA256SignatureText>))]
public readonly struct SHA256SignatureText : IIsoSimpleValue<string>, IEquatable<SHA256SignatureText>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^([0-9A-F][0-9A-F]){32}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown with PatternMismatch when value does not satisfy Pattern.</exception>
    public SHA256SignatureText(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SHA256SignatureText), value, Pattern);
        Value = value;
    }

    /// <inheritdoc/>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SHA256SignatureText result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <inheritdoc/>
    public static implicit operator SHA256SignatureText(string value) => new(value);
    /// <inheritdoc/>
    public static implicit operator string(SHA256SignatureText t) => t.Value;
    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SHA256SignatureText other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SHA256SignatureText other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    /// <inheritdoc/>
    public static bool operator ==(SHA256SignatureText a, SHA256SignatureText b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(SHA256SignatureText a, SHA256SignatureText b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(SHA256SignatureText a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(SHA256SignatureText a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, SHA256SignatureText b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, SHA256SignatureText b) => a != b.Value;
}
