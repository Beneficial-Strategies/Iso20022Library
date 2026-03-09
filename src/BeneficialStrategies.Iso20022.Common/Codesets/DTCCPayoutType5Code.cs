// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zzlRAZCMEeaSk9d1hvTrHg")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.")]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
public enum DTCCPayoutType5Code
{
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_0LieAZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as capital gains.")]
    CapitalGains = DTCCPayoutTypeCode.CapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payout consisting of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_0LieA5CMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of cash.")]
    Cash = DTCCPayoutTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_0LieBZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    Dividend = DTCCPayoutTypeCode.Dividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_0LieB5CMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.")]
    Interest = DTCCPayoutTypeCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_0LieCZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as long-term capital gains.")]
    LongTermCapitalGains = DTCCPayoutTypeCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_0LieC5CMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.")]
    Premium = DTCCPayoutTypeCode.Premium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_0LieDZCMEeaSk9d1hvTrHg")]
    [Description(@"Cash payment on a debt instrument that represents a return of principal to the holder.")]
    Principal = DTCCPayoutTypeCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution that doesn&apos;t represent earnings and is categorised by the company as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_0LieD5CMEeaSk9d1hvTrHg")]
    [Description(@"Distribution that doesn't represent earnings and is categorised by the company as return of capital.")]
    ReturnOfCapital = DTCCPayoutTypeCode.ReturnOfCapital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_0LieEZCMEeaSk9d1hvTrHg")]
    [Description(@"Distribution of earnings to shareholders categorised by the company as short-term capital gains.")]
    ShortTermCapitalGains = DTCCPayoutTypeCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payout consisting of a tax credit.
    /// Encoded/decoded by serializers as &quot;TXCR&quot;.
    /// </summary>
    [EnumMember(Value = "TXCR")]
    [IsoId("_2l0IEZCMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of a tax credit.")]
    TaxCredit = DTCCPayoutTypeCode.TaxCredit, // same ordinal as derivation source for type conversions
    
}
