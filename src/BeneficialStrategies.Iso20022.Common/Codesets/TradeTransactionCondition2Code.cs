// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YoHqZdp-Ed-ak6NoX_4Aeg_-128659706")]
[Description(@"Specifies the conditions under which the order/trade is to be executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeTransactionCondition2Code>))]
#endif
public enum TradeTransactionCondition2Code
{
    /// <summary>
    /// Indicates whether the trade is executed with a special cum coupon.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_YoHqZtp-Ed-ak6NoX_4Aeg_287848345")]
    [Description(@"Indicates whether the trade is executed with a special cum coupon.")]
    SpecialCumCoupon = TradeTransactionConditionCode.SpecialCumCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a special ex coupon.
    /// Encoded/decoded by serializers as &quot;SECN&quot;.
    /// </summary>
    [EnumMember(Value = "SECN")]
    [IsoId("_YoHqZ9p-Ed-ak6NoX_4Aeg_287848353")]
    [Description(@"Indicates whether the trade is executed with a special ex coupon.")]
    SpecialExCoupon = TradeTransactionConditionCode.SpecialExCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special ex bonus.
    /// Encoded/decoded by serializers as &quot;SEBN&quot;.
    /// </summary>
    [EnumMember(Value = "SEBN")]
    [IsoId("_YoHqaNp-Ed-ak6NoX_4Aeg_287848370")]
    [Description(@"Indicates whether the trade is executed special ex bonus.")]
    SpecialExBonus = TradeTransactionConditionCode.SpecialExBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special cum bonus.
    /// Encoded/decoded by serializers as &quot;SCBN&quot;.
    /// </summary>
    [EnumMember(Value = "SCBN")]
    [IsoId("_YoHqadp-Ed-ak6NoX_4Aeg_287848371")]
    [Description(@"Indicates whether the trade is executed special cum bonus.")]
    SpecialCumBonus = TradeTransactionConditionCode.SpecialCumBonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special cum rights.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_YoRbYNp-Ed-ak6NoX_4Aeg_287848387")]
    [Description(@"Indicates whether the trade is executed special cum rights.")]
    SpecialCumRights = TradeTransactionConditionCode.SpecialCumRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special ex rights.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("_YoRbYdp-Ed-ak6NoX_4Aeg_287848388")]
    [Description(@"Indicates whether the trade is executed special ex rights.")]
    SpecialExRights = TradeTransactionConditionCode.SpecialExRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special cum capital repayments.
    /// Encoded/decoded by serializers as &quot;SCCR&quot;.
    /// </summary>
    [EnumMember(Value = "SCCR")]
    [IsoId("_YoRbYtp-Ed-ak6NoX_4Aeg_287848405")]
    [Description(@"Indicates whether the trade is executed special cum capital repayments.")]
    SpecialCumCapitalRepayments = TradeTransactionConditionCode.SpecialCumCapitalRepayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed special ex capital repayments.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_YoRbY9p-Ed-ak6NoX_4Aeg_287848406")]
    [Description(@"Indicates whether the trade is executed special ex capital repayments.")]
    SpecialExCapitalRepayments = TradeTransactionConditionCode.SpecialExCapitalRepayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a cash settlement.
    /// Encoded/decoded by serializers as &quot;CAST&quot;.
    /// </summary>
    [EnumMember(Value = "CAST")]
    [IsoId("_YoRbZNp-Ed-ak6NoX_4Aeg_287848430")]
    [Description(@"Indicates whether the trade is executed with a cash settlement.")]
    CashSettlement = TradeTransactionConditionCode.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a special price.
    /// Encoded/decoded by serializers as &quot;SPPR&quot;.
    /// </summary>
    [EnumMember(Value = "SPPR")]
    [IsoId("_YoRbZdp-Ed-ak6NoX_4Aeg_287848431")]
    [Description(@"Indicates whether the trade is executed with a special price.")]
    SpecialPrice = TradeTransactionConditionCode.SpecialPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed with a special cum
    /// dividend, that is, buying after the ex date and getting the dividend.
    /// Encoded/decoded by serializers as &quot;SPCU&quot;.
    /// </summary>
    [EnumMember(Value = "SPCU")]
    [IsoId("_YoRbZtp-Ed-ak6NoX_4Aeg_287848447")]
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
    [IsoId("_YoRbZ9p-Ed-ak6NoX_4Aeg_287848465")]
    [Description(
        @"Indicates whether the trade is executed with a special ex |dividend, that is, selling before the ex date without the coupon."
    )]
    SpecialExDividend = TradeTransactionConditionCode.SpecialExDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the delivery of the financial instrument on settlement date |is guaranteed.
    /// Encoded/decoded by serializers as &quot;GTDL&quot;.
    /// </summary>
    [EnumMember(Value = "GTDL")]
    [IsoId("_YoRbaNp-Ed-ak6NoX_4Aeg_334023861")]
    [Description(
        @"Indicates whether the delivery of the financial instrument on settlement date |is guaranteed."
    )]
    GuaranteedDelivery = TradeTransactionConditionCode.GuaranteedDelivery, // same ordinal as derivation source for type conversions
}
