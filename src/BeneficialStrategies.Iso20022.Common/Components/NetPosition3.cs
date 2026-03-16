// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the net positions details.
/// </summary>
[IsoId("_Hkd7wS6aEeSQQqw1BT_aMg")]
[DisplayName("Net Position")]
public record NetPosition3
{
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_H3p9gy6aEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required SecuritiesAccount18 ClearingAccount { get; init; }

    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_H3p9hS6aEeSQQqw1BT_aMg")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; }

    /// <summary>
    /// An account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_H3p9hy6aEeSQQqw1BT_aMg")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_H3p9iS6aEeSQQqw1BT_aMg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides the initial position amount.
    /// </summary>
    [IsoId("_H3p9iy6aEeSQQqw1BT_aMg")]
    [DisplayName("Initial Position Amount")]
    [IsoXmlTag("InitlPosAmt")]
    public AmountAndDirection21? InitialPositionAmount { get; init; }

    /// <summary>
    /// Provides the net position amount.
    /// </summary>
    [IsoId("_H3p9jS6aEeSQQqw1BT_aMg")]
    [DisplayName("Net Position Amount")]
    [IsoXmlTag("NetPosAmt")]
    public required AmountAndDirection21 NetPositionAmount { get; init; }

    /// <summary>
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_H3p9jy6aEeSQQqw1BT_aMg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    /// <summary>
    /// This is the price of the trade.
    /// </summary>
    [IsoId("_H3p9kS6aEeSQQqw1BT_aMg")]
    [DisplayName("Average Deal Price")]
    [IsoXmlTag("AvrgDealPric")]
    public Price4? AverageDealPrice { get; init; }

    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_H3p9ky6aEeSQQqw1BT_aMg")]
    [DisplayName("Net Quantity")]
    [IsoXmlTag("NetQty")]
    public required FinancialInstrumentQuantity1Choice_ NetQuantity { get; init; }

    /// <summary>
    /// Indicates the securities movement direction, that is, whether this is a delivery or return.
    /// </summary>
    [IsoId("_H3p9lS6aEeSQQqw1BT_aMg")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Place at which a trade settles.
    /// </summary>
    [IsoId("_H3p9ly6aEeSQQqw1BT_aMg")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification34Choice_ Depository { get; init; }

    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_H3p9mS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity5Code? TradingCapacity { get; init; }

    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_H3p9my6aEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification20? PlaceOfTrade { get; init; }

    /// <summary>
    /// Provides the date of the trade.
    /// </summary>
    [IsoId("_H3p9nS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_H3p9ny6aEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat15Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Provides the trade leg details such as trade leg identification and trade type.
    /// </summary>
    [IsoId("_H3p9oS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Leg Details")]
    [IsoXmlTag("TradLegDtls")]
    public ValueList<TradeLeg10> TradeLegDetails { get; init; } = [];
}
