// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net Position4.
/// </summary>
[IsoId("_feCaAYcREe-U27oWwgmhCQ")]
[DisplayName("Net Position4")]
public record NetPosition4
{
    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Average Deal Price.
    /// </summary>
    [DisplayName("Average Deal Price")]
    [IsoXmlTag("AvrgDealPric")]
    public Price14? AverageDealPrice { get; init; }

    /// <summary>
    /// Clearing Account.
    /// </summary>
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required SecuritiesAccount18 ClearingAccount { get; init; }

    /// <summary>
    /// Delivery Account.
    /// </summary>
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification255Choice_ Depository { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Initial Position Amount.
    /// </summary>
    [DisplayName("Initial Position Amount")]
    [IsoXmlTag("InitlPosAmt")]
    public AmountAndDirection21? InitialPositionAmount { get; init; }

    /// <summary>
    /// Net Position Amount.
    /// </summary>
    [DisplayName("Net Position Amount")]
    [IsoXmlTag("NetPosAmt")]
    public required AmountAndDirection21 NetPositionAmount { get; init; }

    /// <summary>
    /// Net Quantity.
    /// </summary>
    [DisplayName("Net Quantity")]
    [IsoXmlTag("NetQty")]
    public required FinancialInstrumentQuantity1Choice_ NetQuantity { get; init; }

    /// <summary>
    /// Non Clearing Member.
    /// </summary>
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification20? PlaceOfTrade { get; init; }

    /// <summary>
    /// Securities Movement Type.
    /// </summary>
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat66Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Trade Leg Details.
    /// </summary>
    [DisplayName("Trade Leg Details")]
    [IsoXmlTag("TradLegDtls")]
    public ValueList<TradeLeg13> TradeLegDetails { get; init; } = [];

    /// <summary>
    /// Trading Capacity.
    /// </summary>
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity5Code? TradingCapacity { get; init; }
}
