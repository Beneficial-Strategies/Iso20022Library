// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the foreign exchange trade including spot\forward\NDF\swap that is confirmed.
/// </summary>
[IsoId("_yDLnEA2IEeSwB74WgTbh4Q")]
[DisplayName("Trade")]
public record Trade2
{
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_6QrTkBkmEeSmqJmZFbWcmQ")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TradeIdentification { get; init; }

    /// <summary>
    /// Specifies the date on which the trade was executed.
    /// </summary>
    [IsoId("_FQB2cg2JEeSwB74WgTbh4Q")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_KR08YQ2JEeSwB74WgTbh4Q")]
    [DisplayName("Foreign Exchange Trade Product")]
    [IsoXmlTag("FXTradPdct")]
    public required UnderlyingProductIdentifier1Code ForeignExchangeTradeProduct { get; init; }

    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_FQB2dA2JEeSwB74WgTbh4Q")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    /// <summary>
    /// Settlement currency of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_FQB2dw2JEeSwB74WgTbh4Q")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public CurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Identifies the type of trading method.
    /// </summary>
    [IsoId("_BP7TMEShEeS6cOLECtYLrA")]
    [DisplayName("Trading Method")]
    [IsoXmlTag("TradgMtd")]
    public TradingMethodType1Code? TradingMethod { get; init; }

    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_JCGJkEVSEeSGWeX3z5zSZQ")]
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public required TradingModeType1Code TradingMode { get; init; }

    /// <summary>
    /// Clearing method of the trade, agreed by both sides of the trade.
    /// </summary>
    [IsoId("_FQB2dQ2JEeSwB74WgTbh4Q")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod1Code ClearingMethod { get; init; }

    /// <summary>
    /// Symbol of the trade.
    /// </summary>
    [IsoId("_sixnQIdSEeS8A78Q2OnhsA")]
    [DisplayName("Symbol")]
    [IsoXmlTag("Symb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Symbol { get; init; }

    /// <summary>
    /// Infrastructure where the trade confirmation will take place.
    /// </summary>
    [IsoId("_FQB2eA2JEeSwB74WgTbh4Q")]
    [DisplayName("Place Of Confirmation")]
    [IsoXmlTag("PlcOfConf")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? PlaceOfConfirmation { get; init; }

    /// <summary>
    /// Provides details of the foreign exchange trade including Spot Forward and NDF.
    /// </summary>
    [IsoId("_FQB2eg2JEeSwB74WgTbh4Q")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public Trade3? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides details about each leg of the multileg instrument (foreign exchange swap).
    /// </summary>
    [IsoId("_FQB2ew2JEeSwB74WgTbh4Q")]
    [DisplayName("Swap Leg")]
    [IsoXmlTag("SwpLeg")]
    public ValueList<InstrumentLeg6> SwapLeg { get; init; } = [];

    /// <summary>
    /// Identification of the treasury trade product, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_AbzAYRGEEeSahYR-dAI4lQ")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification22Choice_? ProductIdentification { get; init; }

    /// <summary>
    /// Some associated trade reference needs to be specified.
    /// </summary>
    [IsoId("_BLgREA2JEeSwB74WgTbh4Q")]
    [DisplayName("Associated Trade Reference")]
    [IsoXmlTag("AssoctdTradRef")]
    public SimpleValueList<IsoMax70Text> AssociatedTradeReference { get; init; } = [];
}
