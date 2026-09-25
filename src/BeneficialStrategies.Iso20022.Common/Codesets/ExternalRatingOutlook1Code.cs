// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// View of current rating, assigned by a ratings agency, in relation to the expected future rating.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes. Versioned restriction of <see cref="ExternalRatingOutlookCode"/> — each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_s7PmIFAsEfCpNoeDQdjnVw")]
[Description(@"View of current rating, assigned by a ratings agency, in relation to the expected future rating.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalRatingOutlook1Code>))]
public readonly struct ExternalRatingOutlook1Code : IIsoExternalCode, IEquatable<ExternalRatingOutlook1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalRatingOutlook1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalRatingOutlook1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalRatingOutlook1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalRatingOutlook1Code"/>.</summary>
    public static implicit operator ExternalRatingOutlook1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalRatingOutlook1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalRatingOutlook1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalRatingOutlook1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalRatingOutlook1Code a, ExternalRatingOutlook1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalRatingOutlook1Code a, ExternalRatingOutlook1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalRatingOutlook1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalRatingOutlook1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalRatingOutlook1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalRatingOutlook1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>The rating may be raised or lowered by the rating agency.</summary>
    [IsoId("_Xzf8g4f0EfCzEuHYqu6c4w")]
    [Description(@"The rating may be raised or lowered by the rating agency.")]
    public static readonly ExternalRatingOutlook1Code Developing = new("DEVL");

    /// <summary>The rating may be raised, lowered or affirmed as defined by the rating agency.</summary>
    [IsoId("_Xzf8h4f0EfCzEuHYqu6c4w")]
    [Description(@"The rating may be raised, lowered or affirmed as defined by the rating agency.")]
    public static readonly ExternalRatingOutlook1Code Evolving = new("EVLV");

    /// <summary>Rating outlook does not apply or is not available.</summary>
    [IsoId("_Xzf8iYf0EfCzEuHYqu6c4w")]
    [Description(@"Rating outlook does not apply or is not available.")]
    public static readonly ExternalRatingOutlook1Code NotApplicable = new("NAPP");

    /// <summary>The rating may be lowered by the rating agency.</summary>
    [IsoId("_Xzf8gYf0EfCzEuHYqu6c4w")]
    [Description(@"The rating may be lowered by the rating agency.")]
    public static readonly ExternalRatingOutlook1Code Negative = new("NGTV");

    /// <summary>No rating opion on outlook exists.</summary>
    [IsoId("_Xzf8hYf0EfCzEuHYqu6c4w")]
    [Description(@"No rating opion on outlook exists.")]
    public static readonly ExternalRatingOutlook1Code NotMeaningful = new("NMEA");

    /// <summary>Rating may be raised by the rating agency.</summary>
    [IsoId("_XzfVcYf0EfCzEuHYqu6c4w")]
    [Description(@"Rating may be raised by the rating agency.")]
    public static readonly ExternalRatingOutlook1Code Positive = new("PSTV");

    /// <summary>Rating is unlikely to change.</summary>
    [IsoId("_XzfVc4f0EfCzEuHYqu6c4w")]
    [Description(@"Rating is unlikely to change.")]
    public static readonly ExternalRatingOutlook1Code Stable = new("STBL");
}
