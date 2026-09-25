// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information related to the post trade of derivatives
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. Versioned restriction of <see cref="ExternalPostTradeCode"/> — a derivatives-specific subset of the base codeset's wire values; each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance. No length facet published by MCP for this codeset; Pattern kept at the conventional 1-4 character range observed across all published member codes.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_lWocoGh_EfCsrrIilHxTfw")]
[Description(@"Information related to the post trade of derivatives")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTrade2Code>))]
public readonly struct ExternalPostTrade2Code : IIsoExternalCode, IEquatable<ExternalPostTrade2Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTrade2Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTrade2Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTrade2Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTrade2Code"/>.</summary>
    public static implicit operator ExternalPostTrade2Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTrade2Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTrade2Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTrade2Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade2Code a, ExternalPostTrade2Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade2Code a, ExternalPostTrade2Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTrade2Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTrade2Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTrade2Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTrade2Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Publication of daily aggregated transaction</summary>
    [IsoId("_vJxxsWh_EfCsrrIilHxTfw")]
    [Description(@"Publication of daily aggregated transaction")]
    public static readonly ExternalPostTrade2Code DailyAggregatedTransactionFlag = new("DATF");

    /// <summary>Individual transactions for which aggregated details have been previously published</summary>
    [IsoId("_v17GAWh_EfCsrrIilHxTfw")]
    [Description(@"Individual transactions for which aggregated details have been previously published")]
    public static readonly ExternalPostTrade2Code FullDetailsFlagA = new("FULA");

    /// <summary>Transaction for which limited details have been previously published</summary>
    [IsoId("_umWUgWh_EfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details have been previously published")]
    public static readonly ExternalPostTrade2Code FullDetailsFlagF = new("FULF");

    /// <summary>Individual transactions which have previously benefited from aggregated publication.</summary>
    [IsoId("_x7xYMWh_EfCsrrIilHxTfw")]
    [Description(@"Individual transactions which have previously benefited from aggregated publication.")]
    public static readonly ExternalPostTrade2Code FullDetailsFlagJ = new("FULJ");

    /// <summary>Transaction for which limited details have been previously published</summary>
    [IsoId("_xkQ3IWh_EfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details have been previously published")]
    public static readonly ExternalPostTrade2Code FullDetailsFlagV = new("FULV");

    /// <summary>Publication of aggregated transactions.</summary>
    [IsoId("_ypojwWh_EfCsrrIilHxTfw")]
    [Description(@"Publication of aggregated transactions.")]
    public static readonly ExternalPostTrade2Code FourWeeksAggregationDerivativeFlag = new("FWAF");

    /// <summary>Transactions executed under the deferral for instruments for which there is not a liquid market</summary>
    [IsoId("_roYHgWh_EfCsrrIilHxTfw")]
    [Description(@"Transactions executed under the deferral for instruments for which there is not a liquid market")]
    public static readonly ExternalPostTrade2Code IlliquidInstrumentTransactionFlag = new("ILQD");

    /// <summary>First report with publication of limited details</summary>
    [IsoId("_t-JFAWh_EfCsrrIilHxTfw")]
    [Description(@"First report with publication of limited details")]
    public static readonly ExternalPostTrade2Code LimitedDetailsFlag = new("LMTF");

    /// <summary>Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.</summary>
    [IsoId("_qZ130Wh_EfCsrrIilHxTfw")]
    [Description(@"Transactions large in scale relative to normal market size, executed under a permitted post-trade deferral.")]
    public static readonly ExternalPostTrade2Code PostTradeLISTransactionFlag = new("LRGS");

    /// <summary>Transactions executed under the post-trade size specific to the instrument deferral</summary>
    [IsoId("_sOTfEWh_EfCsrrIilHxTfw")]
    [Description(@"Transactions executed under the post-trade size specific to the instrument deferral")]
    public static readonly ExternalPostTrade2Code PostTradeSSTITransactionFlag = new("SIZE");

    /// <summary>Transaction for which limited details are published.</summary>
    [IsoId("_wm7sMWh_EfCsrrIilHxTfw")]
    [Description(@"Transaction for which limited details are published.")]
    public static readonly ExternalPostTrade2Code VolumeOmissionDerivativeFlag = new("VOLO");
}
