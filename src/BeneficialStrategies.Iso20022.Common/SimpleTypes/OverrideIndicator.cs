// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates whether an arrangement has to be overridden or not.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Override) or <c>"false"</c> (Not override).
/// Supports direct bool assignment: <c>OverrideIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXSZFNp-Ed-ak6NoX_4Aeg_-884916086")]
[Description(@"Indicates whether an arrangement has to be overridden or not.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<OverrideIndicator>))]
public readonly struct OverrideIndicator : IIsoSimpleValue<string>, IEquatable<OverrideIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public OverrideIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public OverrideIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(OverrideIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out OverrideIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out OverrideIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="OverrideIndicator"/>.</summary>
    public static implicit operator OverrideIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="OverrideIndicator"/>.</summary>
    public static implicit operator OverrideIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(OverrideIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(OverrideIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(OverrideIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is OverrideIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(OverrideIndicator a, OverrideIndicator b)  => a.Equals(b);
    public static bool operator !=(OverrideIndicator a, OverrideIndicator b)  => !a.Equals(b);
    public static bool operator ==(OverrideIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(OverrideIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, OverrideIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, OverrideIndicator b)  => a != b.Value;
    public static bool operator ==(OverrideIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(OverrideIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, OverrideIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, OverrideIndicator b)     => a != b.BoolValue;
}
