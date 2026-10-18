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
/// External code sets can be downloaded from www.iso20022.org. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_AUIFcAPFEfCtCJ35geulhA")]
[Description(@"View of current rating, assigned by a ratings agency, in relation to the expected future rating.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalRatingOutlookCode>))]
public readonly struct ExternalRatingOutlookCode : IIsoExternalCode, IEquatable<ExternalRatingOutlookCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalRatingOutlookCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalRatingOutlookCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalRatingOutlookCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalRatingOutlookCode"/>.</summary>
    public static implicit operator ExternalRatingOutlookCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalRatingOutlookCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalRatingOutlookCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalRatingOutlookCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalRatingOutlookCode a, ExternalRatingOutlookCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalRatingOutlookCode a, ExternalRatingOutlookCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalRatingOutlookCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalRatingOutlookCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalRatingOutlookCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalRatingOutlookCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>The rating may be raised or lowered by the rating agency.</summary>
    [IsoId("_j4sAgFAsEfCpNoeDQdjnVw")]
    [Description(@"The rating may be raised or lowered by the rating agency.")]
    public static readonly ExternalRatingOutlookCode Developing = new("DEVL");

    /// <summary>The rating may be raised, lowered or affirmed as defined by the rating agency.</summary>
    [IsoId("_mQGj0FAsEfCpNoeDQdjnVw")]
    [Description(@"The rating may be raised, lowered or affirmed as defined by the rating agency.")]
    public static readonly ExternalRatingOutlookCode Evolving = new("EVLV");

    /// <summary>Rating outlook does not apply or is not available.</summary>
    [IsoId("_nGCGQFAsEfCpNoeDQdjnVw")]
    [Description(@"Rating outlook does not apply or is not available.")]
    public static readonly ExternalRatingOutlookCode NotApplicable = new("NAPP");

    /// <summary>The rating may be lowered by the rating agency.</summary>
    [IsoId("_jLF6sFAsEfCpNoeDQdjnVw")]
    [Description(@"The rating may be lowered by the rating agency.")]
    public static readonly ExternalRatingOutlookCode Negative = new("NGTV");

    /// <summary>No rating opion on outlook exists.</summary>
    [IsoId("_kzzk8FAsEfCpNoeDQdjnVw")]
    [Description(@"No rating opion on outlook exists.")]
    public static readonly ExternalRatingOutlookCode NotMeaningful = new("NMEA");

    /// <summary>Rating may be raised by the rating agency.</summary>
    [IsoId("_hRWx4FAsEfCpNoeDQdjnVw")]
    [Description(@"Rating may be raised by the rating agency.")]
    public static readonly ExternalRatingOutlookCode Positive = new("PSTV");

    /// <summary>Rating is unlikely to change.</summary>
    [IsoId("_iWo-8FAsEfCpNoeDQdjnVw")]
    [Description(@"Rating is unlikely to change.")]
    public static readonly ExternalRatingOutlookCode Stable = new("STBL");
}
