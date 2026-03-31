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
[IsoId("_VU0tpNp-Ed-ak6NoX_4Aeg_553787060")]
[DisplayName("Subscription Execution")]
public record SubscriptionExecution4
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VU0tpdp-Ed-ak6NoX_4Aeg_553787544")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VU0tptp-Ed-ak6NoX_4Aeg_553788103")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_VU0tp9p-Ed-ak6NoX_4Aeg_554712170")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType1> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_VU0tqNp-Ed-ak6NoX_4Aeg_565792841")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    [IsoId("_VU0tqdp-Ed-ak6NoX_4Aeg_553788163")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_VU0tqtp-Ed-ak6NoX_4Aeg_1042367480")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VU0tq9p-Ed-ak6NoX_4Aeg_553788553")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, including all charges, commissions, and tax, expressed in the currency requested by the investor.
    /// </summary>
    [IsoId("_VU-eoNp-Ed-ak6NoX_4Aeg_553789543")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_VU-eodp-Ed-ak6NoX_4Aeg_553790006")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    [IsoId("_VU-eotp-Ed-ak6NoX_4Aeg_566717335")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice5 PriceDetails { get; init; }

    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    [IsoId("_VU-eo9p-Ed-ak6NoX_4Aeg_554711187")]
    [DisplayName("Partially Executed Indicator")]
    [IsoXmlTag("PrtlyExctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_VU-epNp-Ed-ak6NoX_4Aeg_554711685")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    [IsoId("_VU-epdp-Ed-ak6NoX_4Aeg_554710643")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss1Choice_? InterimProfitAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VU-eptp-Ed-ak6NoX_4Aeg_556559608")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms4> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VU-ep9p-Ed-ak6NoX_4Aeg_553790534")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_VU-eqNp-Ed-ak6NoX_4Aeg_554711085")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_VU-eqdp-Ed-ak6NoX_4Aeg_554710738")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_VVHokNp-Ed-ak6NoX_4Aeg_555636570")]
    [DisplayName("Charge General Details")]
    [IsoXmlTag("ChrgGnlDtls")]
    public TotalCharges2? ChargeGeneralDetails { get; init; }

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_VVHokdp-Ed-ak6NoX_4Aeg_564871801")]
    [DisplayName("Commission General Details")]
    [IsoXmlTag("ComssnGnlDtls")]
    public TotalCommissions2? CommissionGeneralDetails { get; init; }

    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_VVHoktp-Ed-ak6NoX_4Aeg_555634260")]
    [DisplayName("Tax General Details")]
    [IsoXmlTag("TaxGnlDtls")]
    public TotalTaxes2? TaxGeneralDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VVHok9p-Ed-ak6NoX_4Aeg_564870230")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VVHolNp-Ed-ak6NoX_4Aeg_554712555")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VVHoldp-Ed-ak6NoX_4Aeg_566717923")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VVHoltp-Ed-ak6NoX_4Aeg_554711530")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VVHol9p-Ed-ak6NoX_4Aeg_554712040")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    [IsoId("_VVHomNp-Ed-ak6NoX_4Aeg_554712659")]
    [DisplayName("Refund")]
    [IsoXmlTag("Rfnd")]
    public ActiveCurrencyAndAmount? Refund { get; init; }

    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    [IsoId("_VVHomdp-Ed-ak6NoX_4Aeg_554712988")]
    [DisplayName("Subscription Interest")]
    [IsoXmlTag("SbcptIntrst")]
    public ActiveCurrencyAndAmount? SubscriptionInterest { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VVRZkNp-Ed-ak6NoX_4Aeg_556558190")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction13? CashSettlementDetails { get; init; }
}
