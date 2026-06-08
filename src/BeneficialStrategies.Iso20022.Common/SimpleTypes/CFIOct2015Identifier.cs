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
[IsoId("_7njI4YIXEeWE0I8iABxEQA")]
[Description(@"Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<CFIOct2015Identifier>))]
public readonly struct CFIOct2015Identifier : IIsoSimpleValue<string>, IEquatable<CFIOct2015Identifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public CFIOct2015Identifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(CFIOct2015Identifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out CFIOct2015Identifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="CFIOct2015Identifier"/>.</summary>
    public static implicit operator CFIOct2015Identifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(CFIOct2015Identifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(CFIOct2015Identifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is CFIOct2015Identifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(CFIOct2015Identifier a, CFIOct2015Identifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(CFIOct2015Identifier a, CFIOct2015Identifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(CFIOct2015Identifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(CFIOct2015Identifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, CFIOct2015Identifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, CFIOct2015Identifier b) => a != b.Value;
}
