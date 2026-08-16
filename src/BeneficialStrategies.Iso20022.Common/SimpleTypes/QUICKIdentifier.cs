// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier ("IdentifierSet, no formal pattern").
/// Researched externally per CLAUDE.md's exception for primitives defined by an external standard,
/// but no public documentation of a QUICK-specific check-digit algorithm or fixed-length format
/// was found — Japanese exchange-listed securities are more commonly identified today by a 4-digit
/// (soon alphanumeric) Securities Identification Code or by ISIN, and QUICK's own internal
/// numbering doesn't appear to be publicly specified in detail. Left permissive (no check digit,
/// no fixed length) rather than guessing at a structure; revisit if a primary QUICK Corp. source
/// ever turns up.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYU65tp-Ed-ak6NoX_4Aeg_1324881777")]
[Description(@"Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<QUICKIdentifier>))]
public readonly struct QUICKIdentifier : IIsoSimpleValue<string>, IEquatable<QUICKIdentifier>
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
    public QUICKIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(QUICKIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out QUICKIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="QUICKIdentifier"/>.</summary>
    public static implicit operator QUICKIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(QUICKIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(QUICKIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is QUICKIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(QUICKIdentifier a, QUICKIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(QUICKIdentifier a, QUICKIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(QUICKIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(QUICKIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, QUICKIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, QUICKIdentifier b) => a != b.Value;
}
