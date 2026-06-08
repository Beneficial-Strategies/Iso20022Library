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
[IsoId("_YWZBMtp-Ed-ak6NoX_4Aeg_-1233681561")]
[Description(@"Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 Banking - Banking telecommunication messages - Business identifier code (BIC).")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BICNonFIIdentifier>))]
public readonly struct BICNonFIIdentifier : IIsoSimpleValue<string>, IEquatable<BICNonFIIdentifier>
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
    public BICNonFIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BICNonFIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BICNonFIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BICNonFIIdentifier"/>.</summary>
    public static implicit operator BICNonFIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BICNonFIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BICNonFIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BICNonFIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(BICNonFIIdentifier a, BICNonFIIdentifier b) => a.Equals(b);
    public static bool operator !=(BICNonFIIdentifier a, BICNonFIIdentifier b) => !a.Equals(b);
    public static bool operator ==(BICNonFIIdentifier a, string? b) => a.Value == b;
    public static bool operator !=(BICNonFIIdentifier a, string? b) => a.Value != b;
    public static bool operator ==(string? a, BICNonFIIdentifier b) => a == b.Value;
    public static bool operator !=(string? a, BICNonFIIdentifier b) => a != b.Value;
}
