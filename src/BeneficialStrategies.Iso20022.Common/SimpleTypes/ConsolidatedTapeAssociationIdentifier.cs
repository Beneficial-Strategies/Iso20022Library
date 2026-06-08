// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier of a security assigned by the Consolidated Tape Association.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYLJ5Np-Ed-ak6NoX_4Aeg_1324881707")]
[Description(@"Identifier of a security assigned by the Consolidated Tape Association.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ConsolidatedTapeAssociationIdentifier>))]
public readonly struct ConsolidatedTapeAssociationIdentifier : IIsoSimpleValue<string>, IEquatable<ConsolidatedTapeAssociationIdentifier>
{
    /// <summary>ISO 20022 minimum length constraint.</summary>
    public const int MinLength = 1;
    /// <summary>ISO 20022 maximum length constraint.</summary>
    public const int MaxLength = 35;

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.TooShort"/> or
    /// <see cref="Iso20022FormatViolation.TooLong"/> when length is outside [1..35].
    /// </exception>
    public ConsolidatedTapeAssociationIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length < MinLength)
            throw Iso20022FormatException.ForTooShort(typeof(ConsolidatedTapeAssociationIdentifier), value, MinLength);
        if (value.Length > MaxLength)
            throw Iso20022FormatException.ForTooLong(typeof(ConsolidatedTapeAssociationIdentifier), value, MaxLength);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies all constraints.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ConsolidatedTapeAssociationIdentifier result)
    {
        if (value is { Length: >= MinLength and <= MaxLength }) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ConsolidatedTapeAssociationIdentifier"/>.</summary>
    public static implicit operator ConsolidatedTapeAssociationIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ConsolidatedTapeAssociationIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ConsolidatedTapeAssociationIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ConsolidatedTapeAssociationIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ConsolidatedTapeAssociationIdentifier a, ConsolidatedTapeAssociationIdentifier b) => a.Equals(b);
    public static bool operator !=(ConsolidatedTapeAssociationIdentifier a, ConsolidatedTapeAssociationIdentifier b) => !a.Equals(b);
    public static bool operator ==(ConsolidatedTapeAssociationIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(ConsolidatedTapeAssociationIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ConsolidatedTapeAssociationIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, ConsolidatedTapeAssociationIdentifier b) => a != b.Value;
}
