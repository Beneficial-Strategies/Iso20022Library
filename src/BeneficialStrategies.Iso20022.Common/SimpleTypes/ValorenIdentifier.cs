// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier ("IdentifierSet, no formal pattern").
/// Per CLAUDE.md's exception for primitives defined by an external standard: Valor/Valoren
/// numbers are purely numeric, 6 to 9 digits, with no embedded meaning, classification, or check
/// digit of their own (a check digit only appears when a Valoren is embedded inside a full Swiss
/// ISIN — <c>CH</c> + Valoren + the ISIN's own check digit — that check digit belongs to the ISIN,
/// not to this type). Source:
/// <see href="https://en.wikipedia.org/wiki/Valoren_number">Wikipedia — Valoren number</see>,
/// <see href="https://corporatefinanceinstitute.com/resources/career-map/sell-side/capital-markets/valoren-number/">Corporate Finance Institute — Valoren Number</see>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYer49p-Ed-ak6NoX_4Aeg_1324882079")]
[Description(@"Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ValorenIdentifier>))]
public readonly struct ValorenIdentifier : IIsoSimpleValue<string>, IEquatable<ValorenIdentifier>
{
    /// <summary>Digits only, 6 to 9 characters — no check digit (see type remarks for source).</summary>
    public const string Pattern = @"^[0-9]{6,9}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ValorenIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ValorenIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ValorenIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ValorenIdentifier"/>.</summary>
    public static implicit operator ValorenIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ValorenIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ValorenIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ValorenIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ValorenIdentifier a, ValorenIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ValorenIdentifier a, ValorenIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ValorenIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ValorenIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ValorenIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ValorenIdentifier b) => a != b.Value;
}
