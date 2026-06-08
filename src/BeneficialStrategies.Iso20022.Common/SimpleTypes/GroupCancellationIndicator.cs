// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Indicates whether or not it is a group cancellation.
/// </summary>
/// <remarks>
/// Wire values: <c>"true"</c> (Cancellation applies to the complete group.) or <c>"false"</c> (Cancellation applies to individual items within the group.).
/// Supports direct bool assignment: <c>GroupCancellationIndicator flag = true;</c>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YY7X1Np-Ed-ak6NoX_4Aeg_1656514158")]
[Description(@"Indicates whether or not it is a group cancellation.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<GroupCancellationIndicator>))]
public readonly struct GroupCancellationIndicator : IIsoSimpleValue<string>, IEquatable<GroupCancellationIndicator>
{
    private const string TrueWire  = "true";
    private const string FalseWire = "false";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>The boolean value represented by this indicator.</summary>
    public bool BoolValue => Value == TrueWire;

    /// <summary>Initializes a new instance from a bool.</summary>
    public GroupCancellationIndicator(bool value) { Value = value ? TrueWire : FalseWire; }

    /// <summary>Initializes a new instance from the wire string "true" or "false".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is
    /// neither "true" nor "false".
    /// </exception>
    public GroupCancellationIndicator(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != TrueWire && value != FalseWire)
            throw new Iso20022FormatException(typeof(GroupCancellationIndicator), value, @"^(true|false)$");
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "true" or "false".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out GroupCancellationIndicator result)
    {
        if (value == TrueWire || value == FalseWire) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Returns a valid instance for any <see cref="bool"/> value.</summary>
    public static bool TryCreate(bool value, out GroupCancellationIndicator result)
    { result = new(value); return true; }

    /// <summary>Implicitly wraps a bool as a <see cref="GroupCancellationIndicator"/>.</summary>
    public static implicit operator GroupCancellationIndicator(bool value)   => new(value);
    /// <summary>Implicitly wraps a wire string as a <see cref="GroupCancellationIndicator"/>.</summary>
    public static implicit operator GroupCancellationIndicator(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string.</summary>
    public static implicit operator string(GroupCancellationIndicator ind)   => ind.Value;
    /// <summary>Implicitly unwraps to the bool value.</summary>
    public static implicit operator bool(GroupCancellationIndicator ind)     => ind.BoolValue;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(GroupCancellationIndicator other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is GroupCancellationIndicator other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(GroupCancellationIndicator a, GroupCancellationIndicator b)  => a.Equals(b);
    public static bool operator !=(GroupCancellationIndicator a, GroupCancellationIndicator b)  => !a.Equals(b);
    public static bool operator ==(GroupCancellationIndicator a, string? b)  => a.Value == b;
    public static bool operator !=(GroupCancellationIndicator a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, GroupCancellationIndicator b)  => a == b.Value;
    public static bool operator !=(string? a, GroupCancellationIndicator b)  => a != b.Value;
    public static bool operator ==(GroupCancellationIndicator a, bool b)     => a.BoolValue == b;
    public static bool operator !=(GroupCancellationIndicator a, bool b)     => a.BoolValue != b;
    public static bool operator ==(bool a, GroupCancellationIndicator b)     => a == b.BoolValue;
    public static bool operator !=(bool a, GroupCancellationIndicator b)     => a != b.BoolValue;
}
