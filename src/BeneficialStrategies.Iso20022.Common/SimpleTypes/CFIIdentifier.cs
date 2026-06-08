// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YYn11Np-Ed-ak6NoX_4Aeg_-793392713")]
[Description(@"Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification.")]
[Obsolete("Marked obsolete in the ISO 20022 specification.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CFIIdentifier>))]
public readonly struct CFIIdentifier : IIsoSimpleValue<string>, IEquatable<CFIIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{1,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public CFIIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CFIIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CFIIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CFIIdentifier"/>.</summary>
    public static implicit operator CFIIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CFIIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CFIIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CFIIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(CFIIdentifier a, CFIIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(CFIIdentifier a, CFIIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(CFIIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(CFIIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, CFIIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, CFIIdentifier b) => a != b.Value;
}
