// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifies whether or not the party and/or account identification information is correct.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Identification information received is correct.) or <c>"false"</c> (Identification information received is incorrect.).
/// Supports direct bool assignment: <c>IdentificationVerificationIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YWiyMdp-Ed-ak6NoX_4Aeg_718191217")]
[Description(@"Identifies whether or not the party and/or account identification information is correct.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<IdentificationVerificationIndicator>))]
public readonly struct IdentificationVerificationIndicator : IIsoSimpleValue<string>, IEquatable<IdentificationVerificationIndicator>
{
    private const string TrueWire = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public IdentificationVerificationIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public IdentificationVerificationIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(IdentificationVerificationIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out IdentificationVerificationIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out IdentificationVerificationIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="IdentificationVerificationIndicator"/>.</summary>
    public static implicit operator IdentificationVerificationIndicator(bool value) => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="IdentificationVerificationIndicator"/>.</summary>
    public static implicit operator IdentificationVerificationIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(IdentificationVerificationIndicator ind) => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(IdentificationVerificationIndicator ind) => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(IdentificationVerificationIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IdentificationVerificationIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(IdentificationVerificationIndicator a, IdentificationVerificationIndicator b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(IdentificationVerificationIndicator a, IdentificationVerificationIndicator b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(IdentificationVerificationIndicator a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(IdentificationVerificationIndicator a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, IdentificationVerificationIndicator b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, IdentificationVerificationIndicator b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(IdentificationVerificationIndicator a, bool b) => a.BoolValue == b;
    /// <inheritdoc/>
    public static bool operator !=(IdentificationVerificationIndicator a, bool b) => a.BoolValue != b;
    /// <inheritdoc/>
    public static bool operator ==(bool a, IdentificationVerificationIndicator b) => a == b.BoolValue;
    /// <inheritdoc/>
    public static bool operator !=(bool a, IdentificationVerificationIndicator b) => a != b.BoolValue;
}
