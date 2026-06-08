// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates whether charges have already been included.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Included) or <c>"false"</c> (Pre-advised).
/// Supports direct bool assignment: <c>ChargeIncludedIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXSZFdp-Ed-ak6NoX_4Aeg_536141126")]
[Description(@"Indicates whether charges have already been included.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ChargeIncludedIndicator>))]
public readonly struct ChargeIncludedIndicator : IIsoSimpleValue<string>, IEquatable<ChargeIncludedIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public ChargeIncludedIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public ChargeIncludedIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(ChargeIncludedIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ChargeIncludedIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out ChargeIncludedIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="ChargeIncludedIndicator"/>.</summary>
    public static implicit operator ChargeIncludedIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="ChargeIncludedIndicator"/>.</summary>
    public static implicit operator ChargeIncludedIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(ChargeIncludedIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(ChargeIncludedIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ChargeIncludedIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ChargeIncludedIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ChargeIncludedIndicator a, ChargeIncludedIndicator b)  => a.Equals(b);
    public static bool operator !=(ChargeIncludedIndicator a, ChargeIncludedIndicator b)  => !a.Equals(b);
    public static bool operator ==(ChargeIncludedIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(ChargeIncludedIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, ChargeIncludedIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, ChargeIncludedIndicator b)  => a != b.Value;
    public static bool operator ==(ChargeIncludedIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(ChargeIncludedIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, ChargeIncludedIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, ChargeIncludedIndicator b)     => a != b.BoolValue;
}
