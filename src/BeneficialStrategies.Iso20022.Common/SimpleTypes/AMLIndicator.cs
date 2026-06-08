// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates the status of an anti-money laundering investigation.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Investigation is related to AML.) or <c>"false"</c> (Investigation is not related to AML.).
/// Supports direct bool assignment: <c>AMLIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YY7X09p-Ed-ak6NoX_4Aeg_1082996795")]
[Description(@"Indicates the status of an anti-money laundering investigation.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<AMLIndicator>))]
public readonly struct AMLIndicator : IIsoSimpleValue<string>, IEquatable<AMLIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public AMLIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public AMLIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(AMLIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out AMLIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out AMLIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="AMLIndicator"/>.</summary>
    public static implicit operator AMLIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="AMLIndicator"/>.</summary>
    public static implicit operator AMLIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(AMLIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(AMLIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(AMLIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is AMLIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(AMLIndicator a, AMLIndicator b)  => a.Equals(b);
    public static bool operator !=(AMLIndicator a, AMLIndicator b)  => !a.Equals(b);
    public static bool operator ==(AMLIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(AMLIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, AMLIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, AMLIndicator b)  => a != b.Value;
    public static bool operator ==(AMLIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(AMLIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, AMLIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, AMLIndicator b)     => a != b.BoolValue;
}
