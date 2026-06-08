// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Spanish Domestic Interbanking Code. Identifies Spanish financial institutions on the Spanish national clearing system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3F9p-Ed-ak6NoX_4Aeg_-870708052")]
[Description(@"Spanish Domestic Interbanking Code. Identifies Spanish financial institutions on the Spanish national clearing system.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SpanishDomesticInterbankingIdentifier>))]
public readonly struct SpanishDomesticInterbankingIdentifier : IIsoSimpleValue<string>, IEquatable<SpanishDomesticInterbankingIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^ES[0-9]{8,9}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public SpanishDomesticInterbankingIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SpanishDomesticInterbankingIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SpanishDomesticInterbankingIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SpanishDomesticInterbankingIdentifier"/>.</summary>
    public static implicit operator SpanishDomesticInterbankingIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SpanishDomesticInterbankingIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SpanishDomesticInterbankingIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SpanishDomesticInterbankingIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(SpanishDomesticInterbankingIdentifier a, SpanishDomesticInterbankingIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(SpanishDomesticInterbankingIdentifier a, SpanishDomesticInterbankingIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(SpanishDomesticInterbankingIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(SpanishDomesticInterbankingIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, SpanishDomesticInterbankingIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, SpanishDomesticInterbankingIdentifier b) => a != b.Value;
}
