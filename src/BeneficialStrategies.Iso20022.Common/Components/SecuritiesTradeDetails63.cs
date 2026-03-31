// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[IsoId("_6dmYYZNLEeWGlc8L7oPDIg")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails63
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_6dmYcZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoRestrictedFINXMax16Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("_6dmYdZNLEeWGlc8L7oPDIg")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoRestrictedFINXMax16Text> CollateralTransactionIdentification { get; init; } =
        [];

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_6dmYeZNLEeWGlc8L7oPDIg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_6dmYfZNLEeWGlc8L7oPDIg")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_6dmYgZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate6Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_6dmYhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate12Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_6dmYiZNLEeWGlc8L7oPDIg")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_6dmYjZNLEeWGlc8L7oPDIg")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price3? DealPrice { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_6dmYkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Specifies additional information relative to the processing of the trade.
    /// </summary>
    [IsoId("_6dmYlZNLEeWGlc8L7oPDIg")]
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing4Choice_? OpeningClosing { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_6dmYmZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting9Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_6dmYnZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition6Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_6dmYoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity5Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_6dmYpZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator4Choice_? TradeOriginatorRole { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_6dmYqZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_6dmYrZNLEeWGlc8L7oPDIg")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_6dmYsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus28Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_6dmYtZNLEeWGlc8L7oPDIg")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus9Choice_? AffirmationStatus { get; init; }

    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_6dmYuZNLEeWGlc8L7oPDIg")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? FXAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_6dmYvZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
