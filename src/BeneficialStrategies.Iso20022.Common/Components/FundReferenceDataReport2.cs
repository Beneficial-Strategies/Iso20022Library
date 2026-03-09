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
/// Fund reference data.
/// </summary>
[IsoId("_i_UpoZjqEemFhLAiyl29Fw")]
[DisplayName("Fund Reference Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundReferenceDataReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundReferenceDataReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundReferenceDataReport2( System.DateOnly reqGeneralReferenceDate,SecurityIdentification36 reqSecurityIdentification )
    {
        GeneralReferenceDate = reqGeneralReferenceDate;
        SecurityIdentification = reqSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a report within a fund reference data report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_jTGhRZjqEemFhLAiyl29Fw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Version Number. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00001 and is the version of the template for which the EMT data is provided. In EMT v1, this element is not supported.
    /// </summary>
    [IsoId("_jTGhR5jqEemFhLAiyl29Fw")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? Version { get; init; } 
    #else
    public MarketPracticeVersion1? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Date to which the data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00050. In EMT v1, this is known as the Reporting Date.
    /// </summary>
    [IsoId("_jTGhSZjqEemFhLAiyl29Fw")]
    [DisplayName("General Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlRefDt")]
    #endif
    [IsoXmlTag("GnlRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate GeneralReferenceDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly GeneralReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly GeneralReferenceDate { get; init; } 
    #else
    public System.DateOnly GeneralReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_jTGhS5jqEemFhLAiyl29Fw")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification36 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification36 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification36 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification36 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Parties related to the investment fund.
    /// </summary>
    [IsoId("_jTGhTZjqEemFhLAiyl29Fw")]
    [DisplayName("Fund Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndPties")]
    #endif
    [IsoXmlTag("FndPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundParties1? FundParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundParties1? FundParties { get; init; } 
    #else
    public FundParties1? FundParties { get; set; } 
    #endif
    
    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    [IsoId("_jTGhT5jqEemFhLAiyl29Fw")]
    [DisplayName("Main Fund Order Desk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainFndOrdrDsk")]
    #endif
    [IsoXmlTag("MainFndOrdrDsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrderDesk1? MainFundOrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderDesk1? MainFundOrderDesk { get; init; } 
    #else
    public OrderDesk1? MainFundOrderDesk { get; set; } 
    #endif
    
    /// <summary>
    /// Company that is responsible for the management and operation of the fund, for example, determines the investment strategy, appoints the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing of the fund. For self-managed funds, this will often be a separate promoter or sponsor of the fund.
    /// </summary>
    [IsoId("_jTGhUZjqEemFhLAiyl29Fw")]
    [DisplayName("Fund Management Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndMgmtCpny")]
    #endif
    [IsoXmlTag("FndMgmtCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? FundManagementCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? FundManagementCompany { get; init; } 
    #else
    public ContactAttributes5? FundManagementCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
    /// </summary>
    [IsoId("_jTGhU5jqEemFhLAiyl29Fw")]
    [DisplayName("Fund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndDtls")]
    #endif
    [IsoXmlTag("FndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument66? FundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument66? FundDetails { get; init; } 
    #else
    public FinancialInstrument66? FundDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, that is, not to the market.
    /// </summary>
    [IsoId("_jTGhVZjqEemFhLAiyl29Fw")]
    [DisplayName("Valuation Dealing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDealgChrtcs")]
    #endif
    [IsoXmlTag("ValtnDealgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; } 
    #else
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Investment restrictions linked to the trading of the investment fund or an alternative/hedge fund.
    /// </summary>
    [IsoId("_jTGhV5jqEemFhLAiyl29Fw")]
    [DisplayName("Investment Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtRstrctns")]
    #endif
    [IsoXmlTag("InvstmtRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; } 
    #else
    public InvestmentRestrictions3? InvestmentRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_jTGhWZjqEemFhLAiyl29Fw")]
    [DisplayName("Subscription Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPrcgChrtcs")]
    #endif
    [IsoXmlTag("SbcptPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics4? SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics4? SubscriptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics4? SubscriptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a redemption from the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_jTGhW5jqEemFhLAiyl29Fw")]
    [DisplayName("Redemption Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPrcgChrtcs")]
    #endif
    [IsoXmlTag("RedPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics7? RedemptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics7? RedemptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics7? RedemptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_jTGhXZjqEemFhLAiyl29Fw")]
    [DisplayName("Switch Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchPrcgChrtcs")]
    #endif
    [IsoXmlTag("SwtchPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics of the investment plan.
    /// </summary>
    [IsoId("_jTGhX5jqEemFhLAiyl29Fw")]
    [DisplayName("Plan Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlanChrtcs")]
    #endif
    [IsoXmlTag("PlanChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentPlanCharacteristics1? PlanCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentPlanCharacteristics1? PlanCharacteristics { get; init; } 
    #else
    public InvestmentPlanCharacteristics1? PlanCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies, for a specific type of transaction, how amounts are to be paid in or paid out.
    /// </summary>
    [IsoId("_jTGhYZjqEemFhLAiyl29Fw")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrm")]
    #endif
    [IsoXmlTag("PmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument16? PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument16? PaymentInstrument { get; init; } 
    #else
    public PaymentInstrument16? PaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    [IsoId("_jTGhY5jqEemFhLAiyl29Fw")]
    [DisplayName("Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlmDtls")]
    #endif
    [IsoXmlTag("CshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount202? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount202? CashSettlementDetails { get; init; } 
    #else
    public CashAccount202? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics specific to a local fund order desk.
    /// </summary>
    [IsoId("_jTGhZZjqEemFhLAiyl29Fw")]
    [DisplayName("Local Market Annex")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclMktAnx")]
    #endif
    [IsoXmlTag("LclMktAnx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalMarketAnnex3? LocalMarketAnnex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalMarketAnnex3? LocalMarketAnnex { get; init; } 
    #else
    public LocalMarketAnnex3? LocalMarketAnnex { get; set; } 
    #endif
    
    /// <summary>
    /// Target market criteria.
    /// </summary>
    [IsoId("_jTGhZ5jqEemFhLAiyl29Fw")]
    [DisplayName("Target Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtMkt")]
    #endif
    [IsoXmlTag("TrgtMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TargetMarket1? TargetMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TargetMarket1? TargetMarket { get; init; } 
    #else
    public TargetMarket1? TargetMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Distribution strategy criteria.
    /// </summary>
    [IsoId("_jTGhaZjqEemFhLAiyl29Fw")]
    [DisplayName("Distribution Strategy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnStrtgy")]
    #endif
    [IsoXmlTag("DstrbtnStrtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1? DistributionStrategy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1? DistributionStrategy { get; init; } 
    #else
    public DistributionStrategy1? DistributionStrategy { get; set; } 
    #endif
    
    /// <summary>
    /// Costs and charges associated with the distribution of selling of the financial instrument. These may be one-off or recurring. These may be ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_jTGha5jqEemFhLAiyl29Fw")]
    [DisplayName("Costs And Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CostsAndChrgs")]
    #endif
    [IsoXmlTag("CostsAndChrgs")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<CostsAndCharges1> CostsAndCharges { get; init; } = new ValueList<CostsAndCharges1>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTGhbZjqEemFhLAiyl29Fw")]
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
