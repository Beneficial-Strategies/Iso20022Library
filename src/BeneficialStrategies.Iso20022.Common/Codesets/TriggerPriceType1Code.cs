// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price that the trigger is compared to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yv34Ntp-Ed-ak6NoX_4Aeg_-1635338287")]
[Description(@"Specifies the type of price that the trigger is compared to.")]
[DerivedFrom(typeof(TriggerPriceTypeCode))]
public enum TriggerPriceType1Code
{
    /// <summary>
    /// Trigger is compared to best offer.
    /// Encoded/decoded by serializers as &quot;BEOF&quot;.
    /// </summary>
    [EnumMember(Value = "BEOF")]
    [IsoId("_Yv34N9p-Ed-ak6NoX_4Aeg_-319323277")]
    [Description(@"Trigger is compared to best offer.")]
    BestOffer = TriggerPriceTypeCode.BestOffer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger is compared to last trade.
    /// Encoded/decoded by serializers as &quot;LATR&quot;.
    /// </summary>
    [EnumMember(Value = "LATR")]
    [IsoId("_YwBCINp-Ed-ak6NoX_4Aeg_-319323259")]
    [Description(@"Trigger is compared to last trade.")]
    LastTrade = TriggerPriceTypeCode.LastTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger is compared to best bid.
    /// Encoded/decoded by serializers as &quot;BEBI&quot;.
    /// </summary>
    [EnumMember(Value = "BEBI")]
    [IsoId("_YwBCIdp-Ed-ak6NoX_4Aeg_-319323258")]
    [Description(@"Trigger is compared to best bid.")]
    BestBid = TriggerPriceTypeCode.BestBid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger is compared to best bid or last trade.
    /// Encoded/decoded by serializers as &quot;BBLT&quot;.
    /// </summary>
    [EnumMember(Value = "BBLT")]
    [IsoId("_YwBCItp-Ed-ak6NoX_4Aeg_-319323234")]
    [Description(@"Trigger is compared to best bid or last trade.")]
    BestBidOrLastTrade = TriggerPriceTypeCode.BestBidOrLastTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger is compared to best offer or last trade.
    /// Encoded/decoded by serializers as &quot;BOLT&quot;.
    /// </summary>
    [EnumMember(Value = "BOLT")]
    [IsoId("_YwBCI9p-Ed-ak6NoX_4Aeg_-319323217")]
    [Description(@"Trigger is compared to best offer or last trade.")]
    BestOfferOrLastTrade = TriggerPriceTypeCode.BestOfferOrLastTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger is compared to best mid.
    /// Encoded/decoded by serializers as &quot;BEMI&quot;.
    /// </summary>
    [EnumMember(Value = "BEMI")]
    [IsoId("_YwBCJNp-Ed-ak6NoX_4Aeg_-319323199")]
    [Description(@"Trigger is compared to best mid.")]
    BestMid = TriggerPriceTypeCode.BestMid, // same ordinal as derivation source for type conversions
    
}
