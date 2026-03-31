// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market claim in the context of a corporate action distribution event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dZoAIC2mEeuVt5XRmyhHiA")]
[Description(
    @"Specifies the type of market claim in the context of a corporate action distribution event."
)]
[Derivations(typeof(MarketClaimType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketClaimTypeCode>))]
#endif
public enum MarketClaimTypeCode
{
    /// <summary>
    /// Market claim that has been created due to a pending/failing settlement transaction, to ensure the event proceeds are delivered from the seller to the buyer.
    /// Encoded/decoded by serializers as &quot;MKTC&quot;.
    /// </summary>
    [EnumMember(Value = "MKTC")]
    [IsoId("_GjijwC2nEeuVt5XRmyhHiA")]
    [Description(
        @"Market claim that has been created due to a pending/failing settlement transaction, to ensure the event proceeds are delivered from the seller to the buyer."
    )]
    MarketClaim,

    /// <summary>
    /// Market claim that has been created due to a settled settlement transaction, to ensure the event proceeds are delivered from the buyer to the seller.
    /// Encoded/decoded by serializers as &quot;RVMC&quot;.
    /// </summary>
    [EnumMember(Value = "RVMC")]
    [IsoId("_UI-esC2nEeuVt5XRmyhHiA")]
    [Description(
        @"Market claim that has been created due to a settled settlement transaction, to ensure the event proceeds are delivered from the buyer to the seller."
    )]
    ReverseMarketClaim,
}
