// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund reference data.
/// </summary>
[IsoId("_XBCccc0SEeuAE-cYsQdwHQ")]
[DisplayName("Fund Reference Data Report")]
public partial record FundReferenceDataReport4
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a report within a fund reference data report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_XXi39c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Version Number. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00001 and is the version of the template for which the EMT data is provided.
    /// </summary>
    [IsoId("_XXi3980SEeuAE-cYsQdwHQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public MarketPracticeVersion1? Version { get; init; } 
    
    /// <summary>
    /// Party that reports the data on behalf of the issuer and the entry point e-mail address for contact. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) references 00002, 00003 and 00004.
    /// </summary>
    [IsoId("_XXi3-c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Authorised Proxy")]
    [IsoXmlTag("AuthrsdPrxy")]
    public ContactAttributes6? AuthorisedProxy { get; init; } 
    
    /// <summary>
    /// Date to which the data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00050. 
    /// </summary>
    [IsoId("_XXi3-80SEeuAE-cYsQdwHQ")]
    [DisplayName("General Reference Date")]
    [IsoXmlTag("GnlRefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate GeneralReferenceDate { get; init; } 
    
    /// <summary>
    /// Indicates whether target market data is included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00006.
    /// </summary>
    [IsoId("_XXi3_c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Target Market Indicator")]
    [IsoXmlTag("TrgtMktInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TargetMarketIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether ex ante costs and charges are included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00007.
    /// </summary>
    [IsoId("_XXi3_80SEeuAE-cYsQdwHQ")]
    [DisplayName("Ex Ante Indicator")]
    [IsoXmlTag("ExAnteInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExAnteIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether ex post costs and charges are included in the report. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00008.
    /// </summary>
    [IsoId("_XXi4Ac0SEeuAE-cYsQdwHQ")]
    [DisplayName("Ex Post Indicator")]
    [IsoXmlTag("ExPstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExPostIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_XXi4A80SEeuAE-cYsQdwHQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification41 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Parties related to the investment fund.
    /// </summary>
    [IsoId("_XXi4Bc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Fund Parties")]
    [IsoXmlTag("FndPties")]
    public FundParties1? FundParties { get; init; } 
    
    /// <summary>
    /// Principal entity appointed by the fund, to which orders should be submitted. Usually located in the country of domicile.
    /// </summary>
    [IsoId("_XXi4B80SEeuAE-cYsQdwHQ")]
    [DisplayName("Main Fund Order Desk")]
    [IsoXmlTag("MainFndOrdrDsk")]
    public OrderDesk1? MainFundOrderDesk { get; init; } 
    
    /// <summary>
    /// Company that is responsible for the management and operation of the fund, for example, determines the investment strategy, appoints the service providers, and makes major decisions for the fund. It is usually responsible for the distribution and marketing of the fund. For self-managed funds, this will often be a separate promoter or sponsor of the fund.
    /// </summary>
    [IsoId("_XXi4Cc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public ContactAttributes5? FundManagementCompany { get; init; } 
    
    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
    /// </summary>
    [IsoId("_XXi4C80SEeuAE-cYsQdwHQ")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public FinancialInstrument96? FundDetails { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to the instrument, that is, not to the market.
    /// </summary>
    [IsoId("_XXi4Dc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Valuation Dealing Characteristics")]
    [IsoXmlTag("ValtnDealgChrtcs")]
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; } 
    
    /// <summary>
    /// Investment restrictions linked to the trading of the investment fund or an alternative/hedge fund.
    /// </summary>
    [IsoId("_XXi4D80SEeuAE-cYsQdwHQ")]
    [DisplayName("Investment Restrictions")]
    [IsoXmlTag("InvstmtRstrctns")]
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_XXi4Ec0SEeuAE-cYsQdwHQ")]
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to a redemption from the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_XXi4E80SEeuAE-cYsQdwHQ")]
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public ProcessingCharacteristics7? RedemptionProcessingCharacteristics { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_XXi4Fc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Switch Processing Characteristics")]
    [IsoXmlTag("SwtchPrcgChrtcs")]
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    
    /// <summary>
    /// Characteristics of the investment plan.
    /// </summary>
    [IsoId("_XXi4F80SEeuAE-cYsQdwHQ")]
    [DisplayName("Plan Characteristics")]
    [IsoXmlTag("PlanChrtcs")]
    public InvestmentPlanCharacteristics1? PlanCharacteristics { get; init; } 
    
    /// <summary>
    /// Specifies, for a specific type of transaction, how amounts are to be paid in or paid out.
    /// </summary>
    [IsoId("_XXi4Gc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public PaymentInstrument16? PaymentInstrument { get; init; } 
    
    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    [IsoId("_XXi4G80SEeuAE-cYsQdwHQ")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public CashAccount205? CashSettlementDetails { get; init; } 
    
    /// <summary>
    /// Processing characteristics specific to a local fund order desk.
    /// </summary>
    [IsoId("_XXi4Hc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Local Market Annex")]
    [IsoXmlTag("LclMktAnx")]
    public LocalMarketAnnex5? LocalMarketAnnex { get; init; } 
    
    /// <summary>
    /// Target market criteria.
    /// </summary>
    [IsoId("_XXi4H80SEeuAE-cYsQdwHQ")]
    [DisplayName("Target Market")]
    [IsoXmlTag("TrgtMkt")]
    public TargetMarket3? TargetMarket { get; init; } 
    
    /// <summary>
    /// Distribution strategy criteria.
    /// </summary>
    [IsoId("_XXi4Ic0SEeuAE-cYsQdwHQ")]
    [DisplayName("Distribution Strategy")]
    [IsoXmlTag("DstrbtnStrtgy")]
    public DistributionStrategy1? DistributionStrategy { get; init; } 
    
    /// <summary>
    /// Costs and charges associated with the distribution of selling of the financial instrument. These may be one-off or recurring. These may be ex ante (intended) or post ante (actual).
    /// </summary>
    [IsoId("_XXi4I80SEeuAE-cYsQdwHQ")]
    [DisplayName("Costs And Charges")]
    [IsoXmlTag("CostsAndChrgs")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<CostsAndCharges2> CostsAndCharges { get; init; } = [];
    
    /// <summary>
    /// Additional information required for distribution in the German market.
    /// </summary>
    [IsoId("_90tlYM2qEeuAE-cYsQdwHQ")]
    [DisplayName("Additional Product Information German Market")]
    [IsoXmlTag("AddtlPdctInfGrmnMkt")]
    public AdditionalProductInformation1? AdditionalProductInformationGermanMarket { get; init; } 
    
    /// <summary>
    /// Additional information required for distribution in the French market.
    /// </summary>
    [IsoId("_03u2ws2_EeuAE-cYsQdwHQ")]
    [DisplayName("Additional Product Information French Market")]
    [IsoXmlTag("AddtlPdctInfFrnchMkt")]
    public AdditionalProductInformation2? AdditionalProductInformationFrenchMarket { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XXi4Jc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
