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
/// Fund Processing Passsport (FPP) is a fully harmonised document with all key operational information that fund promoters should provide on their investment funds in order to facilitate their trading.
/// </summary>
[IsoId("_Q5ZrMtp-Ed-ak6NoX_4Aeg_1497334338")]
[DisplayName("Fund Processing Passport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundProcessingPassport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundProcessingPassport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundProcessingPassport1( UpdatedDate reqUpdatedDate,SecurityIdentification1 reqSecurityIdentification,ContactAttributes1 reqMainFundOrderDesk,ContactAttributes1 reqFundManagementCompany,FinancialInstrument20 reqFundDetails,ValuationDealingProcessingCharacteristics2 reqValuationDealingCharacteristics,InvestmentRestrictions2 reqInvestmentRestrictions,ProcessingCharacteristics2 reqSubscriptionProcessingCharacteristics,ProcessingCharacteristics3 reqRedemptionProcessingCharacteristics )
    {
        UpdatedDate = reqUpdatedDate;
        SecurityIdentification = reqSecurityIdentification;
        MainFundOrderDesk = reqMainFundOrderDesk;
        FundManagementCompany = reqFundManagementCompany;
        FundDetails = reqFundDetails;
        ValuationDealingCharacteristics = reqValuationDealingCharacteristics;
        InvestmentRestrictions = reqInvestmentRestrictions;
        SubscriptionProcessingCharacteristics = reqSubscriptionProcessingCharacteristics;
        RedemptionProcessingCharacteristics = reqRedemptionProcessingCharacteristics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of last revision.
    /// </summary>
    [IsoId("_Q5ZrM9p-Ed-ak6NoX_4Aeg_781465456")]
    [DisplayName("Updated Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdtdDt")]
    #endif
    [IsoXmlTag("UpdtdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UpdatedDate UpdatedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UpdatedDate UpdatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedDate UpdatedDate { get; init; } 
    #else
    public UpdatedDate UpdatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_Q5ZrNNp-Ed-ak6NoX_4Aeg_-501321207")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification1 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification1 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification1 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification1 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    [IsoId("_Q5ZrNdp-Ed-ak6NoX_4Aeg_-628195757")]
    [DisplayName("Main Fund Order Desk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainFndOrdrDsk")]
    #endif
    [IsoXmlTag("MainFndOrdrDsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactAttributes1 MainFundOrderDesk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactAttributes1 MainFundOrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes1 MainFundOrderDesk { get; init; } 
    #else
    public ContactAttributes1 MainFundOrderDesk { get; set; } 
    #endif
    
    /// <summary>
    /// Company that is responsible for the management and operation of the fund, eg, determines the investment strategy, appoints
    /// the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing
    /// of the fund. For self-managed funds, this wlll often be a separate promoter or sponsor of the fund.
    /// </summary>
    [IsoId("_Q5ZrNtp-Ed-ak6NoX_4Aeg_-1464343138")]
    [DisplayName("Fund Management Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndMgmtCpny")]
    #endif
    [IsoXmlTag("FndMgmtCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactAttributes1 FundManagementCompany { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactAttributes1 FundManagementCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes1 FundManagementCompany { get; init; } 
    #else
    public ContactAttributes1 FundManagementCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_Q5ZrN9p-Ed-ak6NoX_4Aeg_547053647")]
    [DisplayName("Fund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndDtls")]
    #endif
    [IsoXmlTag("FndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument20 FundDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument20 FundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument20 FundDetails { get; init; } 
    #else
    public FinancialInstrument20 FundDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrONp-Ed-ak6NoX_4Aeg_1029129650")]
    [DisplayName("Valuation Dealing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDealgChrtcs")]
    #endif
    [IsoXmlTag("ValtnDealgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationDealingProcessingCharacteristics2 ValuationDealingCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationDealingProcessingCharacteristics2 ValuationDealingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationDealingProcessingCharacteristics2 ValuationDealingCharacteristics { get; init; } 
    #else
    public ValuationDealingProcessingCharacteristics2 ValuationDealingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrOdp-Ed-ak6NoX_4Aeg_-477353454")]
    [DisplayName("Investment Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtRstrctns")]
    #endif
    [IsoXmlTag("InvstmtRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentRestrictions2 InvestmentRestrictions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentRestrictions2 InvestmentRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentRestrictions2 InvestmentRestrictions { get; init; } 
    #else
    public InvestmentRestrictions2 InvestmentRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5jcMNp-Ed-ak6NoX_4Aeg_269854257")]
    [DisplayName("Subscription Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPrcgChrtcs")]
    #endif
    [IsoXmlTag("SbcptPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5jcMdp-Ed-ak6NoX_4Aeg_2027637475")]
    [DisplayName("Redemption Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPrcgChrtcs")]
    #endif
    [IsoXmlTag("RedPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Q5jcMtp-Ed-ak6NoX_4Aeg_-1685996653")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    public ValueList<CashAccount22> SettlementDetails { get; init; } = new ValueList<CashAccount22>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Q5jcMtp-Ed-ak6NoX_4Aeg_-1685996653
    
    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [IsoId("_Q5jcM9p-Ed-ak6NoX_4Aeg_4177264")]
    [DisplayName("Local Market Annex")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclMktAnx")]
    #endif
    [IsoXmlTag("LclMktAnx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalMarketAnnex2? LocalMarketAnnex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalMarketAnnex2? LocalMarketAnnex { get; init; } 
    #else
    public LocalMarketAnnex2? LocalMarketAnnex { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Q5jcNNp-Ed-ak6NoX_4Aeg_113830738")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
