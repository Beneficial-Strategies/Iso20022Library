// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates whether a round-lot market or limit-price order must be executed in its entirety or not at all.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (All) or <c>"false"</c> (None).
/// Supports direct bool assignment: <c>AllOrNoneIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YXSZE9p-Ed-ak6NoX_4Aeg_2104189385")]
[Description(@"Indicates whether a round-lot market or limit-price order must be executed in its entirety or not at all.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<AllOrNoneIndicator>))]
public readonly struct AllOrNoneIndicator : IIsoSimpleValue<string>, IEquatable<AllOrNoneIndicator>
{
    private const string TrueWire = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public AllOrNoneIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public AllOrNoneIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(AllOrNoneIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out AllOrNoneIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out AllOrNoneIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="AllOrNoneIndicator"/>.</summary>
    public static implicit operator AllOrNoneIndicator(bool value) => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="AllOrNoneIndicator"/>.</summary>
    public static implicit operator AllOrNoneIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(AllOrNoneIndicator ind) => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(AllOrNoneIndicator ind) => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(AllOrNoneIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is AllOrNoneIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(AllOrNoneIndicator a, AllOrNoneIndicator b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(AllOrNoneIndicator a, AllOrNoneIndicator b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(AllOrNoneIndicator a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(AllOrNoneIndicator a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, AllOrNoneIndicator b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, AllOrNoneIndicator b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(AllOrNoneIndicator a, bool b) => a.BoolValue == b;
    /// <inheritdoc/>
    public static bool operator !=(AllOrNoneIndicator a, bool b) => a.BoolValue != b;
    /// <inheritdoc/>
    public static bool operator ==(bool a, AllOrNoneIndicator b) => a == b.BoolValue;
    /// <inheritdoc/>
    public static bool operator !=(bool a, AllOrNoneIndicator b) => a != b.BoolValue;
}
