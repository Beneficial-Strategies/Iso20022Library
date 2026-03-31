// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Loyalty transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pKiwNxiEeioifFt1dhnJA")]
[Description(@"Type of Loyalty transaction.")]
[Derivations(typeof(LoyaltyTypeTransactionTotals1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LoyaltyTypeTransactionTotalsCode>))]
#endif
public enum LoyaltyTypeTransactionTotalsCode
{
    /// <summary>
    /// Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates.
    /// Encoded/decoded by serializers as &quot;AWRD&quot;.
    /// </summary>
    [EnumMember(Value = "AWRD")]
    [IsoId("_4bncQNxiEeioifFt1dhnJA")]
    [Description(
        @"Direct or payment related award on a loyalty account. Award alone, award associated to a payment (may be with an additional award alone), award because of a payment resulting on rebates."
    )]
    Award,

    /// <summary>
    /// Refund of a loyalty award transaction.
    /// Encoded/decoded by serializers as &quot;AWRR&quot;.
    /// </summary>
    [EnumMember(Value = "AWRR")]
    [IsoId("_A-y-QNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty award transaction.")]
    ReverseAward,

    /// <summary>
    /// Redemption on a loyalty account.
    /// Encoded/decoded by serializers as &quot;REDE&quot;.
    /// </summary>
    [EnumMember(Value = "REDE")]
    [IsoId("_CxPMQNxjEeioifFt1dhnJA")]
    [Description(@"Redemption on a loyalty account.")]
    Redemption,

    /// <summary>
    /// Refund of a loyalty redemption transaction.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_EN27QNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty redemption transaction.")]
    ReverseRedemption,

    /// <summary>
    /// Rebate on a total amount, sale item amount, or sale items.
    /// Encoded/decoded by serializers as &quot;REBA&quot;.
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_F8GlwNxjEeioifFt1dhnJA")]
    [Description(@"Rebate on a total amount, sale item amount, or sale items.")]
    Rebate,

    /// <summary>
    /// Refund of a loyalty rebate transaction.
    /// Encoded/decoded by serializers as &quot;REBR&quot;.
    /// </summary>
    [EnumMember(Value = "REBR")]
    [IsoId("_HatRwNxjEeioifFt1dhnJA")]
    [Description(@"Refund of a loyalty rebate transaction.")]
    ReverseRebate,
}
