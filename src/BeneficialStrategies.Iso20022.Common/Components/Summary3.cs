// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary of a collateral valuation.
/// </summary>
[IsoId("_0AdHJygtEeyB747fKu7_rw")]
[DisplayName("Summary")]
public partial record Summary3
{
    #nullable enable
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party A. That is, all transactions which would have an amount payable by party B to party A if they were being terminated.
    /// </summary>
    [IsoId("_0Yl6USgtEeyB747fKu7_rw")]
    [DisplayName("Exposed Amount Party A")]
    [IsoXmlTag("XpsdAmtPtyA")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; } 
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party B. That is, all transactions which would have an amount payable by party A to party B if they were being terminated.
    /// </summary>
    [IsoId("_0Yl6UygtEeyB747fKu7_rw")]
    [DisplayName("Exposed Amount Party B")]
    [IsoXmlTag("XpsdAmtPtyB")]
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; } 
    
    /// <summary>
    /// Underlying business area/type of trade that triggered the posting of collateral.
    /// </summary>
    [IsoId("_0Yl6VSgtEeyB747fKu7_rw")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType13Code ExposureType { get; init; } 
    
    /// <summary>
    /// Total value of the collateral (post-haircut) held by the exposed party.
    /// </summary>
    [IsoId("_0Yl6VygtEeyB747fKu7_rw")]
    [DisplayName("Total Value Of Collateral")]
    [IsoXmlTag("TtlValOfColl")]
    public required ActiveCurrencyAndAmount TotalValueOfCollateral { get; init; } 
    
    /// <summary>
    /// Amount of collateral in excess or deficit compared to the exposure.
    /// </summary>
    [IsoId("_0Yl6WSgtEeyB747fKu7_rw")]
    [DisplayName("Net Excess Deficit")]
    [IsoXmlTag("NetXcssDfcit")]
    public ActiveCurrencyAndAmount? NetExcessDeficit { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral actually posted is a long or a short position.
    /// </summary>
    [IsoId("_0Yl6WygtEeyB747fKu7_rw")]
    [DisplayName("Net Excess Deficit Indicator")]
    [IsoXmlTag("NetXcssDfcitInd")]
    public ShortLong1Code? NetExcessDeficitIndicator { get; init; } 
    
    /// <summary>
    /// Date/time at which the collateral was valued.
    /// </summary>
    [IsoId("_0Yl6XSgtEeyB747fKu7_rw")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ValuationDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the instructing party requests settlement of the collateral to take place.
    /// </summary>
    [IsoId("_0Yl6XygtEeyB747fKu7_rw")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Additional details on the valuation of the collateral that is posted.
    /// </summary>
    [IsoId("_0Yl6YSgtEeyB747fKu7_rw")]
    [DisplayName("Summary Details")]
    [IsoXmlTag("SummryDtls")]
    public SummaryAmounts2? SummaryDetails { get; init; } 
    
    
    #nullable disable
    
}
