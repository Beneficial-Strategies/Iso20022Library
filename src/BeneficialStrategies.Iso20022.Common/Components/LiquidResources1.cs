// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resources of a legal entity or other financial construct that are available to meet cash obligations.
/// </summary>
[IsoId("_Ta5foLJQEeaYqc4G3TTwhA")]
[DisplayName("Liquid Resources")]
public partial record LiquidResources1
{
    #nullable enable
    
    /// <summary>
    /// Cash expected to be available to the CCP on each day in order to meet liquid requirements.
    /// </summary>
    [IsoId("_yq6uYESsEemM8-DVOYzdVQ")]
    [DisplayName("Cash Due")]
    [IsoXmlTag("CshDue")]
    public ValueList<LiquidResourceInformation1> CashDue { get; init; } = [];
    // ID for the above is _yq6uYESsEemM8-DVOYzdVQ
    
    /// <summary>
    /// Lines of credit with credit institutions that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_ADHekEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed Lines Of Credit")]
    [IsoXmlTag("FcltiesCmmtdLinesOfCdt")]
    public LiquidResourceInformation1? FacilitiesCommittedLinesOfCredit { get; init; } 
    
    /// <summary>
    /// Repurchase agreement that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_GH3PQEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed Repurchase Agreements")]
    [IsoXmlTag("FcltiesCmmtdRpAgrmts")]
    public LiquidResourceInformation1? FacilitiesCommittedRepurchaseAgreements { get; init; } 
    
    /// <summary>
    /// FX swaps that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_LR_KwEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed FX Swaps")]
    [IsoXmlTag("FcltiesCmmtdFxSwps")]
    public LiquidResourceInformation1? FacilitiesCommittedFXSwaps { get; init; } 
    
    /// <summary>
    /// Other liquidity facilities that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_RIdO4EStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Other Committed")]
    [IsoXmlTag("FcltiesOthrCmmtd")]
    public LiquidResourceInformation1? FacilitiesOtherCommitted { get; init; } 
    
    /// <summary>
    /// Liquidity facilities that are not contractually committed.
    /// </summary>
    [IsoId("_V9wJ4EStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Uncommitted")]
    [IsoXmlTag("FcltiesUcmmtd")]
    public LiquidResourceInformation1? FacilitiesUncommitted { get; init; } 
    
    /// <summary>
    /// CCPs own non cash resources.
    /// </summary>
    [IsoId("_bPLAMEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments CCP")]
    [IsoXmlTag("FinInstrmsCCP")]
    public LiquidResourceInformation1? FinancialInstrumentsCCP { get; init; } 
    
    /// <summary>
    /// Financial instruments from CCP treasury investments of clearing members cash collateral with any of the CCPs own cash invested included.
    /// </summary>
    [IsoId("_hQgQgEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Treasury Investments")]
    [IsoXmlTag("FinInstrmsTrsrInvstmts")]
    public LiquidResourceInformation1? FinancialInstrumentsTreasuryInvestments { get; init; } 
    
    /// <summary>
    /// Financial instruments due to be delivered to the defaulting member that post-default can be used to meet liquidity needs in the event of their default.
    /// </summary>
    [IsoId("_l39j0EStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Defaulters Settlement Collateral")]
    [IsoXmlTag("FinInstrmsDfltrsSttlmColl")]
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersSettlementCollateral { get; init; } 
    
    /// <summary>
    /// Non-cash collateral e.g. margin provided by the defaulting counterparty that can be used to meet liquidity needs in the event of their default.
    /// </summary>
    [IsoId("_qv8mcEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Defaulters Non Cash Collateral")]
    [IsoXmlTag("FinInstrmsDfltrsNonCshColl")]
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersNonCashCollateral { get; init; } 
    
    
    #nullable disable
    
}
