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
[IsoId("_R0jr69p-Ed-ak6NoX_4Aeg_-2086984604")]
[DisplayName("Redemption Execution")]
public record RedemptionExecution6
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_R0jr7Np-Ed-ak6NoX_4Aeg_-2086984474")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_R0jr7dp-Ed-ak6NoX_4Aeg_-922500343")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_R0jr7tp-Ed-ak6NoX_4Aeg_-2086984431")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_R0jr79p-Ed-ak6NoX_4Aeg_568440444")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<FundOrderType3> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_R0jr8Np-Ed-ak6NoX_4Aeg_-2086059900")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    [IsoId("_R0tc4Np-Ed-ak6NoX_4Aeg_-432534180")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount1? SubAccountForHolding { get; init; }

    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    [IsoId("_R0tc4dp-Ed-ak6NoX_4Aeg_-2086983964")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_R0tc4tp-Ed-ak6NoX_4Aeg_-2086983656")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money paid to the investor as a result of the redemption after deduction of charges, commissions and taxes.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_R0tc49p-Ed-ak6NoX_4Aeg_-2086983638")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    [IsoId("_R0tc5Np-Ed-ak6NoX_4Aeg_-2086983578")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Amount of money resulting from the redemption before deduction of charges, commissions and taxes.|[Quantity * Price].
    /// </summary>
    [IsoId("_R0tc5dp-Ed-ak6NoX_4Aeg_-2086983543")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_R0tc5tp-Ed-ak6NoX_4Aeg_-2086983483")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_R0tc59p-Ed-ak6NoX_4Aeg_-1570275577")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required ActiveCurrencyAndAmount SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_R0tc6Np-Ed-ak6NoX_4Aeg_-1562890881")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_R03N4Np-Ed-ak6NoX_4Aeg_-1776296859")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_R03N4dp-Ed-ak6NoX_4Aeg_-2086983146")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_R03N4tp-Ed-ak6NoX_4Aeg_-2086060423")]
    [DisplayName("Dealing Price Details")]
    [IsoXmlTag("DealgPricDtls")]
    public required UnitPrice10 DealingPriceDetails { get; init; }

    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    [IsoId("_R03N49p-Ed-ak6NoX_4Aeg_857497209")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<UnitPrice10> InformativePriceDetails { get; init; } = [];

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("_R03N5Np-Ed-ak6NoX_4Aeg_-1420112961")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_R03N5dp-Ed-ak6NoX_4Aeg_-2086983051")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_R03N5tp-Ed-ak6NoX_4Aeg_-2086983034")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_R03N59p-Ed-ak6NoX_4Aeg_-2085139478")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms7> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_R03N6Np-Ed-ak6NoX_4Aeg_-2086062985")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_R1AX0Np-Ed-ak6NoX_4Aeg_-2086062925")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_R1AX0dp-Ed-ak6NoX_4Aeg_-2086060458")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges3? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_R1AX0tp-Ed-ak6NoX_4Aeg_-188093082")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_R1AX09p-Ed-ak6NoX_4Aeg_-1957922765")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions3? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_R1AX1Np-Ed-ak6NoX_4Aeg_-2086059563")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes3? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_R1AX1dp-Ed-ak6NoX_4Aeg_-2085138926")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_R1AX1tp-Ed-ak6NoX_4Aeg_-2086062812")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_R1AX19p-Ed-ak6NoX_4Aeg_-2086060969")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_R1AX2Np-Ed-ak6NoX_4Aeg_-2086062458")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_R1AX2dp-Ed-ak6NoX_4Aeg_-2086062072")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_R1KI0Np-Ed-ak6NoX_4Aeg_-2086060890")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction22? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_R1KI0dp-Ed-ak6NoX_4Aeg_-615141596")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    [IsoId("_R1KI0tp-Ed-ak6NoX_4Aeg_-1007387165")]
    [DisplayName("Partial Settlement Of Units")]
    [IsoXmlTag("PrtlSttlmOfUnits")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; }

    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    [IsoId("_R1KI09p-Ed-ak6NoX_4Aeg_-935349929")]
    [DisplayName("Partial Settlement Of Cash")]
    [IsoXmlTag("PrtlSttlmOfCsh")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialSettlementOfCash { get; init; }

    /// <summary>
    /// Amount retained by the Fund and paid out later at a time decided by the Fund.
    /// </summary>
    [IsoId("_R1KI1Np-Ed-ak6NoX_4Aeg_35464909")]
    [DisplayName("Partial Redemption Withholding Amount")]
    [IsoXmlTag("PrtlRedWhldgAmt")]
    public CurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; }

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_R1KI1dp-Ed-ak6NoX_4Aeg_-1994309542")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_R1KI1tp-Ed-ak6NoX_4Aeg_-1514186712")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("_R1T50Np-Ed-ak6NoX_4Aeg_604436405")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_R1T50dp-Ed-ak6NoX_4Aeg_484616181")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_R1T50tp-Ed-ak6NoX_4Aeg_751518465")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
