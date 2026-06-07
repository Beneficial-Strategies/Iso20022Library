// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Specifies a character string with an exact length of 2 characters that must match the pattern XX or TS.
/// </summary>
/// <remarks>
/// Only two values are valid: <c>"XX"</c> and <c>"TS"</c>. The ISO spec pattern is <c>XX|TS</c>.
/// This type is modelled as a validated struct rather than an enum to maintain consistency with
/// the external code set pattern, and because the spec may extend the value set in future revisions.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_WOybhdp-Ed-ak6NoX_4Aeg_1837848735")]
[Description(@"Specifies a character string with an exact length of 2 characters that must has a pattern XX|TS.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RestrictedFINExact2Text>))]
public readonly struct RestrictedFINExact2Text : IIsoSimpleValue<string>, IEquatable<RestrictedFINExact2Text>
{
    /// <summary>ISO 20022 pattern constraint — only "XX" or "TS" are valid.</summary>
    public const string Pattern = @"^(XX|TS)$";

    /// <summary>The first valid value.</summary>
    public const string ValueXX = "XX";
    /// <summary>The second valid value.</summary>
    public const string ValueTS = "TS";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with "XX" or "TS".</summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when value is neither "XX" nor "TS".
    /// </exception>
    public RestrictedFINExact2Text(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value != ValueXX && value != ValueTS)
            throw new Iso20022FormatException(typeof(RestrictedFINExact2Text), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is "XX" or "TS".</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RestrictedFINExact2Text result)
    {
        if (value == ValueXX || value == ValueTS) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="RestrictedFINExact2Text"/>.</summary>
    public static implicit operator RestrictedFINExact2Text(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RestrictedFINExact2Text text) => text.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RestrictedFINExact2Text other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RestrictedFINExact2Text other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(RestrictedFINExact2Text a, RestrictedFINExact2Text b) => a.Equals(b);
    public static bool operator !=(RestrictedFINExact2Text a, RestrictedFINExact2Text b) => !a.Equals(b);
    public static bool operator ==(RestrictedFINExact2Text a, string? b) => a.Value == b;
    public static bool operator !=(RestrictedFINExact2Text a, string? b) => a.Value != b;
    public static bool operator ==(string? a, RestrictedFINExact2Text b) => a == b.Value;
    public static bool operator !=(string? a, RestrictedFINExact2Text b) => a != b.Value;
}
