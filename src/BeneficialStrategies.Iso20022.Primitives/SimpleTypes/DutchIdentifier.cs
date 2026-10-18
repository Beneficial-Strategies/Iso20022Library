// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier for Dutch securities.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier ("IdentifierSet, no formal pattern"),
/// and ISO's own definition text is just the single sentence above — no issuing body or scheme
/// name given. Researched externally per CLAUDE.md's exception for primitives defined by an
/// external standard, but this appears to be an obscure/legacy pre-ISIN Dutch national numbering
/// scheme with no findable public documentation of its format, length, or (if any) check digit.
/// Left permissive rather than guessing at a structure; revisit if a primary source (e.g. a
/// Euronext Amsterdam or AFM technical spec) is ever located.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYLJ5tp-Ed-ak6NoX_4Aeg_1324881724")]
[Description(@"Identifier for Dutch securities.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<DutchIdentifier>))]
public readonly struct DutchIdentifier : IIsoSimpleValue<string>, IEquatable<DutchIdentifier>
{
    /// <summary>No externally verifiable format found — non-empty string only (see type remarks).</summary>
    public const string Pattern = @"^.+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public DutchIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(DutchIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out DutchIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="DutchIdentifier"/>.</summary>
    public static implicit operator DutchIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(DutchIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(DutchIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DutchIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(DutchIdentifier a, DutchIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(DutchIdentifier a, DutchIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(DutchIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(DutchIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, DutchIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, DutchIdentifier b) => a != b.Value;
}
