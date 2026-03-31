// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the trade leg details.
/// </summary>
[IsoId("_LpIEAS6aEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg")]
public record TradeLeg10
{
    /// <summary>
    /// Unambiguous identification of the transaction (that is the trade leg) as know by the instructing party.
    /// </summary>
    [IsoId("_L9qJkS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TradeLegIdentification { get; init; }

    /// <summary>
    /// Reference allocated by the broker dealer.
    /// </summary>
    [IsoId("_L9qJky6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Unique reference assigned by the trading venue when the trade is executed.
    /// </summary>
    [IsoId("_L9qJlS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TradeExecutionIdentification { get; init; }

    /// <summary>
    /// Identifies the order sent by the final investor to an intermediary in order to initiate a trade in the former&apos;s name. This identification is then matched with the equivalent trade by the clearing.
    /// </summary>
    [IsoId("_rk0PoC69EeSQQqw1BT_aMg")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OrderIdentification { get; init; }

    /// <summary>
    /// Identifies the portion of assets within a determined trade that shall be allocated to different clients.
    /// </summary>
    [IsoId("_0pJBwC67EeSQQqw1BT_aMg")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AllocationIdentification { get; init; }

    /// <summary>
    /// Provides the date and time of trade transaction.
    /// </summary>
    [IsoId("_L9qJly6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered &quot;after market&quot; hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_p0ynAC6-EeSQQqw1BT_aMg")]
    [DisplayName("Transaction Date And Time")]
    [IsoXmlTag("TxDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateAndTime { get; init; }

    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_L9qJmS6aEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateFormat15Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_L9qJmy6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    /// <summary>
    /// Identifies the trade leg indicator which gives the trade side (buy or sell).
    /// </summary>
    [IsoId("_L9qJnS6aEeSQQqw1BT_aMg")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; }

    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_L9qJny6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.
    /// </summary>
    [IsoId("_L9qJoS6aEeSQQqw1BT_aMg")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Nm6RcC69EeSQQqw1BT_aMg")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; }

    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_L9qJoy6aEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_L9qJpS6aEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; }

    /// <summary>
    /// Identifies the type of trade transaction.
    /// </summary>
    [IsoId("_L9qJpy6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; }

    /// <summary>
    /// Indicates that the trade is for settlement of an exercised derivatives contract.
    /// </summary>
    [IsoId("_L9qJqS6aEeSQQqw1BT_aMg")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker or prime broker).
    /// </summary>
    [IsoId("_GtZXwC7EEeSQQqw1BT_aMg")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount100? Broker { get; init; }

    /// <summary>
    /// Provides the identification of the trading party.
    /// </summary>
    [IsoId("_L9qJqy6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification35Choice_ TradingParty { get; init; }

    /// <summary>
    /// Indicates in which session the transaction/operation was executed by the final investor or an intermediary.
    /// </summary>
    [IsoId("_pqoI8C6_EeSQQqw1BT_aMg")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; }

    /// <summary>
    /// Identifier of the trading participant&apos;s account at the trading venue using the venue&apos;s coding system.
    /// </summary>
    [IsoId("_L9qJrS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_L9qJry6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity5Code TradingCapacity { get; init; }

    /// <summary>
    /// Indicates how a trade is maintained in the clearing account.
    /// </summary>
    [IsoId("_L9qJsS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_JGdagC68EeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_kgqF0C68EeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }
}
