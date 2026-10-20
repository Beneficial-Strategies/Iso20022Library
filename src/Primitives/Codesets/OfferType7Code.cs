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
[IsoId("_7dEPkfH4EfCS-OXqezZQmw")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OfferType7Code>))]
public enum OfferType7Code
{
    /// <summary>
    /// Event will be paid in a particular priority stated in the offering documentation. Higher tiers of securities will be paid ahead of lower tiers of securities.
    /// Encoded/decoded by serializers as &quot;ACPR&quot;.
    /// </summary>
    [EnumMember(Value = "ACPR")]
    [IsoId("_9xlP4fH4EfCS-OXqezZQmw")]
    [Description(
        @"Event will be paid in a particular priority stated in the offering documentation. Higher tiers of securities will be paid ahead of lower tiers of securities."
    )]
    AcceptancePriority = OfferTypeV2Code.AcceptancePriority, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_7scvYfH4EfCS-OXqezZQmw")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights = OfferTypeV2Code.DissenterRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_7scvY_H4EfCS-OXqezZQmw")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange = OfferTypeV2Code.RestrictionExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_7scvZfH4EfCS-OXqezZQmw")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer = OfferTypeV2Code.FinalOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dissenter's rights are not applicable for this option of the offer.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_7scva_H4EfCS-OXqezZQmw")]
    [Description(@"Dissenter's rights are not applicable for this option of the offer.")]
    DissenterRightsNotApplicable = OfferTypeV2Code.DissenterRightsNotApplicable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_7scvZ_H4EfCS-OXqezZQmw")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer = OfferTypeV2Code.PartialOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_7scvafH4EfCS-OXqezZQmw")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid = OfferTypeV2Code.SqueezeOutBid, // same ordinal as derivation source for type conversions
}
