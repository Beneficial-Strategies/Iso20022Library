// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOMQU9p-Ed-ak6NoX_4Aeg_-426518701")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OfferType1Code>))]
#endif
public enum OfferType1Code
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_aOMQVNp-Ed-ak6NoX_4Aeg_-426518453")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights = OfferTypeCode.DissenterRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_aOMQVdp-Ed-ak6NoX_4Aeg_-426518452")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange = OfferTypeCode.RestrictionExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as &quot;FCFS&quot;.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_aOMQVtp-Ed-ak6NoX_4Aeg_-426518451")]
    [Description(
        @"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached."
    )]
    FirstComeFirstServed = OfferTypeCode.FirstComeFirstServed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_aOMQV9p-Ed-ak6NoX_4Aeg_-426518431")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer = OfferTypeCode.FinalOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender offer for a security that is priced below the current trading price of that instrument.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_aOWBUNp-Ed-ak6NoX_4Aeg_-426518422")]
    [Description(
        @"Tender offer for a security that is priced below the current trading price of that instrument."
    )]
    MiniTender = OfferTypeCode.MiniTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aOWBUdp-Ed-ak6NoX_4Aeg_-426518400")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer = OfferTypeCode.PartialOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_aOWBUtp-Ed-ak6NoX_4Aeg_-426518391")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid = OfferTypeCode.SqueezeOutBid, // same ordinal as derivation source for type conversions
}
