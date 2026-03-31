// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwBCJdp-Ed-ak6NoX_4Aeg_781187809")]
[Description(@"Specifies the type of price that the trigger is compared to.")]
[Derivations(typeof(TriggerPriceType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TriggerPriceTypeCode>))]
#endif
public enum TriggerPriceTypeCode
{
    /// <summary>
    /// Trigger is compared to best offer.
    /// Encoded/decoded by serializers as &quot;BEOF&quot;.
    /// </summary>
    [EnumMember(Value = "BEOF")]
    [IsoId("_YwBCJtp-Ed-ak6NoX_4Aeg_-1305643677")]
    [Description(@"Trigger is compared to best offer.")]
    BestOffer,

    /// <summary>
    /// Trigger is compared to last trade.
    /// Encoded/decoded by serializers as &quot;LATR&quot;.
    /// </summary>
    [EnumMember(Value = "LATR")]
    [IsoId("_YwKzINp-Ed-ak6NoX_4Aeg_-1291788982")]
    [Description(@"Trigger is compared to last trade.")]
    LastTrade,

    /// <summary>
    /// Trigger is compared to best bid.
    /// Encoded/decoded by serializers as &quot;BEBI&quot;.
    /// </summary>
    [EnumMember(Value = "BEBI")]
    [IsoId("_YwKzIdp-Ed-ak6NoX_4Aeg_-1262237349")]
    [Description(@"Trigger is compared to best bid.")]
    BestBid,

    /// <summary>
    /// Trigger is compared to best bid or last trade.
    /// Encoded/decoded by serializers as &quot;BBLT&quot;.
    /// </summary>
    [EnumMember(Value = "BBLT")]
    [IsoId("_YwKzItp-Ed-ak6NoX_4Aeg_-1250231999")]
    [Description(@"Trigger is compared to best bid or last trade.")]
    BestBidOrLastTrade,

    /// <summary>
    /// Trigger is compared to best offer or last trade.
    /// Encoded/decoded by serializers as &quot;BOLT&quot;.
    /// </summary>
    [EnumMember(Value = "BOLT")]
    [IsoId("_YwKzI9p-Ed-ak6NoX_4Aeg_-1231759300")]
    [Description(@"Trigger is compared to best offer or last trade.")]
    BestOfferOrLastTrade,

    /// <summary>
    /// Trigger is compared to best mid.
    /// Encoded/decoded by serializers as &quot;BEMI&quot;.
    /// </summary>
    [EnumMember(Value = "BEMI")]
    [IsoId("_YwKzJNp-Ed-ak6NoX_4Aeg_-1203129635")]
    [Description(@"Trigger is compared to best mid.")]
    BestMid,
}
