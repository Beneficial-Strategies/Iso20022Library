// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_snufckI7EeirV6K70JJQ8Q")]
[Description(@"Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BICNonFIDec2014Identifier>))]
public readonly struct BICNonFIDec2014Identifier : IIsoSimpleValue<string>, IEquatable<BICNonFIDec2014Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public BICNonFIDec2014Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BICNonFIDec2014Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BICNonFIDec2014Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BICNonFIDec2014Identifier"/>.</summary>
    public static implicit operator BICNonFIDec2014Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BICNonFIDec2014Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BICNonFIDec2014Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BICNonFIDec2014Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(BICNonFIDec2014Identifier a, BICNonFIDec2014Identifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(BICNonFIDec2014Identifier a, BICNonFIDec2014Identifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(BICNonFIDec2014Identifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BICNonFIDec2014Identifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BICNonFIDec2014Identifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, BICNonFIDec2014Identifier b) => a != b.Value;
}
