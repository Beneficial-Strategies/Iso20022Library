// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the fund order type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_om8AYFxUEeWvPv3PXpS3fw")]
[Description(@"Specifies the fund order type.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType7Code
{
    /// <summary>
    /// All type of orders.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_tpCoUVxUEeWvPv3PXpS3fw")]
    [Description(@"All type of orders.")]
    All = FundOrderTypeCode.All, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase of securities.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_uF5jcVxUEeWvPv3PXpS3fw")]
    [Description(@"Purchase of securities.")]
    SecuritiesPurchase = FundOrderTypeCode.SecuritiesPurchase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sale of securities.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_uNMeQVxUEeWvPv3PXpS3fw")]
    [Description(@"Sale of securities.")]
    SecuritiesSale = FundOrderTypeCode.SecuritiesSale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch out or switch from.
    /// Encoded/decoded by serializers as &quot;SWII&quot;.
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_vcMoAVxUEeWvPv3PXpS3fw")]
    [Description(@"Switch out or switch from.")]
    SwitchFrom = FundOrderTypeCode.SwitchFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Switch in or switch to.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_vilj4VxUEeWvPv3PXpS3fw")]
    [Description(@"Switch in or switch to.")]
    SwitchTo = FundOrderTypeCode.SwitchTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer in.
    /// Encoded/decoded by serializers as &quot;TRAI&quot;.
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_vvO4wVxUEeWvPv3PXpS3fw")]
    [Description(@"Transfer in.")]
    TransferIn = FundOrderTypeCode.TransferIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer out.
    /// Encoded/decoded by serializers as &quot;TRAO&quot;.
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_v5NUIVxUEeWvPv3PXpS3fw")]
    [Description(@"Transfer out.")]
    TransferOut = FundOrderTypeCode.TransferOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_xDTIsVxUEeWvPv3PXpS3fw")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription = FundOrderTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_xf3I4VxUEeWvPv3PXpS3fw")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption = FundOrderTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
}
