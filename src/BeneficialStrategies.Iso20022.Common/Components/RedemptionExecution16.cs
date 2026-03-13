// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("_E-YG1zbtEead9bDRE_1DAQ")]
[DisplayName("Redemption Execution")]
public partial record RedemptionExecution16
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_FXOEqTbtEead9bDRE_1DAQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_FXOEqzbtEead9bDRE_1DAQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_FXOErTbtEead9bDRE_1DAQ")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; } 
    
    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [IsoId("_FXOErzbtEead9bDRE_1DAQ")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_FXOEsTbtEead9bDRE_1DAQ")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson32? BeneficiaryDetails { get; init; } 
    
    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_FXOEszbtEead9bDRE_1DAQ")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber UnitsNumber { get; init; } 
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_FXOEtTbtEead9bDRE_1DAQ")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Amount of money paid to the investor when redeeming fund units. 
    /// Net amount = (Quantity * Price) – (Fees + Taxes).
    /// </summary>
    [IsoId("_FXOEtzbtEead9bDRE_1DAQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("_FXOEuTbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Portion of the investor&apos;s holdings redeemed.
    /// </summary>
    [IsoId("_FXOEuzbtEead9bDRE_1DAQ")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    
    /// <summary>
    /// Amount of money redeemed from the fund. 
    /// Gross Amount = Quantity * Price.
    /// </summary>
    [IsoId("_FXOEvTbtEead9bDRE_1DAQ")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; } 
    
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_FXOEvzbtEead9bDRE_1DAQ")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_FXOEwTbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_FXOEwzbtEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_FXOExTbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_FXOExzbtEead9bDRE_1DAQ")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice22 DealingPriceDetails { get; init; } 
    
    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("_FXOEyTbtEead9bDRE_1DAQ")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];
    
    /// <summary>
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_FXOEyzbtEead9bDRE_1DAQ")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    
    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_FXOEzTbtEead9bDRE_1DAQ")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; } 
    
    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_FXOEzzbtEead9bDRE_1DAQ")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_FXOE0TbtEead9bDRE_1DAQ")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; } 
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    [IsoId("_FXOE0zbtEead9bDRE_1DAQ")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_FXOE1TbtEead9bDRE_1DAQ")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_FXOE1zbtEead9bDRE_1DAQ")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    
    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction, so that the total difference between the net amount and gross amount is known, without taking into account equalisation.
    /// </summary>
    [IsoId("_MUqiQjk6EeapUO0vUIo9Xw")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes40? TransactionOverhead { get; init; } 
    
    /// <summary>
    /// Additional information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    [IsoId("_MUqiQzk6EeapUO0vUIo9Xw")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax1? InformativeTaxDetails { get; init; } 
    
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_FXOE3TbtEead9bDRE_1DAQ")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_FXOE4TbtEead9bDRE_1DAQ")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_FXOE4zbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("_FXOE5TbtEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_FXOE5zbtEead9bDRE_1DAQ")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction72? CashSettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_FXOE6TbtEead9bDRE_1DAQ")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("_FXOE6zbtEead9bDRE_1DAQ")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; } 
    
    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("_FXOE7TbtEead9bDRE_1DAQ")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; } 
    
    /// <summary>
    /// Amount retained by the fund and paid out later at a time decided by the fund.
    /// </summary>
    [IsoId("_FXOE7zbtEead9bDRE_1DAQ")]
    [DisplayName("Partial Redemption Withholding Amount")]
    [IsoXmlTag("PrtlRedWhldgAmt")]
    public ActiveCurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; } 
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_FXOE8TbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_FXOE8zbtEead9bDRE_1DAQ")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    
    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_FXOE9TbtEead9bDRE_1DAQ")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; } 
    
    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("_FXOE9zbtEead9bDRE_1DAQ")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary39> RelatedPartyDetails { get; init; } = [];
    
    /// <summary>
    /// Part of an investor&apos;s subscription amount that was held by the fund in order to pay incentive/performance fees at the end of the fiscal year, and is returned due to the redemption.
    /// </summary>
    [IsoId("_FXOE-TbtEead9bDRE_1DAQ")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; } 
    
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("_fCR9UTlNEeaYrqEUdbYZQQ")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("_1xEnMToCEeabspMEjqY5TQ")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    
    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_Wetv0ToIEeabspMEjqY5TQ")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; } 
    
    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("_qdSIkkgVEea9YuSvQGoi-w")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    
    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    [IsoId("_qdSIk0gVEea9YuSvQGoi-w")]
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation2? GatingOrHoldBackDetails { get; init; } 
    
    
    #nullable disable
    
}
