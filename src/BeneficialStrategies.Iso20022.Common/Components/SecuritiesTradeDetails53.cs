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
[IsoId("_TdGR4znXEeWV5sr121Fc8A")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails53
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_T8MBjTnXEeWV5sr121Fc8A")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("_T8MBkTnXEeWV5sr121Fc8A")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoMax35Text> CollateralTransactionIdentification { get; init; } = [];

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_T8MBlTnXEeWV5sr121Fc8A")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_T8MBmTnXEeWV5sr121Fc8A")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_T8MBnTnXEeWV5sr121Fc8A")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate5Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_T8MBoTnXEeWV5sr121Fc8A")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SettlementDate9Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_T8MBpTnXEeWV5sr121Fc8A")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public required SettlementDate11Choice_ EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_T8MBqTnXEeWV5sr121Fc8A")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price2? DealPrice { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_T8MBrTnXEeWV5sr121Fc8A")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Specifies additional information relative to the processing of the trade.
    /// </summary>
    [IsoId("_T8MBsTnXEeWV5sr121Fc8A")]
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing3Choice_? OpeningClosing { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_T8MBtTnXEeWV5sr121Fc8A")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting6Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_T8MBuTnXEeWV5sr121Fc8A")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_T8MBvTnXEeWV5sr121Fc8A")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_T8MBwTnXEeWV5sr121Fc8A")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_T8MBxTnXEeWV5sr121Fc8A")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_T8MByTnXEeWV5sr121Fc8A")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FXAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_T8MBzTnXEeWV5sr121Fc8A")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
