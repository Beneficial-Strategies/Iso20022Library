// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// A flag indicating a True or False value.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (True) or <c>"false"</c> (False).
/// Supports direct bool assignment: <c>TrueFalseIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXvFBNp-Ed-ak6NoX_4Aeg_143431716")]
[Description(@"A flag indicating a True or False value.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<TrueFalseIndicator>))]
public readonly struct TrueFalseIndicator : IIsoSimpleValue<string>, IEquatable<TrueFalseIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public TrueFalseIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public TrueFalseIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(TrueFalseIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out TrueFalseIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out TrueFalseIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="TrueFalseIndicator"/>.</summary>
    public static implicit operator TrueFalseIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="TrueFalseIndicator"/>.</summary>
    public static implicit operator TrueFalseIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(TrueFalseIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(TrueFalseIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(TrueFalseIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is TrueFalseIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(TrueFalseIndicator a, TrueFalseIndicator b)  => a.Equals(b);
    public static bool operator !=(TrueFalseIndicator a, TrueFalseIndicator b)  => !a.Equals(b);
    public static bool operator ==(TrueFalseIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(TrueFalseIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, TrueFalseIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, TrueFalseIndicator b)  => a != b.Value;
    public static bool operator ==(TrueFalseIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(TrueFalseIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, TrueFalseIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, TrueFalseIndicator b)     => a != b.BoolValue;
}
