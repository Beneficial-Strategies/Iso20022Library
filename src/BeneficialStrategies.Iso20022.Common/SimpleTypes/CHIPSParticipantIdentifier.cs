// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// CHIPS Participant Identifier. Identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3Etp-Ed-ak6NoX_4Aeg_-870708329")]
[Description(@"CHIPS Participant Identifier. Identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CHIPSParticipantIdentifier>))]
public readonly struct CHIPSParticipantIdentifier : IIsoSimpleValue<string>, IEquatable<CHIPSParticipantIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^CP[0-9]{4,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public CHIPSParticipantIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CHIPSParticipantIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CHIPSParticipantIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CHIPSParticipantIdentifier"/>.</summary>
    public static implicit operator CHIPSParticipantIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CHIPSParticipantIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CHIPSParticipantIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CHIPSParticipantIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(CHIPSParticipantIdentifier a, CHIPSParticipantIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(CHIPSParticipantIdentifier a, CHIPSParticipantIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(CHIPSParticipantIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(CHIPSParticipantIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, CHIPSParticipantIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, CHIPSParticipantIdentifier b) => a != b.Value;
}
