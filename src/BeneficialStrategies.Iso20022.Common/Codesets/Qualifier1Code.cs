// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the use of the quote or the indication of interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWnIFtp-Ed-ak6NoX_4Aeg_-2042168442")]
[Description(@"Qualifies the use of the quote or the indication of interest.")]
[DerivedFrom(typeof(QualifierCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Qualifier1Code>))]
#endif
public enum Qualifier1Code
{
    /// <summary>
    /// A limit order that is to be executed in its entirety or not at all (no partial transaction), and thus is testing the strength/conviction of the counterparty. Unlike a fill or kill order, all or none orders are not to be treated as cancelled if not executed as soon as it is represented in the trading crowd. Instead it remains alive until executed or cancelled. The making of &quot;all or none&quot; bids or offers in stocks is prohibited, and the making of &quot;all or none&quot; bids or offers in bonds is subject to the restrictions of Rule 61.
    /// Encoded/decoded by serializers as &quot;ALNO&quot;.
    /// </summary>
    [EnumMember(Value = "ALNO")]
    [IsoId("_ZWnIF9p-Ed-ak6NoX_4Aeg_-1642285830")]
    [Description(
        @"A limit order that is to be executed in its entirety or not at all (no partial transaction), and thus is testing the strength/conviction of the counterparty. Unlike a fill or kill order, all or none orders are not to be treated as cancelled if not executed as soon as it is represented in the trading crowd. Instead it remains alive until executed or cancelled. The making of ""all or none"" bids or offers in stocks is prohibited, and the making of ""all or none"" bids or offers in bonds is subject to the restrictions of Rule 61."
    )]
    AllOrNone = QualifierCode.AllOrNone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to trade stocks, options, or futures as close as possible to the market close.
    /// Encoded/decoded by serializers as &quot;MOCE&quot;.
    /// </summary>
    [EnumMember(Value = "MOCE")]
    [IsoId("_ZWnIGNp-Ed-ak6NoX_4Aeg_-1642285829")]
    [Description(
        @"An order to trade stocks, options, or futures as close as possible to the market close."
    )]
    MarketOnClose = QualifierCode.MarketOnClose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An all or none market order that is to be executed at the closing price of the security on the exchange. If the execution cannot be made under this condition, the order is to be treated as cancelled.||Note that this attribute does not apply to trading of fixed income securities.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ZWw5ENp-Ed-ak6NoX_4Aeg_-1642285813")]
    [Description(
        @"An all or none market order that is to be executed at the closing price of the security on the exchange. If the execution cannot be made under this condition, the order is to be treated as cancelled.||Note that this attribute does not apply to trading of fixed income securities."
    )]
    AtClose = QualifierCode.AtClose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A trading benchmark particularly used in pension plans. Calculated by adding up the dollars traded for every transaction (price times shares traded) and then dividing by the total shares traded for the day for the particular security.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_ZWw5Edp-Ed-ak6NoX_4Aeg_-1642285812")]
    [Description(
        @"A trading benchmark particularly used in pension plans. Calculated by adding up the dollars traded for every transaction (price times shares traded) and then dividing by the total shares traded for the day for the particular security."
    )]
    VolumeWeightedAveragePrice = QualifierCode.VolumeWeightedAveragePrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Having a sell inquiry in a security (not a firm customer sell order), often entailing a capital commitment.
    /// Encoded/decoded by serializers as &quot;ITOW&quot;.
    /// </summary>
    [EnumMember(Value = "ITOW")]
    [IsoId("_ZWw5Etp-Ed-ak6NoX_4Aeg_-1642285795")]
    [Description(
        @"Having a sell inquiry in a security (not a firm customer sell order), often entailing a capital commitment."
    )]
    InTouchWith = QualifierCode.InTouchWith, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to buy a stock at or below a specified price, or to sell a stock at or above a specified price. The customer specifies a price, and the order can be executed only if the market reaches or betters that price. A conditional trading order designed to avoid the danger of adverse unexpected price movements.
    /// Encoded/decoded by serializers as &quot;LIMI&quot;.
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_ZWw5E9p-Ed-ak6NoX_4Aeg_-1642285794")]
    [Description(
        @"An order to buy a stock at or below a specified price, or to sell a stock at or above a specified price. The customer specifies a price, and the order can be executed only if the market reaches or betters that price. A conditional trading order designed to avoid the danger of adverse unexpected price movements."
    )]
    Limit = QualifierCode.Limit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// More security exists to be bought or sold by the same buyer or seller, respectively. Often, the buyer or seller does not disclose the full size of his buy or sell interest as not to affect the market adversely.||Information that the execution is taking place in waves/iceberg.
    /// Encoded/decoded by serializers as &quot;MOBH&quot;.
    /// </summary>
    [EnumMember(Value = "MOBH")]
    [IsoId("_ZWw5FNp-Ed-ak6NoX_4Aeg_-1642285770")]
    [Description(
        @"More security exists to be bought or sold by the same buyer or seller, respectively. Often, the buyer or seller does not disclose the full size of his buy or sell interest as not to affect the market adversely.||Information that the execution is taking place in waves/iceberg."
    )]
    MoreBehind = QualifierCode.MoreBehind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order that is to be executed at the opening (and corresponding price) of the security or not at all, and any such order or portion thereof not executed is to be treated as cancelled.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZWw5Fdp-Ed-ak6NoX_4Aeg_-1642285753")]
    [Description(
        @"An order that is to be executed at the opening (and corresponding price) of the security or not at all, and any such order or portion thereof not executed is to be treated as cancelled."
    )]
    AtOpen = QualifierCode.AtOpen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A market commitment to purchase or sell securities.
    /// Encoded/decoded by serializers as &quot;POSI&quot;.
    /// </summary>
    [EnumMember(Value = "POSI")]
    [IsoId("_ZWw5Ftp-Ed-ak6NoX_4Aeg_-1642285752")]
    [Description(@"A market commitment to purchase or sell securities.")]
    TakingPosition = QualifierCode.TakingPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to buy or sell a security at the most advantageous price obtainable after the order is represented in the trading crowd. Other special restrictions, such as all or none (AON) or good &apos;til cancelled (GTC), cannot be specified on a market order.
    /// Encoded/decoded by serializers as &quot;MAKT&quot;.
    /// </summary>
    [EnumMember(Value = "MAKT")]
    [IsoId("_ZWw5F9p-Ed-ak6NoX_4Aeg_-1642285487")]
    [Description(
        @"An order to buy or sell a security at the most advantageous price obtainable after the order is represented in the trading crowd. Other special restrictions, such as all or none (AON) or good 'til cancelled (GTC), cannot be specified on a market order."
    )]
    AtMarket = QualifierCode.AtMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All of the information necessary to generate an order is present and is considered an offer.
    /// Encoded/decoded by serializers as &quot;RTRA&quot;.
    /// </summary>
    [EnumMember(Value = "RTRA")]
    [IsoId("_ZWw5GNp-Ed-ak6NoX_4Aeg_-1642285470")]
    [Description(
        @"All of the information necessary to generate an order is present and is considered an offer."
    )]
    ReadyToTrade = QualifierCode.ReadyToTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A collection of investments, real and/or financial, with distribution by geographic region or by asset type of the portfolio&apos;s holdings.
    /// Encoded/decoded by serializers as &quot;POSH&quot;.
    /// </summary>
    [EnumMember(Value = "POSH")]
    [IsoId("_ZW6qENp-Ed-ak6NoX_4Aeg_-1642285452")]
    [Description(
        @"A collection of investments, real and/or financial, with distribution by geographic region or by asset type of the portfolio's holdings."
    )]
    PortfolioShown = QualifierCode.PortfolioShown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Working the order through the day.
    /// Encoded/decoded by serializers as &quot;TDAY&quot;.
    /// </summary>
    [EnumMember(Value = "TDAY")]
    [IsoId("_ZW6qEdp-Ed-ak6NoX_4Aeg_-1642285444")]
    [Description(@"Working the order through the day.")]
    ThroughDay = QualifierCode.ThroughDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indication sent versus the current quote.
    /// Encoded/decoded by serializers as &quot;VERS&quot;.
    /// </summary>
    [EnumMember(Value = "VERS")]
    [IsoId("_ZW6qEtp-Ed-ak6NoX_4Aeg_-1642285427")]
    [Description(@"Indication sent versus the current quote.")]
    Versus = QualifierCode.Versus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transacting with another broker/dealer.
    /// Encoded/decoded by serializers as &quot;AWAY&quot;.
    /// </summary>
    [EnumMember(Value = "AWAY")]
    [IsoId("_ZW6qE9p-Ed-ak6NoX_4Aeg_-1642285410")]
    [Description(@"Transacting with another broker/dealer.")]
    WorkingAway = QualifierCode.WorkingAway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities transaction in which the same broker acts as agent for both sides of the trade; a legal practice only if the broker first offers the securities publicly at a price higher than the bid.
    /// Encoded/decoded by serializers as &quot;CROS&quot;.
    /// </summary>
    [EnumMember(Value = "CROS")]
    [IsoId("_ZW6qFNp-Ed-ak6NoX_4Aeg_-1642285392")]
    [Description(
        @"Securities transaction in which the same broker acts as agent for both sides of the trade; a legal practice only if the broker first offers the securities publicly at a price higher than the bid."
    )]
    Crossing = QualifierCode.Crossing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An all or none market order that is to be executed at the mid price spread of the security on the exchange. If the execution cannot be made under this condition, the order is to be treated as cancelled.
    /// Encoded/decoded by serializers as &quot;MIDP&quot;.
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_ZW6qFdp-Ed-ak6NoX_4Aeg_-1642285367")]
    [Description(
        @"An all or none market order that is to be executed at the mid price spread of the security on the exchange. If the execution cannot be made under this condition, the order is to be treated as cancelled."
    )]
    AtMidpoint = QualifierCode.AtMidpoint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price of security prior to a market opening.
    /// Encoded/decoded by serializers as &quot;PREO&quot;.
    /// </summary>
    [EnumMember(Value = "PREO")]
    [IsoId("_ZW6qFtp-Ed-ak6NoX_4Aeg_-1642285366")]
    [Description(@"Price of security prior to a market opening.")]
    PreOpen = QualifierCode.PreOpen, // same ordinal as derivation source for type conversions
}
