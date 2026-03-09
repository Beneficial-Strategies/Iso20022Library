// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OECWMNxjEeioifFt1dhnJA")]
[Description(@"Type of Loyalty transaction.")]
[DerivedFrom(typeof(LoyaltyTypeTransactionTotalsCode))]
public enum LoyaltyTypeTransactionTotals1Code
{
    /// <summary>
    /// Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates.
    /// Encoded/decoded by serializers as &quot;AWRD&quot;.
    /// </summary>
    [EnumMember(Value = "AWRD")]
    [IsoId("_PsWX0dxjEeioifFt1dhnJA")]
    [Description(@"Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates.")]
    Award = LoyaltyTypeTransactionTotalsCode.Award, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rebate on a total amount, sale item amount, or sale items.
    /// Encoded/decoded by serializers as &quot;REBA&quot;.
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_PybxsdxjEeioifFt1dhnJA")]
    [Description(@"Rebate on a total amount, sale item amount, or sale items.")]
    Rebate = LoyaltyTypeTransactionTotalsCode.Rebate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption on a loyalty account.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_P1z10dxjEeioifFt1dhnJA")]
    [Description(@"Redemption on a loyalty account.")]
    Redemption = LoyaltyTypeTransactionTotalsCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty award transaction.
    /// Encoded/decoded by serializers as &quot;AWRR&quot;.
    /// </summary>
    [EnumMember(Value = "AWRR")]
    [IsoId("_P5Vq8dxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty award transaction.")]
    ReverseAward = LoyaltyTypeTransactionTotalsCode.ReverseAward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty rebate transaction.
    /// Encoded/decoded by serializers as &quot;REBR&quot;.
    /// </summary>
    [EnumMember(Value = "REBR")]
    [IsoId("_P8sg8dxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty rebate transaction.")]
    ReverseRebate = LoyaltyTypeTransactionTotalsCode.ReverseRebate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of a loyalty redemption transaction.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_QAElEdxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty redemption transaction.")]
    ReverseRedemption = LoyaltyTypeTransactionTotalsCode.ReverseRedemption, // same ordinal as derivation source for type conversions
    
}
