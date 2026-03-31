// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("_R1T53Np-Ed-ak6NoX_4Aeg_-1398412300")]
[DisplayName("Redemption Execution")]
public record RedemptionExecution5
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_R1T53dp-Ed-ak6NoX_4Aeg_-1397490872")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_R1T53tp-Ed-ak6NoX_4Aeg_1705778445")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_R1dDwNp-Ed-ak6NoX_4Aeg_-1397490812")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_R1dDwdp-Ed-ak6NoX_4Aeg_579525993")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType3> OrderType { get; init; } = [];

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_R1dDwtp-Ed-ak6NoX_4Aeg_-1387330905")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson12? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_R1dDw9p-Ed-ak6NoX_4Aeg_-1397489881")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_R1dDxNp-Ed-ak6NoX_4Aeg_-1397489683")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money paid to the investor as a result of the redemption after deduction of charges, commissions and taxes.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_R1dDxdp-Ed-ak6NoX_4Aeg_-1397488968")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_R1dDxtp-Ed-ak6NoX_4Aeg_-1133159760")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_R1dDx9p-Ed-ak6NoX_4Aeg_-1397488951")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Amount of money resulting from the redemption before deduction of charges, commissions and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_R1dDyNp-Ed-ak6NoX_4Aeg_-1397488346")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_R1dDydp-Ed-ak6NoX_4Aeg_-1396567186")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_R1m0wNp-Ed-ak6NoX_4Aeg_731730936")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_R1m0wdp-Ed-ak6NoX_4Aeg_731731006")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_R1m0wtp-Ed-ak6NoX_4Aeg_1037076951")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_R1m0w9p-Ed-ak6NoX_4Aeg_-1382713329")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice10 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("_R1m0xNp-Ed-ak6NoX_4Aeg_-1487715055")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<UnitPrice10> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_R1m0xdp-Ed-ak6NoX_4Aeg_-1396566144")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_R1m0xtp-Ed-ak6NoX_4Aeg_-1666691887")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_R1m0x9p-Ed-ak6NoX_4Aeg_-1396564918")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_R1m0yNp-Ed-ak6NoX_4Aeg_-1395644637")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_R1m0ydp-Ed-ak6NoX_4Aeg_-1383636556")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms7> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_R1v-sNp-Ed-ak6NoX_4Aeg_-1395644265")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_R1v-sdp-Ed-ak6NoX_4Aeg_-1395643689")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_R1v-stp-Ed-ak6NoX_4Aeg_199269673")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges3? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_R1v-s9p-Ed-ak6NoX_4Aeg_-1427822143")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions3? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_R1v-tNp-Ed-ak6NoX_4Aeg_-541799859")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_R1v-tdp-Ed-ak6NoX_4Aeg_-521472740")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes3? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_R1v-ttp-Ed-ak6NoX_4Aeg_-1381791899")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_R1v-t9p-Ed-ak6NoX_4Aeg_-1395643222")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_R1v-uNp-Ed-ak6NoX_4Aeg_-1384559640")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_R15vsNp-Ed-ak6NoX_4Aeg_1774547967")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction22? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_R15vsdp-Ed-ak6NoX_4Aeg_-538489271")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("_R15vstp-Ed-ak6NoX_4Aeg_-504662779")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("_R15vs9p-Ed-ak6NoX_4Aeg_-504662762")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Amount retained by the Fund and paid out later at a time decided by the Fund.
    /// </summary>
    [IsoId("_R15vtNp-Ed-ak6NoX_4Aeg_-1453516188")]
    [DisplayName("Partial Redemption Withholding Amount")]
    [IsoXmlTag("PrtlRedWhldgAmt")]
    public CurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; }

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_R15vtdp-Ed-ak6NoX_4Aeg_949555701")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_R15vttp-Ed-ak6NoX_4Aeg_1849874342")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_R15vt9p-Ed-ak6NoX_4Aeg_631217565")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_R15vuNp-Ed-ak6NoX_4Aeg_-469444964")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_R15vudp-Ed-ak6NoX_4Aeg_763524591")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
