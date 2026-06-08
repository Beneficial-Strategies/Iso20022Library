// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifies whether the sending party requests a single debit or credit entry per individual transaction or a batch entry for the sum of the amounts of all transactions.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Batch entry requested.) or <c>"false"</c> (Single entry per transaction requested.).
/// Supports direct bool assignment: <c>BatchBookingIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXvFBtp-Ed-ak6NoX_4Aeg_205529668")]
[Description(@"Identifies whether the sending party requests a single debit or credit entry per individual transaction or a batch entry for the sum of the amounts of all transactions.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BatchBookingIndicator>))]
public readonly struct BatchBookingIndicator : IIsoSimpleValue<string>, IEquatable<BatchBookingIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public BatchBookingIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public BatchBookingIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(BatchBookingIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BatchBookingIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out BatchBookingIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="BatchBookingIndicator"/>.</summary>
    public static implicit operator BatchBookingIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="BatchBookingIndicator"/>.</summary>
    public static implicit operator BatchBookingIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(BatchBookingIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(BatchBookingIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BatchBookingIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BatchBookingIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(BatchBookingIndicator a, BatchBookingIndicator b)  => a.Equals(b);
    public static bool operator !=(BatchBookingIndicator a, BatchBookingIndicator b)  => !a.Equals(b);
    public static bool operator ==(BatchBookingIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(BatchBookingIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, BatchBookingIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, BatchBookingIndicator b)  => a != b.Value;
    public static bool operator ==(BatchBookingIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(BatchBookingIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, BatchBookingIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, BatchBookingIndicator b)     => a != b.BoolValue;
}
