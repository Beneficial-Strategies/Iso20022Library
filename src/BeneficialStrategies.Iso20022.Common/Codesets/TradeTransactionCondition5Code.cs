// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_FjgEc9EeaBWtcfqEyXyw")]
[Description(@"Specifies the conditions under which the order/trade is to be/was executed.")]
[DerivedFrom(typeof(TradeTransactionConditionCode))]
public enum TradeTransactionCondition5Code
{
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// Encoded/decoded by serializers as &quot;XCPN&quot;.
    /// </summary>
    [EnumMember(Value = "XCPN")]
    [IsoId("_iNUDEV-mEeavlvCtut5bgg")]
    [Description(@"Indicates whether the trade is executed ex coupon.")]
    ExCoupon = TradeTransactionConditionCode.ExCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates whether the trade is executed cum coupon.
    /// Encoded/decoded by serializers as &quot;CCPN&quot;.
    /// </summary>
    [EnumMember(Value = "CCPN")]
    [IsoId("_iYxsMV-mEeavlvCtut5bgg")]
    [Description(@"Indicates whether the trade is executed cum coupon.")]
    CumCoupon = TradeTransactionConditionCode.CumCoupon, // same ordinal as derivation source for type conversions
}
