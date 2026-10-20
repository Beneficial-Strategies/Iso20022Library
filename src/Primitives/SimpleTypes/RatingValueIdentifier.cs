// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// Identifies the rating values that may be assigned to a security by a rating agency.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier ("IdentifierSet, no formal pattern");
/// its <c>identificationScheme</c> metadata just says "FPL; FIX" and no FIX field documenting a
/// concrete RatingValue grammar could be found. Per CLAUDE.md's exception for primitives defined
/// by an external standard, this is the best available public information, not an ISO 20022
/// source:
/// <list type="bullet">
///   <item><description>
///   The major agencies' long-term grade symbols share one casing convention despite differing
///   alphabets: S&amp;P/Fitch use all-uppercase letters with an optional trailing <c>+</c>/<c>-</c>
///   modifier (<c>AAA</c>, <c>AA+</c>, <c>BBB-</c>); Moody's capitalizes only the first letter,
///   with an optional trailing <c>1</c>/<c>2</c>/<c>3</c> modifier instead
///   (<c>Aaa</c>, <c>Aa1</c>, <c>Baa2</c>). Every real-world grade symbol found starts with an
///   uppercase letter — that's the casing rule this pattern enforces. Source:
///   <see href="https://ratings.moodys.com/api/rmc-documents/53954">Moody's — Rating Symbols and Definitions</see>,
///   general S&amp;P/Fitch scale documentation.
///   </description></item>
///   <item><description>
///   Deliberately NOT enforced (left permissive — no verified single source covers these): Fitch's
///   rare lowercase "credit opinion" suffix forms (e.g. <c>bbb+*</c>); provisional/expected-rating
///   prefix notation (e.g. Moody's <c>(P)Aaa</c>, S&amp;P <c>(exp)</c>); non-grade administrative
///   values beyond the common <c>NR</c>/<c>WD</c>/<c>WR</c>/<c>SD</c>/<c>RD</c> shapes already
///   covered by the pattern's shape. If any of these turn out to matter in practice, tighten or
///   extend the pattern then — easier than loosening a pattern consumers already depend on.
///   </description></item>
/// </list>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_YYn11tp-Ed-ak6NoX_4Aeg_347956")]
[Description(@"Identifies the rating values that may be assigned to a security by a rating agency.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<RatingValueIdentifier>))]
public readonly struct RatingValueIdentifier : IIsoSimpleValue<string>, IEquatable<RatingValueIdentifier>
{
    /// <summary>Leading uppercase letter (shared casing convention across rating agencies), then up to 4 more letters/digits/+/- (see type remarks for source).</summary>
    public const string Pattern = @"^[A-Z][A-Za-z0-9+\-]{0,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public RatingValueIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(RatingValueIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out RatingValueIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="RatingValueIdentifier"/>.</summary>
    public static implicit operator RatingValueIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(RatingValueIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(RatingValueIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RatingValueIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(RatingValueIdentifier a, RatingValueIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(RatingValueIdentifier a, RatingValueIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(RatingValueIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(RatingValueIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, RatingValueIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, RatingValueIdentifier b) => a != b.Value;
}
