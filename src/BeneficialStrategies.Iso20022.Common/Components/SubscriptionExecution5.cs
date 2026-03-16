// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("_R4lQS9p-Ed-ak6NoX_4Aeg_-1411999859")]
[DisplayName("Subscription Execution")]
public record SubscriptionExecution5
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_R4lQTNp-Ed-ak6NoX_4Aeg_-1411077871")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_R4lQTdp-Ed-ak6NoX_4Aeg_1016626168")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_R4lQTtp-Ed-ak6NoX_4Aeg_-1411075388")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_R4lQT9p-Ed-ak6NoX_4Aeg_713435160")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType3> OrderType { get; init; } = [];

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_R4vBQNp-Ed-ak6NoX_4Aeg_1142117958")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_R4vBQdp-Ed-ak6NoX_4Aeg_-1398148015")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson12? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_R4vBQtp-Ed-ak6NoX_4Aeg_-1410154675")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_R4vBQ9p-Ed-ak6NoX_4Aeg_-1409230257")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, after deduction of charges, commissions and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_R4vBRNp-Ed-ak6NoX_4Aeg_-1408307322")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, before deduction of charges, commissions, and taxes.|[(Quantity * Price) + (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_R4vBRdp-Ed-ak6NoX_4Aeg_-1408305804")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_R4vBRtp-Ed-ak6NoX_4Aeg_-1408305151")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_R4vBR9p-Ed-ak6NoX_4Aeg_-1397225476")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice10 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("_R4vBSNp-Ed-ak6NoX_4Aeg_-748773008")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<UnitPrice10> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_R4vBSdp-Ed-ak6NoX_4Aeg_1689484406")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_R44yQNp-Ed-ak6NoX_4Aeg_1689484821")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_R44yQdp-Ed-ak6NoX_4Aeg_2031976421")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_R44yQtp-Ed-ak6NoX_4Aeg_-1407384514")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_R44yQ9p-Ed-ak6NoX_4Aeg_1837741215")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_R44yRNp-Ed-ak6NoX_4Aeg_-1407383566")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_R44yRdp-Ed-ak6NoX_4Aeg_-1407382826")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_R44yRtp-Ed-ak6NoX_4Aeg_-1386141349")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms7> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_R44yR9p-Ed-ak6NoX_4Aeg_-1407382334")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_R44ySNp-Ed-ak6NoX_4Aeg_-1407382299")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_R44ySdp-Ed-ak6NoX_4Aeg_-1407381879")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_R5B8MNp-Ed-ak6NoX_4Aeg_1526192386")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions3? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_R5B8Mdp-Ed-ak6NoX_4Aeg_806352392")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges3? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_R5B8Mtp-Ed-ak6NoX_4Aeg_262268328")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes3? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_R5B8M9p-Ed-ak6NoX_4Aeg_-1395378974")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the securities are to be physically delivered.
    /// </summary>
    [IsoId("_R5B8NNp-Ed-ak6NoX_4Aeg_-1407381351")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_R5B8Ndp-Ed-ak6NoX_4Aeg_-1396301550")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_R5B8Ntp-Ed-ak6NoX_4Aeg_771511099")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("_R5B8N9p-Ed-ak6NoX_4Aeg_-1406461069")]
    [DisplayName("Refund")]
    [IsoXmlTag("Rfnd")]
    public ActiveCurrencyAndAmount? Refund { get; init; }

    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    [IsoId("_R5B8ONp-Ed-ak6NoX_4Aeg_-1406460329")]
    [DisplayName("Subscription Interest")]
    [IsoXmlTag("SbcptIntrst")]
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_R5B8Odp-Ed-ak6NoX_4Aeg_-1406458296")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction24? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_R5LtMNp-Ed-ak6NoX_4Aeg_-100739106")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("_R5LtMdp-Ed-ak6NoX_4Aeg_-379063892")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_R5LtMtp-Ed-ak6NoX_4Aeg_1835212918")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_R5LtM9p-Ed-ak6NoX_4Aeg_-308988927")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_R5LtNNp-Ed-ak6NoX_4Aeg_586887639")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("_R5LtNdp-Ed-ak6NoX_4Aeg_-379063609")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_R5LtNtp-Ed-ak6NoX_4Aeg_151804394")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_R5LtN9p-Ed-ak6NoX_4Aeg_661078240")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
