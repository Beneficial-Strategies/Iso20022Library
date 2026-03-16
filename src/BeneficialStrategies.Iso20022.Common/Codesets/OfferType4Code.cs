// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GiKkARe1EeyroI8qKgB7Mg")]
[Description(@"Specifies the conditions that apply to the offer.")]
[DerivedFrom(typeof(OfferTypeV2Code))]
public enum OfferType4Code
{
    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_G3xAkRe1EeyroI8qKgB7Mg")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid = OfferTypeV2Code.SqueezeOutBid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_G3xAkxe1EeyroI8qKgB7Mg")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange = OfferTypeV2Code.RestrictionExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_G3xAlRe1EeyroI8qKgB7Mg")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer = OfferTypeV2Code.PartialOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as &quot;FCFS&quot;.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_G3xAlxe1EeyroI8qKgB7Mg")]
    [Description(
        @"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached."
    )]
    FirstComeFirstServed = OfferTypeV2Code.FirstComeFirstServed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_G3xAmRe1EeyroI8qKgB7Mg")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer = OfferTypeV2Code.FinalOffer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dissenter’s rights are not applicable for this option of the offer.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_G3xAmxe1EeyroI8qKgB7Mg")]
    [Description(@"Dissenter’s rights are not applicable for this option of the offer.")]
    DissenterRightsNotApplicable = OfferTypeV2Code.DissenterRightsNotApplicable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_ViP4ARe1EeyroI8qKgB7Mg")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights = OfferTypeV2Code.DissenterRights, // same ordinal as derivation source for type conversions
}
