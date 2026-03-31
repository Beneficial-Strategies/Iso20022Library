// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of trading method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tZm3wESaEeS6cOLECtYLrA")]
[Description(@"Identifies the type of trading method.")]
[Derivations(typeof(TradingMethodType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingMethodTypeCode>))]
#endif
public enum TradingMethodTypeCode
{
    /// <summary>
    /// Members submit orders, and trading system uses matchmaking mechanism of Centralized Price Bidding to match orders.
    /// Encoded/decoded by serializers as &quot;CERB&quot;.
    /// </summary>
    [EnumMember(Value = "CERB")]
    [IsoId("_KXx3QESbEeS6cOLECtYLrA")]
    [Description(
        @"Members submit orders, and trading system uses matchmaking mechanism of Centralized Price Bidding to match orders.|"
    )]
    CentralizedPriceBidding,

    /// <summary>
    /// Members submit orders, and trading system uses continuous matchmaking mechanism to match orders.
    /// Encoded/decoded by serializers as &quot;CUMA&quot;.
    /// </summary>
    [EnumMember(Value = "CUMA")]
    [IsoId("_VtZrsESbEeS6cOLECtYLrA")]
    [Description(
        @"Members submit orders, and trading system uses continuous matchmaking mechanism to match orders.|"
    )]
    ContinuousMatching,

    /// <summary>
    /// Taker submits a bilateral request, maker replys the quotation, and taker accepts the quotation to complete a bilateral trade.
    /// Encoded/decoded by serializers as &quot;BITR&quot;.
    /// </summary>
    [EnumMember(Value = "BITR")]
    [IsoId("_Z6aesESbEeS6cOLECtYLrA")]
    [Description(
        @"Taker submits a bilateral request, maker replys the quotation, and taker accepts the quotation to complete a bilateral trade."
    )]
    BilateralTrade,

    /// <summary>
    /// When market makers quote continuously, members could just click the quotation to make a deal with market makers.
    /// Encoded/decoded by serializers as &quot;ONCT&quot;.
    /// </summary>
    [EnumMember(Value = "ONCT")]
    [IsoId("_z_7esEVOEeSGWeX3z5zSZQ")]
    [Description(
        @"When market makers quote continuously, members could just click the quotation to make a deal with market makers."
    )]
    OneClickTrade,

    /// <summary>
    /// Member activate an order, and if order matches with market maker&apos;s quotationa, the order will be filled automatically.
    /// Encoded/decoded by serializers as &quot;LIOR&quot;.
    /// </summary>
    [EnumMember(Value = "LIOR")]
    [IsoId("_9eAisEVOEeSGWeX3z5zSZQ")]
    [Description(
        @"Member activate an order, and if order matches with market maker's quotationa, the order will be filled automatically."
    )]
    LimitOrder,

    /// <summary>
    /// Member completes product elements and submits, and the counterpart just confirms the deal to complete a negotiation trade.
    /// Encoded/decoded by serializers as &quot;NETR&quot;.
    /// </summary>
    [EnumMember(Value = "NETR")]
    [IsoId("__4MGIEVOEeSGWeX3z5zSZQ")]
    [Description(
        @"Member completes product elements and submits, and the counterpart just confirms the deal to complete a negotiation trade."
    )]
    NegotiationTrade,

    /// <summary>
    /// Market members can click the predetermined price setted by issuer to make a deal， and then the subscription amount will deduct in time.
    /// Encoded/decoded by serializers as &quot;QUAU&quot;.
    /// </summary>
    [EnumMember(Value = "QUAU")]
    [IsoId("_DMXMoEVPEeSGWeX3z5zSZQ")]
    [Description(
        @"Market members can click the predetermined price setted by issuer to make a deal， and then the subscription amount will deduct in time.|"
    )]
    QuotationAuction,

    /// <summary>
    /// Administrator reviews the deposit that filled by issuer, and sends it to the tenderers as reference. Atfer this, the issuer confirms the tendering result.
    /// Encoded/decoded by serializers as &quot;TEAU&quot;.
    /// </summary>
    [EnumMember(Value = "TEAU")]
    [IsoId("_EkLUIEVPEeSGWeX3z5zSZQ")]
    [Description(
        @"Administrator reviews the deposit that filled by issuer, and sends it to the tenderers as reference. Atfer this, the issuer confirms the tendering result.|"
    )]
    TenderingAuction,

    /// <summary>
    /// Trades are executed any click anonymously.
    /// Encoded/decoded by serializers as &quot;ANCL&quot;.
    /// </summary>
    [EnumMember(Value = "ANCL")]
    [IsoId("_41JkIKUoEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed any click anonymously.")]
    AnonymousClick,
}
