// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fVeOYNuKEeiB5uLfkg9ZJA")]
[Description(@"Type of loyalty transaction.")]
[Derivations(typeof(LoyaltyTransactionType1Code))]
public enum LoyaltyTransactionTypeCode
{
    /// <summary>
    /// Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of 	a payment resulting on rebates.
    /// Encoded/decoded by serializers as &quot;AWRD&quot;.
    /// </summary>
    [EnumMember(Value = "AWRD")]
    [IsoId("_jKy6INuKEeiB5uLfkg9ZJA")]
    [Description(@"Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of 	a payment resulting on rebates.")]
    Award,
    
    /// <summary>
    /// Refund of a loyalty award transaction.
    /// Encoded/decoded by serializers as &quot;AWRR&quot;.
    /// </summary>
    [EnumMember(Value = "AWRR")]
    [IsoId("_oAuuUNuKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty award transaction.")]
    AwardRefund,
    
    /// <summary>
    /// Redemption on a loyalty account.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_qY1OINuKEeiB5uLfkg9ZJA")]
    [Description(@"Redemption on a loyalty account.")]
    Redemption,
    
    /// <summary>
    /// Refund of a loyalty redemption transaction.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_s97oINuKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty redemption transaction.")]
    RedemptionRefund,
    
    /// <summary>
    /// Rebate on a total amount, sale item amount, or sale items.
    /// Encoded/decoded by serializers as &quot;REBA&quot;.
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_wY5TINuKEeiB5uLfkg9ZJA")]
    [Description(@"Rebate on a total amount, sale item amount, or sale items.")]
    Rebate,
    
    /// <summary>
    /// Refund of a loyalty rebate transaction.
    /// Encoded/decoded by serializers as &quot;REBR&quot;.
    /// </summary>
    [EnumMember(Value = "REBR")]
    [IsoId("_y06poNuKEeiB5uLfkg9ZJA")]
    [Description(@"Refund of a loyalty rebate transaction.")]
    RebateRefund,
    
}
