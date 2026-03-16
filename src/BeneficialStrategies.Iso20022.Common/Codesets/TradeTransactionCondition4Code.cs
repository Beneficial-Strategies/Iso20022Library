// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yo3RSdp-Ed-ak6NoX_4Aeg_-230430726")]
[Description(@"Specifies the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition4Code
{
    /// <summary>
    /// Indicates whether the trade is executed cum bonus.
    /// Encoded/decoded by serializers as &quot;CBNS&quot;.
    /// </summary>
    [EnumMember(Value = "CBNS")]
    [IsoId("_YpBCQNp-Ed-ak6NoX_4Aeg_-166151120")]
    [Description(@"Indicates whether the trade is executed cum bonus.")]
    CumBonus = TradeTransactionConditionCode.CumBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed ex bonus.
    /// Encoded/decoded by serializers as &quot;XBNS&quot;.
    /// </summary>
    [EnumMember(Value = "XBNS")]
    [IsoId("_YpBCQdp-Ed-ak6NoX_4Aeg_-1227503079")]
    [Description(@"Indicates whether the trade is executed ex bonus.")]
    ExBonus = TradeTransactionConditionCode.ExBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_YpBCQtp-Ed-ak6NoX_4Aeg_-1049384407")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon = TradeTransactionConditionCode.CumCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_YpBCQ9p-Ed-ak6NoX_4Aeg_-1341342145")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon = TradeTransactionConditionCode.ExCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed cum dividend.
    /// Encoded/decoded by serializers as &quot;CDIV&quot;.
    /// </summary>
    [EnumMember(Value = "CDIV")]
    [IsoId("_YpBCRNp-Ed-ak6NoX_4Aeg_-1163223473")]
    [Description(@"Indicates whether the trade is executed cum dividend.")]
    CumDividend = TradeTransactionConditionCode.CumDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed ex dividend.
    /// Encoded/decoded by serializers as &quot;XDIV&quot;.
    /// </summary>
    [EnumMember(Value = "XDIV")]
    [IsoId("_YpBCRdp-Ed-ak6NoX_4Aeg_2070391864")]
    [Description(@"Indicates whether the trade is executed ex dividend.")]
    ExDividend = TradeTransactionConditionCode.ExDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed cum rights.
    /// Encoded/decoded by serializers as &quot;CRTS&quot;.
    /// </summary>
    [EnumMember(Value = "CRTS")]
    [IsoId("_YpBCRtp-Ed-ak6NoX_4Aeg_-2046456760")]
    [Description(@"Indicates whether the trade is executed cum rights.")]
    CumRights = TradeTransactionConditionCode.CumRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed ex rights.
    /// Encoded/decoded by serializers as &quot;XRTS&quot;.
    /// </summary>
    [EnumMember(Value = "XRTS")]
    [IsoId("_YpBCR9p-Ed-ak6NoX_4Aeg_1956552798")]
    [Description(@"Indicates whether the trade is executed ex rights.")]
    ExRights = TradeTransactionConditionCode.ExRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed cum warrant.
    /// Encoded/decoded by serializers as &quot;CWAR&quot;.
    /// </summary>
    [EnumMember(Value = "CWAR")]
    [IsoId("_YpBCSNp-Ed-ak6NoX_4Aeg_2134671470")]
    [Description(@"Indicates whether the trade is executed cum warrant.")]
    CumWarrant = TradeTransactionConditionCode.CumWarrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed ex warrant.
    /// Encoded/decoded by serializers as &quot;XWAR&quot;.
    /// </summary>
    [EnumMember(Value = "XWAR")]
    [IsoId("_YpBCSdp-Ed-ak6NoX_4Aeg_1073319511")]
    [Description(@"Indicates whether the trade is executed ex warrant.")]
    ExWarrant = TradeTransactionConditionCode.ExWarrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a special cum
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YpKzQNp-Ed-ak6NoX_4Aeg_1251438183")]
    [Description(
        @"Indicates whether the trade is executed with a special cum |dividend, that is, buying after the ex date and getting the dividend."
    )]
    SpecialCumDividend = TradeTransactionConditionCode.SpecialCumDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a special ex
    /// dividend, that is, selling before the ex date without the coupon.
    /// Encoded/decoded by serializers as &quot;SPEX&quot;.
    /// </summary>
    [EnumMember(Value = "SPEX")]
    [IsoId("_YpKzQdp-Ed-ak6NoX_4Aeg_959480445")]
    [Description(
        @"Indicates whether the trade is executed with a special ex |dividend, that is, selling before the ex date without the coupon."
    )]
    SpecialExDividend = TradeTransactionConditionCode.SpecialExDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_YpKzQtp-Ed-ak6NoX_4Aeg_-920825195")]
    [Description(
        @"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed."
    )]
    GuaranteedDelivery = TradeTransactionConditionCode.GuaranteedDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of option when set. (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRO&quot;.
    /// </summary>
    [EnumMember(Value = "BCRO")]
    [IsoId("_YpKzQ9p-Ed-ak6NoX_4Aeg_1444277001")]
    [Description(@"Result of option when set. (UK specific).")]
    ResultOption = TradeTransactionConditionCode.ResultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Result of repo when set (UK specific).
    /// Encoded/decoded by serializers as &quot;BCRP&quot;.
    /// </summary>
    [EnumMember(Value = "BCRP")]
    [IsoId("_YpKzRNp-Ed-ak6NoX_4Aeg_382925042")]
    [Description(@"Result of repo when set (UK specific).")]
    ResultRepo = TradeTransactionConditionCode.ResultRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of delivery, not for foreign registration when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCFD&quot;.
    /// </summary>
    [EnumMember(Value = "BCFD")]
    [IsoId("_YpKzRdp-Ed-ak6NoX_4Aeg_269085976")]
    [Description(@"Form of delivery, not for foreign registration when unset (UK specific).")]
    DeliveryForm = TradeTransactionConditionCode.DeliveryForm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Board lots, not set for odd lots (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBL&quot;.
    /// </summary>
    [EnumMember(Value = "BCBL")]
    [IsoId("_YpKzRtp-Ed-ak6NoX_4Aeg_447204648")]
    [Description(@"Board lots, not set for odd lots (UK specific).")]
    BoardLot = TradeTransactionConditionCode.BoardLot, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bad names, not set for good names (UK specific).
    /// Encoded/decoded by serializers as &quot;BCBN&quot;.
    /// </summary>
    [EnumMember(Value = "BCBN")]
    [IsoId("_YpKzR9p-Ed-ak6NoX_4Aeg_-614147311")]
    [Description(@"Bad names, not set for good names (UK specific).")]
    BadName = TradeTransactionConditionCode.BadName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade was executed at market price.
    /// Encoded/decoded by serializers as &quot;MAPR&quot;.
    /// </summary>
    [EnumMember(Value = "MAPR")]
    [IsoId("_YpKzSNp-Ed-ak6NoX_4Aeg_-436028639")]
    [Description(@"Trade was executed at market price.")]
    MarketPrice = TradeTransactionConditionCode.MarketPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade for which the price is not the one quoted but an improved one, that is, the negotiated price.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_YpKzSdp-Ed-ak6NoX_4Aeg_-727986377")]
    [Description(
        @"Trade for which the price is not the one quoted but an improved one, that is, the negotiated price."
    )]
    NegotiatedTrade = TradeTransactionConditionCode.NegotiatedTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade was executed outside of normal market conditions, for example, in the case of an iceberg order.
    /// Encoded/decoded by serializers as &quot;NMPR&quot;.
    /// </summary>
    [EnumMember(Value = "NMPR")]
    [IsoId("_YpT9MNp-Ed-ak6NoX_4Aeg_-549867705")]
    [Description(
        @"Trade was executed outside of normal market conditions, for example, in the case of an iceberg order."
    )]
    NonMarketPrice = TradeTransactionConditionCode.NonMarketPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of delivery, in country of incorporation when unset (UK specific).
    /// Encoded/decoded by serializers as &quot;BCPD&quot;.
    /// </summary>
    [EnumMember(Value = "BCPD")]
    [IsoId("_YpT9Mdp-Ed-ak6NoX_4Aeg_-427588864")]
    [Description(@"Place of delivery, in country of incorporation when unset (UK specific).")]
    DeliverCountryIncorporation = TradeTransactionConditionCode.DeliverCountryIncorporation, // same ordinal as derivation source for type conversions
}
