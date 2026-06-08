// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gnK3okI7EeirV6K70JJQ8Q")]
[Description(@"Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362: 2014 - Banking - Banking telecommunication messages - Business identifier code (BIC).")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<BICFIDec2014Identifier>))]
public readonly struct BICFIDec2014Identifier : IIsoSimpleValue<string>, IEquatable<BICFIDec2014Identifier>
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
    public BICFIDec2014Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BICFIDec2014Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out BICFIDec2014Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BICFIDec2014Identifier"/>.</summary>
    public static implicit operator BICFIDec2014Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(BICFIDec2014Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BICFIDec2014Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BICFIDec2014Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(BICFIDec2014Identifier a, BICFIDec2014Identifier b)  => a.Equals(b);
    public static bool operator !=(BICFIDec2014Identifier a, BICFIDec2014Identifier b)  => !a.Equals(b);
    public static bool operator ==(BICFIDec2014Identifier a, string? b)  => a.Value == b;
    public static bool operator !=(BICFIDec2014Identifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, BICFIDec2014Identifier b)  => a == b.Value;
    public static bool operator !=(string? a, BICFIDec2014Identifier b)  => a != b.Value;
}
