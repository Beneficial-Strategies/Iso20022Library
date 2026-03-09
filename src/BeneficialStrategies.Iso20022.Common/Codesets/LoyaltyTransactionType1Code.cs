// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2TFZoNuKEeiB5uLfkg9ZJA")]
[Description(@"Type of loyalty transaction.")]
[DerivedFrom(typeof(LoyaltyTransactionTypeCode))]
public enum LoyaltyTransactionType1Code
{
    /// <summary>
    /// Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of 	a payment resulting on rebates.
    /// Encoded/decoded by serializers as &quot;AWRD&quot;.
    /// </summary>
    [EnumMember(Value = "AWRD")]
    [IsoId("_4dBhoduKEeiB5uLfkg9ZJA")]
    [Description(@"Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of 	a payment resulting on rebates.")]
    Award = LoyaltyTransactionTypeCode.Award, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty award transaction.
    /// Encoded/decoded by serializers as &quot;AWRR&quot;.
    /// </summary>
    [EnumMember(Value = "AWRR")]
    [IsoId("_4hLB0duKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty award transaction.")]
    AwardRefund = LoyaltyTransactionTypeCode.AwardRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty rebate transaction.
    /// Encoded/decoded by serializers as &quot;REBR&quot;.
    /// </summary>
    [EnumMember(Value = "REBR")]
    [IsoId("_4ltjkduKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty rebate transaction.")]
    RebateRefund = LoyaltyTransactionTypeCode.RebateRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rebate on a total amount, sale item amount, or sale items.
    /// Encoded/decoded by serializers as &quot;REBA&quot;.
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_4sHtkduKEeiB5uLfkg9ZJA")]
    [Description(@"Rebate on a total amount, sale item amount, or sale items.")]
    Rebate = LoyaltyTransactionTypeCode.Rebate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption on a loyalty account.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_4yUcMduKEeiB5uLfkg9ZJA")]
    [Description(@"Redemption on a loyalty account.")]
    Redemption = LoyaltyTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty redemption transaction.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_45L5MduKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty redemption transaction.")]
    RedemptionRefund = LoyaltyTransactionTypeCode.RedemptionRefund, // same ordinal as derivation source for type conversions
    
}
