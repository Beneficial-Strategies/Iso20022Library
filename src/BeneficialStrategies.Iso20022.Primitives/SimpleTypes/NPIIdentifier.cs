// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Unambiguous natural person identifier (NPI) and the relevant reference data to uniquely identify the natural person relevant to any financial transaction rather than the personal identifying information as described in ISO 24366:2021 - Financial Services - Natural person identifier (NPI).
/// </summary>
/// <remarks>
/// The format of the NPI shall be: 13 upper-case alphanumeric characters (A to Z and 0 to 9 only) followed by 2 check digits.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_H7UncJ1-Ee66dOzaoGWV9g")]
[Description(@"Unambiguous natural person identifier (NPI) and the relevant reference data to uniquely identify the natural person relevant to any financial transaction rather than the personal identifying information as described in ISO 24366:2021 - Financial Services - Natural person identifier (NPI).|The format of the NPI shall be: 13 upper-case alphanumeric characters (A to Z and 0 to 9 only) followed by 2 check digits.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<NPIIdentifier>))]
public readonly struct NPIIdentifier : IIsoSimpleValue<string>, IEquatable<NPIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{13}[0-9]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public NPIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(NPIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out NPIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="NPIIdentifier"/>.</summary>
    public static implicit operator NPIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(NPIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(NPIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is NPIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(NPIIdentifier a, NPIIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(NPIIdentifier a, NPIIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(NPIIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(NPIIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, NPIIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, NPIIdentifier b) => a != b.Value;
}
