// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates a positive or negative value.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Plus) or <c>"false"</c> (Minus).
/// Supports direct bool assignment: <c>PlusOrMinusIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXvFA9p-Ed-ak6NoX_4Aeg_143431681")]
[Description(@"Indicates a positive or negative value.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<PlusOrMinusIndicator>))]
public readonly struct PlusOrMinusIndicator : IIsoSimpleValue<string>, IEquatable<PlusOrMinusIndicator>
{
    private const string TrueWire = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public PlusOrMinusIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public PlusOrMinusIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(PlusOrMinusIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out PlusOrMinusIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out PlusOrMinusIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="PlusOrMinusIndicator"/>.</summary>
    public static implicit operator PlusOrMinusIndicator(bool value) => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="PlusOrMinusIndicator"/>.</summary>
    public static implicit operator PlusOrMinusIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(PlusOrMinusIndicator ind) => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(PlusOrMinusIndicator ind) => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(PlusOrMinusIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is PlusOrMinusIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(PlusOrMinusIndicator a, PlusOrMinusIndicator b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(PlusOrMinusIndicator a, PlusOrMinusIndicator b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(PlusOrMinusIndicator a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(PlusOrMinusIndicator a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, PlusOrMinusIndicator b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, PlusOrMinusIndicator b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(PlusOrMinusIndicator a, bool b) => a.BoolValue == b;
    /// <inheritdoc/>
    public static bool operator !=(PlusOrMinusIndicator a, bool b) => a.BoolValue != b;
    /// <inheritdoc/>
    public static bool operator ==(bool a, PlusOrMinusIndicator b) => a == b.BoolValue;
    /// <inheritdoc/>
    public static bool operator !=(bool a, PlusOrMinusIndicator b) => a != b.BoolValue;
}
