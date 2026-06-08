// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 Banking - Banking telecommunication messages - Business identifier code (BIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YWr8J9p-Ed-ak6NoX_4Aeg_1527093533")]
[Description(@"Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 Banking - Banking telecommunication messages - Business identifier code (BIC).")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BEIIdentifier>))]
public readonly struct BEIIdentifier : IIsoSimpleValue<string>, IEquatable<BEIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public BEIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BEIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BEIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BEIIdentifier"/>.</summary>
    public static implicit operator BEIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BEIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BEIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BEIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(BEIIdentifier a, BEIIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(BEIIdentifier a, BEIIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(BEIIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BEIIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BEIIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, BEIIdentifier b) => a != b.Value;
}
