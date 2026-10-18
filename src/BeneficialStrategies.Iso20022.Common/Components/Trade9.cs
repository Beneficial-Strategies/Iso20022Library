// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade9.
/// </summary>
[IsoId("_i9i04ZqPEe6okLaLQ4oCqQ")]
[DisplayName("Trade9")]
public record Trade9
{
    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public required Max35Text TradeIdentification { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required ISODate TradeDate { get; init; }

    /// <summary>
    /// Foreign Exchange Trade Product.
    /// </summary>
    [DisplayName("Foreign Exchange Trade Product")]
    [IsoXmlTag("FXTradPdct")]
    public required UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; }

    /// <summary>
    /// Trading Currency.
    /// </summary>
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public ActiveCurrencyCode? TradingCurrency { get; init; }

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Trading Method.
    /// </summary>
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public TradingMethodType1Code? TradingMethod { get; init; }

    /// <summary>
    /// Trading Mode.
    /// </summary>
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public required TradingModeType1Code TradingMode { get; init; }

    /// <summary>
    /// Clearing Method.
    /// </summary>
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod1Code ClearingMethod { get; init; }

    /// <summary>
    /// Symbol.
    /// </summary>
    [DisplayName("Symbol")]
    [IsoXmlTag("Symb")]
    public Max35Text? Symbol { get; init; }

    /// <summary>
    /// Place Of Confirmation.
    /// </summary>
    [DisplayName("Place Of Confirmation")]
    [IsoXmlTag("PlcOfConf")]
    public AnyBICDec2014Identifier? PlaceOfConfirmation { get; init; }

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public Trade10? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Swap Leg.
    /// </summary>
    [DisplayName("Swap Leg")]
    [IsoXmlTag("SwpLeg")]
    public ValueList<InstrumentLeg7> SwapLeg { get; init; } = [];

    /// <summary>
    /// Product Identification.
    /// </summary>
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification38Choice_? ProductIdentification { get; init; }

    /// <summary>
    /// Associated Trade Reference.
    /// </summary>
    [DisplayName("Associated Trade Reference")]
    [IsoXmlTag("AssoctdTradRef")]
    public ValueList<Max70Text> AssociatedTradeReference { get; init; } = [];
}
