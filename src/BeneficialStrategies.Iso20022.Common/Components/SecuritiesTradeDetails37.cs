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
[IsoId("_tm-gcStKEeOgfbujmhmNAA")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails37
{
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_uAa7OytKEeOgfbujmhmNAA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification78? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_uAa7QytKEeOgfbujmhmNAA")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_uAa7SytKEeOgfbujmhmNAA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_uAa7UytKEeOgfbujmhmNAA")]
    [DisplayName("Opening Settlement Date")]
    [IsoXmlTag("OpngSttlmDt")]
    public required DateAndDateTimeChoice_ OpeningSettlementDate { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_uAa7WytKEeOgfbujmhmNAA")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price2? DealPrice { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_uAa7YytKEeOgfbujmhmNAA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_uAa7aytKEeOgfbujmhmNAA")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting2Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_uAa7cytKEeOgfbujmhmNAA")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition1Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_uAa7eytKEeOgfbujmhmNAA")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity1Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_uAa7gytKEeOgfbujmhmNAA")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator1Choice_? TradeOriginatorRole { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_uAa7iytKEeOgfbujmhmNAA")]
    [DisplayName("Currency To Buy Or Sell")]
    [IsoXmlTag("CcyToBuyOrSell")]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; }

    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_uAa7kytKEeOgfbujmhmNAA")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus1Choice_? AffirmationStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_uAa7mytKEeOgfbujmhmNAA")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus1Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_uAa7oytKEeOgfbujmhmNAA")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_uAa7qytKEeOgfbujmhmNAA")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FXAdditionalDetails { get; init; }
}
