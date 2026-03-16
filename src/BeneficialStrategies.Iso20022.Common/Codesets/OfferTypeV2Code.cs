// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OzTbUS84EeKNZpaVtgp8Wg")]
[Description(@"Specifies the conditions that apply to the offer.")]
[Derivations(typeof(OfferType2Code), typeof(OfferType3Code), typeof(OfferType4Code))]
public enum OfferTypeV2Code
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_PKP7tS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights,

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_PKP7uS84EeKNZpaVtgp8Wg")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange,

    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as &quot;FCFS&quot;.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_PKP7vS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached."
    )]
    FirstComeFirstServed,

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_PKP7wS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer,

    /// <summary>
    /// Sale or purchase of odd lots to/from a third party other than the issuing company.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_PKP7xS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Sale or purchase of odd lots to/from a third party other than the issuing company."
    )]
    MiniOddLotOffer,

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_PKP7yS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer,

    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_PKP7zS84EeKNZpaVtgp8Wg")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid,

    /// <summary>
    /// Dissenter’s rights are not applicable for this option of the offer.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_8_NnEBe0EeyroI8qKgB7Mg")]
    [Description(@"Dissenter’s rights are not applicable for this option of the offer.")]
    DissenterRightsNotApplicable,
}
