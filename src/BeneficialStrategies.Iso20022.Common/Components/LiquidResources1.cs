// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resources of a legal entity or other financial construct that are available to meet cash obligations.
/// </summary>
[IsoId("_Ta5foLJQEeaYqc4G3TTwhA")]
[DisplayName("Liquid Resources")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidResources1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash expected to be available to the CCP on each day in order to meet liquid requirements.
    /// </summary>
    [IsoId("_yq6uYESsEemM8-DVOYzdVQ")]
    [DisplayName("Cash Due")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshDue")]
    #endif
    [IsoXmlTag("CshDue")]
    public ValueList<LiquidResourceInformation1> CashDue { get; init; } = new ValueList<LiquidResourceInformation1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _yq6uYESsEemM8-DVOYzdVQ
    
    /// <summary>
    /// Lines of credit with credit institutions that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_ADHekEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed Lines Of Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcltiesCmmtdLinesOfCdt")]
    #endif
    [IsoXmlTag("FcltiesCmmtdLinesOfCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FacilitiesCommittedLinesOfCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FacilitiesCommittedLinesOfCredit { get; init; } 
    #else
    public LiquidResourceInformation1? FacilitiesCommittedLinesOfCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase agreement that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_GH3PQEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed Repurchase Agreements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcltiesCmmtdRpAgrmts")]
    #endif
    [IsoXmlTag("FcltiesCmmtdRpAgrmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FacilitiesCommittedRepurchaseAgreements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FacilitiesCommittedRepurchaseAgreements { get; init; } 
    #else
    public LiquidResourceInformation1? FacilitiesCommittedRepurchaseAgreements { get; set; } 
    #endif
    
    /// <summary>
    /// FX swaps that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_LR_KwEStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Committed FX Swaps")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcltiesCmmtdFxSwps")]
    #endif
    [IsoXmlTag("FcltiesCmmtdFxSwps")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FacilitiesCommittedFXSwaps { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FacilitiesCommittedFXSwaps { get; init; } 
    #else
    public LiquidResourceInformation1? FacilitiesCommittedFXSwaps { get; set; } 
    #endif
    
    /// <summary>
    /// Other liquidity facilities that are contractually committed with the liquidity provider.
    /// </summary>
    [IsoId("_RIdO4EStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Other Committed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcltiesOthrCmmtd")]
    #endif
    [IsoXmlTag("FcltiesOthrCmmtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FacilitiesOtherCommitted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FacilitiesOtherCommitted { get; init; } 
    #else
    public LiquidResourceInformation1? FacilitiesOtherCommitted { get; set; } 
    #endif
    
    /// <summary>
    /// Liquidity facilities that are not contractually committed.
    /// </summary>
    [IsoId("_V9wJ4EStEemM8-DVOYzdVQ")]
    [DisplayName("Facilities Uncommitted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcltiesUcmmtd")]
    #endif
    [IsoXmlTag("FcltiesUcmmtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FacilitiesUncommitted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FacilitiesUncommitted { get; init; } 
    #else
    public LiquidResourceInformation1? FacilitiesUncommitted { get; set; } 
    #endif
    
    /// <summary>
    /// CCPs own non cash resources.
    /// </summary>
    [IsoId("_bPLAMEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmsCCP")]
    #endif
    [IsoXmlTag("FinInstrmsCCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FinancialInstrumentsCCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FinancialInstrumentsCCP { get; init; } 
    #else
    public LiquidResourceInformation1? FinancialInstrumentsCCP { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments from CCP treasury investments of clearing members cash collateral with any of the CCPs own cash invested included.
    /// </summary>
    [IsoId("_hQgQgEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Treasury Investments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmsTrsrInvstmts")]
    #endif
    [IsoXmlTag("FinInstrmsTrsrInvstmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FinancialInstrumentsTreasuryInvestments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FinancialInstrumentsTreasuryInvestments { get; init; } 
    #else
    public LiquidResourceInformation1? FinancialInstrumentsTreasuryInvestments { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments due to be delivered to the defaulting member that post-default can be used to meet liquidity needs in the event of their default.
    /// </summary>
    [IsoId("_l39j0EStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Defaulters Settlement Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmsDfltrsSttlmColl")]
    #endif
    [IsoXmlTag("FinInstrmsDfltrsSttlmColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersSettlementCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersSettlementCollateral { get; init; } 
    #else
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersSettlementCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Non-cash collateral e.g. margin provided by the defaulting counterparty that can be used to meet liquidity needs in the event of their default.
    /// </summary>
    [IsoId("_qv8mcEStEemM8-DVOYzdVQ")]
    [DisplayName("Financial Instruments Defaulters Non Cash Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmsDfltrsNonCshColl")]
    #endif
    [IsoXmlTag("FinInstrmsDfltrsNonCshColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersNonCashCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersNonCashCollateral { get; init; } 
    #else
    public LiquidResourceInformation1? FinancialInstrumentsDefaultersNonCashCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
