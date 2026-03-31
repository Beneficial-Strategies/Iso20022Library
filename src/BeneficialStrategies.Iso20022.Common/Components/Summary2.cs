// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary of a collateral valuation.
/// </summary>
[IsoId("_Vzn7ygLrEeutW5-TpeYJhA")]
[DisplayName("Summary")]
public record Summary2
{
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party A. That is, all transactions which would have an amount payable by party B to party A if they were being terminated.
    /// </summary>
    [IsoId("_Vzn70QLrEeutW5-TpeYJhA")]
    [DisplayName("Exposed Amount Party A")]
    [IsoXmlTag("XpsdAmtPtyA")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; }

    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party B. That is, all transactions which would have an amount payable by party A to party B if they were being terminated.
    /// </summary>
    [IsoId("_Vzn7zQLrEeutW5-TpeYJhA")]
    [DisplayName("Exposed Amount Party B")]
    [IsoXmlTag("XpsdAmtPtyB")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; }

    /// <summary>
    /// Underlying business area/type of trade that triggered the posting of collateral.
    /// </summary>
    [IsoId("_Vzn70wLrEeutW5-TpeYJhA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType8Code ExposureType { get; init; }

    /// <summary>
    /// Total value of the collateral (post-haircut) held by the exposed party.
    /// </summary>
    [IsoId("_Vzn7zwLrEeutW5-TpeYJhA")]
    [DisplayName("Total Value Of Collateral")]
    [IsoXmlTag("TtlValOfColl")]
    public required ActiveCurrencyAndAmount TotalValueOfCollateral { get; init; }

    /// <summary>
    /// Amount of collateral in excess or deficit compared to the exposure.
    /// </summary>
    [IsoId("_Vzn7ywLrEeutW5-TpeYJhA")]
    [DisplayName("Net Excess Deficit")]
    [IsoXmlTag("NetXcssDfcit")]
    public ActiveCurrencyAndAmount? NetExcessDeficit { get; init; }

    /// <summary>
    /// Indicates whether the collateral actually posted is a long or a short position.
    /// </summary>
    [IsoId("_Vzn70ALrEeutW5-TpeYJhA")]
    [DisplayName("Net Excess Deficit Indicator")]
    [IsoXmlTag("NetXcssDfcitInd")]
    public ShortLong1Code? NetExcessDeficitIndicator { get; init; }

    /// <summary>
    /// Date/time at which the collateral was valued.
    /// </summary>
    [IsoId("_Vzn7zALrEeutW5-TpeYJhA")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ValuationDateTime { get; init; }

    /// <summary>
    /// Date on which the instructing party requests settlement of the collateral to take place.
    /// </summary>
    [IsoId("_Vzn7zgLrEeutW5-TpeYJhA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Additional details on the valuation of the collateral that is posted.
    /// </summary>
    [IsoId("_Vzn70gLrEeutW5-TpeYJhA")]
    [DisplayName("Summary Details")]
    [IsoXmlTag("SummryDtls")]
    public SummaryAmounts2? SummaryDetails { get; init; }
}
