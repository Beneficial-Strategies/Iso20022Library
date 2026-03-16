// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_SHVd_9p-Ed-ak6NoX_4Aeg_-616427757")]
[DisplayName("Subscription Order")]
public record SubscriptionOrder6
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SHfO8Np-Ed-ak6NoX_4Aeg_-616427739")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SHfO8dp-Ed-ak6NoX_4Aeg_-1847805034")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SHfO8tp-Ed-ak6NoX_4Aeg_-316153076")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_SHfO89p-Ed-ak6NoX_4Aeg_-1269679915")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType2> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SHfO9Np-Ed-ak6NoX_4Aeg_-616426437")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    [IsoId("_SHfO9dp-Ed-ak6NoX_4Aeg_-650438811")]
    [DisplayName("Sub Account For Holding")]
    [IsoXmlTag("SubAcctForHldg")]
    public SubAccount1? SubAccountForHolding { get; init; }

    /// <summary>
    /// Quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SHfO9tp-Ed-ak6NoX_4Aeg_-616427265")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Amount of money to be invested in a specific financial instrument by an investor before deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[(Quantity * Price) + (Charges + Commissions +Taxes)].
    /// </summary>
    [IsoId("_SHfO99p-Ed-ak6NoX_4Aeg_-616426947")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public required ActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; }

    /// <summary>
    /// Amount of money remaining after deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[Quantity * Price].
    /// </summary>
    [IsoId("_SHfO-Np-Ed-ak6NoX_4Aeg_-616427248")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_SHoY4Np-Ed-ak6NoX_4Aeg_-616426982")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SHoY4dp-Ed-ak6NoX_4Aeg_-143133562")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SHoY4tp-Ed-ak6NoX_4Aeg_-143133477")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SHoY49p-Ed-ak6NoX_4Aeg_1601614599")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_SHoY5Np-Ed-ak6NoX_4Aeg_-616425990")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SHoY5dp-Ed-ak6NoX_4Aeg_-616426905")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_SHoY5tp-Ed-ak6NoX_4Aeg_-616426862")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_SHoY59p-Ed-ak6NoX_4Aeg_-616426845")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_SHoY6Np-Ed-ak6NoX_4Aeg_-616425913")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge17> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_SHoY6dp-Ed-ak6NoX_4Aeg_-1409413280")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SHyJ4Np-Ed-ak6NoX_4Aeg_139111860")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax16> TaxDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SHyJ4dp-Ed-ak6NoX_4Aeg_-616425955")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SHyJ4tp-Ed-ak6NoX_4Aeg_-616426827")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SHyJ49p-Ed-ak6NoX_4Aeg_-616426706")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SHyJ5Np-Ed-ak6NoX_4Aeg_-616426810")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SHyJ5dp-Ed-ak6NoX_4Aeg_-616426792")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SHyJ5tp-Ed-ak6NoX_4Aeg_339461342")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction23? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SHyJ59p-Ed-ak6NoX_4Aeg_262201483")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [IsoId("_SHyJ6Np-Ed-ak6NoX_4Aeg_-216657252")]
    [DisplayName("Staff Client Breakdown")]
    [IsoXmlTag("StffClntBrkdwn")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SHyJ6dp-Ed-ak6NoX_4Aeg_1337433714")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_SH764Np-Ed-ak6NoX_4Aeg_171239217")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_SH764dp-Ed-ak6NoX_4Aeg_-297883744")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SH764tp-Ed-ak6NoX_4Aeg_1148696985")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
