// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade8.
/// </summary>
[IsoId("_iy6SMZqPEe6okLaLQ4oCqQ")]
[DisplayName("Trade8")]
public partial record Trade8
{
    #nullable enable

    /// <summary>
    /// Associated Trade Reference.
    /// </summary>
    [DisplayName("Associated Trade Reference")]
    [IsoXmlTag("AssoctdTradRef")]
    public ValueList<IsoMax70Text> AssociatedTradeReference { get; init; } = [];

    /// <summary>
    /// Clearing Method.
    /// </summary>
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod1Code ClearingMethod { get; init; } 

    /// <summary>
    /// Delivery Type.
    /// </summary>
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public DeliveryType4Code? DeliveryType { get; init; } 

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public Trade10? ForeignExchangeDetails { get; init; } 

    /// <summary>
    /// Foreign Exchange Trade Product.
    /// </summary>
    [DisplayName("Foreign Exchange Trade Product")]
    [IsoXmlTag("FXTradPdct")]
    public required UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; } 

    /// <summary>
    /// Place Of Confirmation.
    /// </summary>
    [DisplayName("Place Of Confirmation")]
    [IsoXmlTag("PlcOfConf")]
    public IsoAnyBICDec2014Identifier? PlaceOfConfirmation { get; init; } 

    /// <summary>
    /// Product Identification.
    /// </summary>
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification38Choice_? ProductIdentification { get; init; } 

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 

    /// <summary>
    /// Swap Leg.
    /// </summary>
    [DisplayName("Swap Leg")]
    [IsoXmlTag("SwpLeg")]
    public ValueList<InstrumentLeg7> SwapLeg { get; init; } = [];

    /// <summary>
    /// Symbol.
    /// </summary>
    [DisplayName("Symbol")]
    [IsoXmlTag("Symb")]
    public IsoMax35Text? Symbol { get; init; } 

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required IsoISODate TradeDate { get; init; } 

    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public required IsoMax35Text TradeIdentification { get; init; } 

    /// <summary>
    /// Trading Currency.
    /// </summary>
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public ActiveCurrencyCode? TradingCurrency { get; init; } 

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

    
    #nullable disable
    
}
