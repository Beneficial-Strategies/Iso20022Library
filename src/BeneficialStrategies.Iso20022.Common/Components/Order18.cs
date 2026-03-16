// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_jMAsgTAjEeOUGqA1wUwNLA")]
[DisplayName("Order")]
public record Order18
{
    /// <summary>
    /// Specifies the type of business process.
    /// </summary>
    [IsoId("_jkHDeTAjEeOUGqA1wUwNLA")]
    [DisplayName("Business Process Type")]
    [IsoXmlTag("BizPrcTp")]
    public BusinessProcessType1Choice_? BusinessProcessType { get; init; }

    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    [IsoId("_jkHDezAjEeOUGqA1wUwNLA")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public SimpleValueList<IsoMax35Text> OrderIdentification { get; init; } = [];

    /// <summary>
    /// Unique identifier for the order as assigned by the buy-side. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    [IsoId("_jkHDgzAjEeOUGqA1wUwNLA")]
    [DisplayName("Client Order Identification")]
    [IsoXmlTag("ClntOrdrId")]
    public SimpleValueList<IsoMax35Text> ClientOrderIdentification { get; init; } = [];

    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    [IsoId("_jkHDizAjEeOUGqA1wUwNLA")]
    [DisplayName("Secondary Client Order Identification")]
    [IsoXmlTag("ScndryClntOrdrId")]
    public SimpleValueList<IsoMax35Text> SecondaryClientOrderIdentification { get; init; } = [];

    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_jkHDkzAjEeOUGqA1wUwNLA")]
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    public SimpleValueList<IsoMax35Text> ListIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_jkHDmzAjEeOUGqA1wUwNLA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_jkHDnTAjEeOUGqA1wUwNLA")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public required Side3Code Side { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_jkHDpTAjEeOUGqA1wUwNLA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public DeliveryReceiptType2Code? Payment { get; init; }

    /// <summary>
    /// Specifies the type of transaction of which the order is a component.
    /// </summary>
    [IsoId("_jkHDszAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Transaction Type")]
    [IsoXmlTag("TradTxTp")]
    public TradeType3Choice_? TradeTransactionType { get; init; }

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_jkHDtTAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition4Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// </summary>
    [IsoId("_jkHDvTAjEeOUGqA1wUwNLA")]
    [DisplayName("Pre Advice")]
    [IsoXmlTag("PreAdvc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PreAdvice { get; init; }

    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_jkHDvzAjEeOUGqA1wUwNLA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification79? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_jkHDwTAjEeOUGqA1wUwNLA")]
    [DisplayName("Order Booking Date")]
    [IsoXmlTag("OrdrBookgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OrderBookingDate { get; init; }

    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    [IsoId("_jkHDwzAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Origination Date")]
    [IsoXmlTag("TradOrgtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TradeOriginationDate { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_jkHDyzAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required TradeDate4Choice_ TradeDate { get; init; }

    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_jkHD0zAjEeOUGqA1wUwNLA")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public TradeDate4Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_jkHD1TAjEeOUGqA1wUwNLA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate8Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Valuation point, or valuation date of the portfolio (underlying assets). This is also known as price date.
    /// </summary>
    [IsoId("_jkHD3TAjEeOUGqA1wUwNLA")]
    [DisplayName("NAV Date")]
    [IsoXmlTag("NAVDt")]
    public DateAndDateTime1Choice_? NAVDate { get; init; }

    /// <summary>
    /// Quantity of financial instrument bought or sold which is less than the quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_jkHD3zAjEeOUGqA1wUwNLA")]
    [DisplayName("Partial Fill Details")]
    [IsoXmlTag("PrtlFillDtls")]
    public ValueList<PartialFill2> PartialFillDetails { get; init; } = [];

    /// <summary>
    /// Quantity of financial instrument that is being confirmed for the account.The quantity of the security to be settled.
    /// </summary>
    [IsoId("_jkHD4TAjEeOUGqA1wUwNLA")]
    [DisplayName("Confirmation Quantity")]
    [IsoXmlTag("ConfQty")]
    public required Quantity6Choice_ ConfirmationQuantity { get; init; }

    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_jkHD4zAjEeOUGqA1wUwNLA")]
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown11> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_jkHD5TAjEeOUGqA1wUwNLA")]
    [DisplayName("Gross Trade Amount")]
    [IsoXmlTag("GrssTradAmt")]
    public AmountAndDirection29? GrossTradeAmount { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_jkHD5zAjEeOUGqA1wUwNLA")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; }

    /// <summary>
    /// Specifies the type of transaction price.
    /// </summary>
    [IsoId("_jkHD6TAjEeOUGqA1wUwNLA")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice10Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Identifies whether an order is a margin order or a non-margin order. This is primarily used when sending orders to Japanese exchanges to indicate sell margin or buy to cover. The same tag could be assigned also by buy-side to indicate the intent to sell or buy margin and the sell-side to accept or reject (base on some validation criteria) the margin request.
    /// </summary>
    [IsoId("_jkHD6zAjEeOUGqA1wUwNLA")]
    [DisplayName("Cash Margin")]
    [IsoXmlTag("CshMrgn")]
    public CashMarginOrder1Code? CashMargin { get; init; }

    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_jkHD8zAjEeOUGqA1wUwNLA")]
    [DisplayName("Commission")]
    [IsoXmlTag("Comssn")]
    public Commission16? Commission { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_jkHD9TAjEeOUGqA1wUwNLA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should be &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_jkHD_TAjEeOUGqA1wUwNLA")]
    [DisplayName("Give Up Number Of Days")]
    [IsoXmlTag("GvUpNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? GiveUpNumberOfDays { get; init; }

    /// <summary>
    /// Indicates whether the trade is cum interest or ex interest.
    /// </summary>
    [IsoId("_jkHD_zAjEeOUGqA1wUwNLA")]
    [DisplayName("Interest Type")]
    [IsoXmlTag("IntrstTp")]
    public InterestType2Code? InterestType { get; init; }

    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_jkHEATAjEeOUGqA1wUwNLA")]
    [DisplayName("Accrued Interest Percentage")]
    [IsoXmlTag("AcrdIntrstPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AccruedInterestPercentage { get; init; }

    /// <summary>
    /// Specifies the regulatory conditions type of the trade.
    /// </summary>
    [IsoId("_jkHEAzAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Regulatory Conditions Type")]
    [IsoXmlTag("TradRgltryCondsTp")]
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_jkHEBTAjEeOUGqA1wUwNLA")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; }

    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_jkHEDTAjEeOUGqA1wUwNLA")]
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public Eligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position. Used for omnibus accounting - where accounts are held on a gross basis instead of being netted together.
    /// </summary>
    [IsoId("_jkHEDzAjEeOUGqA1wUwNLA")]
    [DisplayName("Position Effect")]
    [IsoXmlTag("PosFct")]
    public PositionEffect2Code? PositionEffect { get; init; }

    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_jkHEFzAjEeOUGqA1wUwNLA")]
    [DisplayName("Derivative Covered")]
    [IsoXmlTag("DerivCvrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DerivativeCovered { get; init; }

    /// <summary>
    /// Type of charge/tax basis.
    /// </summary>
    [IsoId("_jkHEHzAjEeOUGqA1wUwNLA")]
    [DisplayName("Charge Tax Basis Type")]
    [IsoXmlTag("ChrgTaxBsisTp")]
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; init; }

    /// <summary>
    /// Specifies the type of capital gain.
    /// </summary>
    [IsoId("_jkHEITAjEeOUGqA1wUwNLA")]
    [DisplayName("Capital Gain Type")]
    [IsoXmlTag("CptlGnTp")]
    public EUCapitalGainType2Choice_? CapitalGainType { get; init; }

    /// <summary>
    /// Provides the matching status of the trade confirmation.
    /// </summary>
    [IsoId("_jkHEIzAjEeOUGqA1wUwNLA")]
    [DisplayName("Match Status")]
    [IsoXmlTag("MtchSts")]
    public MatchingStatus8Choice_? MatchStatus { get; init; }

    /// <summary>
    /// Specifies the type of pay-in call report.
    /// </summary>
    [IsoId("_jkHEKzAjEeOUGqA1wUwNLA")]
    [DisplayName("Call In Type")]
    [IsoXmlTag("CallInTp")]
    public CallIn1Code? CallInType { get; init; }

    /// <summary>
    /// Type of yield at which the transaction was effected.
    /// </summary>
    [IsoId("_jkHELTAjEeOUGqA1wUwNLA")]
    [DisplayName("Yield Type")]
    [IsoXmlTag("YldTp")]
    public YieldCalculation2? YieldType { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_jkHELzAjEeOUGqA1wUwNLA")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting5Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_jkHENzAjEeOUGqA1wUwNLA")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Provides additional details of the trade process not included within structured fields of this message.
    /// </summary>
    [IsoId("_jkHEOTAjEeOUGqA1wUwNLA")]
    [DisplayName("Additional Trade Instruction Processing Information")]
    [IsoXmlTag("AddtlTradInstrPrcgInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalTradeInstructionProcessingInformation { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_jkHEOzAjEeOUGqA1wUwNLA")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection29? AccruedInterestAmount { get; init; }
}
