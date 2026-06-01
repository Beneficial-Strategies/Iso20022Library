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
[IsoId("3727fe1f-7840-441f-b44b-9e17aa4a91bc")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OfferType6Code>))]
public enum OfferType6Code
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("10b93839-d74b-43bb-85be-ab3dcb3393a3")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights = OfferTypeV2Code.DissenterRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("fe1add81-8cae-4178-afee-27e61fd91e86")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange = OfferTypeV2Code.RestrictionExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("76e1e61b-7a42-44df-9e92-e626c4c1ae1a")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer = OfferTypeV2Code.FinalOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dissenter's rights are not applicable for this option of the offer.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("eec326a5-a374-4497-988a-84ef03db3438")]
    [Description(@"Dissenter's rights are not applicable for this option of the offer.")]
    DissenterRightsNotApplicable = OfferTypeV2Code.DissenterRightsNotApplicable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("dace328c-b976-4ef9-8174-1ff99d9f178d")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer = OfferTypeV2Code.PartialOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("a68722d1-071f-4065-8bdb-392f8261dcb8")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid = OfferTypeV2Code.SqueezeOutBid, // same ordinal as derivation source for type conversions
}
