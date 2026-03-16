// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption Execution17.
/// </summary>
[IsoId("_o3aFkxwCEe6fEumgV5aG_A")]
[DisplayName("Redemption Execution17")]
public partial record RedemptionExecution17
{
    #nullable enable

    /// <summary>
    /// Best Execution.
    /// </summary>
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; } 

    /// <summary>
    /// Cash Settlement Date.
    /// </summary>
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; } 

    /// <summary>
    /// Cash Settlement Details.
    /// </summary>
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction151? CashSettlementDetails { get; init; } 

    /// <summary>
    /// Client Reference.
    /// </summary>
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; } 

    /// <summary>
    /// Cum Dividend Indicator.
    /// </summary>
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 

    /// <summary>
    /// Customer Conduct Classification.
    /// </summary>
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 

    /// <summary>
    /// Dealing Price Details.
    /// </summary>
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; } 

    /// <summary>
    /// Deal Reference.
    /// </summary>
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; } 

    /// <summary>
    /// Equalisation.
    /// </summary>
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation3? Equalisation { get; init; } 

    /// <summary>
    /// Financial Advice.
    /// </summary>
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 

    /// <summary>
    /// Financial Instrument Details.
    /// </summary>
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Gating Or Hold Back Details.
    /// </summary>
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation2? GatingOrHoldBackDetails { get; init; } 

    /// <summary>
    /// Gross Amount.
    /// </summary>
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; } 

    /// <summary>
    /// Group1Or2Units.
    /// </summary>
    [DisplayName("Group1Or2Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 

    /// <summary>
    /// Holdings Redemption Rate.
    /// </summary>
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 

    /// <summary>
    /// Income Preference.
    /// </summary>
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 

    /// <summary>
    /// Informative Price Details.
    /// </summary>
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public UnitPrice22? InformativePriceDetails { get; init; } 

    /// <summary>
    /// Informative Tax Details.
    /// </summary>
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; } 

    /// <summary>
    /// Interim Profit Amount.
    /// </summary>
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; } 

    /// <summary>
    /// Late Report.
    /// </summary>
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; } 

    /// <summary>
    /// Negotiated Trade.
    /// </summary>
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 

    /// <summary>
    /// Net Amount.
    /// </summary>
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 

    /// <summary>
    /// Non Standard Settlement Information.
    /// </summary>
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 

    /// <summary>
    /// Order Reference.
    /// </summary>
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; } 

    /// <summary>
    /// Order Type.
    /// </summary>
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public FundOrderType4Choice_? OrderType { get; init; } 

    /// <summary>
    /// Order Waiver Details.
    /// </summary>
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; } 

    /// <summary>
    /// Partially Executed Indicator.
    /// </summary>
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 

    /// <summary>
    /// Partial Redemption Withholding Amount.
    /// </summary>
    [DisplayName("Partial Redemption Withholding Amount")]
    [IsoXmlTag("PrtlRedWhldgAmt")]
    public ActiveCurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; } 

    /// <summary>
    /// Partial Settlement Of Cash.
    /// </summary>
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; } 

    /// <summary>
    /// Partial Settlement Of Units.
    /// </summary>
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; } 

    /// <summary>
    /// Physical Delivery Details.
    /// </summary>
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 

    /// <summary>
    /// Physical Delivery Indicator.
    /// </summary>
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 

    /// <summary>
    /// Related Party Details.
    /// </summary>
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public Intermediary49? RelatedPartyDetails { get; init; } 

    /// <summary>
    /// Requested NAV Currency.
    /// </summary>
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 

    /// <summary>
    /// Requested Settlement Currency.
    /// </summary>
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 

    /// <summary>
    /// Rounding.
    /// </summary>
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; } 

    /// <summary>
    /// Settlement And Custody Details.
    /// </summary>
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters19? SettlementAndCustodyDetails { get; init; } 

    /// <summary>
    /// Settlement Method.
    /// </summary>
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 

    /// <summary>
    /// Signature Type.
    /// </summary>
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; } 

    /// <summary>
    /// Staff Client Breakdown.
    /// </summary>
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    public InvestmentFundsOrderBreakdown2? StaffClientBreakdown { get; init; } 

    /// <summary>
    /// Sub Account For Holding.
    /// </summary>
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount6? SubAccountForHolding { get; init; } 

    /// <summary>
    /// Trade Date Time.
    /// </summary>
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice_ TradeDateTime { get; init; } 

    /// <summary>
    /// Transaction Channel Type.
    /// </summary>
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 

    /// <summary>
    /// Transaction Overhead.
    /// </summary>
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes42? TransactionOverhead { get; init; } 

    /// <summary>
    /// Units Number.
    /// </summary>
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required IsoDecimalNumber UnitsNumber { get; init; } 

    
    #nullable disable
    
}
