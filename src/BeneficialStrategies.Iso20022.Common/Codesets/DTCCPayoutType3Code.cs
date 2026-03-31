// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UEfTgKFpEeSpipW1FBSFVg")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types."
)]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCCPayoutType3Code>))]
#endif
public enum DTCCPayoutType3Code
{
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_g8GfIaFpEeSpipW1FBSFVg")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as capital gains."
    )]
    CapitalGains = DTCCPayoutTypeCode.CapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payout consisting of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_hA3DUaFpEeSpipW1FBSFVg")]
    [Description(@"Payout consisting of cash.")]
    Cash = DTCCPayoutTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_hIv0AaFpEeSpipW1FBSFVg")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    Dividend = DTCCPayoutTypeCode.Dividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_hVsD0aFpEeSpipW1FBSFVg")]
    [Description(
        @"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time."
    )]
    Interest = DTCCPayoutTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_hfNzQaFpEeSpipW1FBSFVg")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as long-term capital gains."
    )]
    LongTermCapitalGains = DTCCPayoutTypeCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_hsv48aFpEeSpipW1FBSFVg")]
    [Description(
        @"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer."
    )]
    Premium = DTCCPayoutTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_h0L9saFpEeSpipW1FBSFVg")]
    [Description(
        @"Cash payment on a debt instrument that represents a return of principal to the holder."
    )]
    Principal = DTCCPayoutTypeCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution that doesn&apos;t represent earnings and is categorised by the company as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_iA1SkaFpEeSpipW1FBSFVg")]
    [Description(
        @"Distribution that doesn't represent earnings and is categorised by the company as return of capital."
    )]
    ReturnOfCapital = DTCCPayoutTypeCode.ReturnOfCapital, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_idQI0aFpEeSpipW1FBSFVg")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as short-term capital gains."
    )]
    ShortTermCapitalGains = DTCCPayoutTypeCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
}
