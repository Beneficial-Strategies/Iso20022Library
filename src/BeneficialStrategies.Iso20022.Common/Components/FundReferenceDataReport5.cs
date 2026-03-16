// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund Reference Data Report5.
/// </summary>
[IsoId("_qpqxcMQXEe2pvZQ_33Qz1Q")]
[DisplayName("Fund Reference Data Report5")]
public partial record FundReferenceDataReport5
{
    #nullable enable

    /// <summary>
    /// Additional Information UK Market.
    /// </summary>
    [DisplayName("Additional Information UK Market")]
    [IsoXmlTag("AddtlInfUKMkt")]
    public AdditionalProductInformation3? AdditionalInformationUKMarket { get; init; } 

    /// <summary>
    /// Authorised Proxy.
    /// </summary>
    [DisplayName("Authorised Proxy")]
    [IsoXmlTag("AuthrsdPrxy")]
    public ContactAttributes6? AuthorisedProxy { get; init; } 

    /// <summary>
    /// Cash Settlement Details.
    /// </summary>
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public ValueList<CashAccount205> CashSettlementDetails { get; init; } = [];

    /// <summary>
    /// Costs And Charges.
    /// </summary>
    [DisplayName("Costs And Charges")]
    [IsoXmlTag("CostsAndChrgs")]
    public CostsAndCharges2? CostsAndCharges { get; init; } 

    /// <summary>
    /// Distribution Strategy.
    /// </summary>
    [DisplayName("Distribution Strategy")]
    [IsoXmlTag("DstrbtnStrtgy")]
    public DistributionStrategy1? DistributionStrategy { get; init; } 

    /// <summary>
    /// Ex Ante Indicator.
    /// </summary>
    [DisplayName("Ex Ante Indicator")]
    [IsoXmlTag("ExAnteInd")]
    public IsoYesNoIndicator? ExAnteIndicator { get; init; } 

    /// <summary>
    /// Ex Post Indicator.
    /// </summary>
    [DisplayName("Ex Post Indicator")]
    [IsoXmlTag("ExPstInd")]
    public IsoYesNoIndicator? ExPostIndicator { get; init; } 

    /// <summary>
    /// Extension.
    /// </summary>
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];

    /// <summary>
    /// Fund Details.
    /// </summary>
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public FinancialInstrument96? FundDetails { get; init; } 

    /// <summary>
    /// Fund Management Company.
    /// </summary>
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public ContactAttributes5? FundManagementCompany { get; init; } 

    /// <summary>
    /// Fund Parties.
    /// </summary>
    [DisplayName("Fund Parties")]
    [IsoXmlTag("FndPties")]
    public FundParties1? FundParties { get; init; } 

    /// <summary>
    /// General Reference Date.
    /// </summary>
    [DisplayName("General Reference Date")]
    [IsoXmlTag("GnlRefDt")]
    public required IsoISODate GeneralReferenceDate { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; } 

    /// <summary>
    /// Investment Restrictions.
    /// </summary>
    [DisplayName("Investment Restrictions")]
    [IsoXmlTag("InvstmtRstrctns")]
    public InvestmentRestrictions3? InvestmentRestrictions { get; init; } 

    /// <summary>
    /// Local Market Annex.
    /// </summary>
    [DisplayName("Local Market Annex")]
    [IsoXmlTag("LclMktAnx")]
    public ValueList<LocalMarketAnnex6> LocalMarketAnnex { get; init; } = [];

    /// <summary>
    /// Main Fund Order Desk.
    /// </summary>
    [DisplayName("Main Fund Order Desk")]
    [IsoXmlTag("MainFndOrdrDsk")]
    public OrderDesk1? MainFundOrderDesk { get; init; } 

    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public ValueList<PaymentInstrument16> PaymentInstrument { get; init; } = [];

    /// <summary>
    /// Plan Characteristics.
    /// </summary>
    [DisplayName("Plan Characteristics")]
    [IsoXmlTag("PlanChrtcs")]
    public ValueList<InvestmentPlanCharacteristics1> PlanCharacteristics { get; init; } = [];

    /// <summary>
    /// Redemption Processing Characteristics.
    /// </summary>
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public ProcessingCharacteristics12? RedemptionProcessingCharacteristics { get; init; } 

    /// <summary>
    /// Security Identification.
    /// </summary>
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification47 SecurityIdentification { get; init; } 

    /// <summary>
    /// Subscription Processing Characteristics.
    /// </summary>
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public ProcessingCharacteristics11? SubscriptionProcessingCharacteristics { get; init; } 

    /// <summary>
    /// Switch Processing Characteristics.
    /// </summary>
    [DisplayName("Switch Processing Characteristics")]
    [IsoXmlTag("SwtchPrcgChrtcs")]
    public ProcessingCharacteristics9? SwitchProcessingCharacteristics { get; init; } 

    /// <summary>
    /// Target Market.
    /// </summary>
    [DisplayName("Target Market")]
    [IsoXmlTag("TrgtMkt")]
    public TargetMarket4? TargetMarket { get; init; } 

    /// <summary>
    /// Target Market Indicator.
    /// </summary>
    [DisplayName("Target Market Indicator")]
    [IsoXmlTag("TrgtMktInd")]
    public IsoYesNoIndicator? TargetMarketIndicator { get; init; } 

    /// <summary>
    /// Valuation Dealing Characteristics.
    /// </summary>
    [DisplayName("Valuation Dealing Characteristics")]
    [IsoXmlTag("ValtnDealgChrtcs")]
    public ValuationDealingProcessingCharacteristics3? ValuationDealingCharacteristics { get; init; } 

    /// <summary>
    /// Value For Money.
    /// </summary>
    [DisplayName("Value For Money")]
    [IsoXmlTag("ValForMny")]
    public ValueForMoney1? ValueForMoney { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public MarketPracticeVersion1? Version { get; init; } 

    
    #nullable disable
    
}
