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
[IsoId("_38MqKSAaEeu4a6pNulzZ4Q")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails128
{
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_38MqNSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoRestrictedFINXMax52Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("_38MqOSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Collateral Transaction Identification")]
    [IsoXmlTag("CollTxId")]
    public SimpleValueList<IsoRestrictedFINXMax16Text> CollateralTransactionIdentification { get; init; } =
        [];

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_38MqPSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification2? PlaceOfTrade { get; init; }

    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_38MqQSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_38MqRSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate9Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_38MqSSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SettlementDate20Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Date and time at which a transaction is completed and cleared, for example, payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_38MqTSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public required SettlementDate22Choice_ EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_38MqUSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price11? DealPrice { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_38MqVSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Specifies additional information relative to the processing of the trade.
    /// </summary>
    [IsoId("_38MqWSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Opening Closing")]
    [IsoXmlTag("OpngClsg")]
    public OpeningClosing4Choice_? OpeningClosing { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_38MqXSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting9Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_38MqYSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition6Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_38MqZSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity5Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_38MqaSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Trade Originator Role")]
    [IsoXmlTag("TradOrgtrRole")]
    public TradeOriginator4Choice_? TradeOriginatorRole { get; init; }

    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_38MqbSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Type Of Price")]
    [IsoXmlTag("TpOfPric")]
    public TypeOfPrice32Choice_? TypeOfPrice { get; init; }

    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_38MqcSAaEeu4a6pNulzZ4Q")]
    [DisplayName("FX Additional Details")]
    [IsoXmlTag("FxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? FXAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    [IsoId("_38MqdSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
