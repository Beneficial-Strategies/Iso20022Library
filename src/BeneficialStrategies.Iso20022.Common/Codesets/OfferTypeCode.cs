// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions that apply to the offer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOWBU9p-Ed-ak6NoX_4Aeg_1608488779")]
[Description(@"Specifies the conditions that apply to the offer.")]
[Derivations(typeof(OfferType1Code))]
public enum OfferTypeCode
{
    /// <summary>
    /// Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable.
    /// Encoded/decoded by serializers as &quot;DISS&quot;.
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_aOWBVNp-Ed-ak6NoX_4Aeg_1637119886")]
    [Description(
        @"Securities holder has the right to disagree with a mandatory event. This right is not inherent in all offers and therefore must be noted in announcements only when applicable."
    )]
    DissenterRights,

    /// <summary>
    /// Exchange of Restricted to Unrestricted (or vice versa).
    /// Encoded/decoded by serializers as &quot;ERUN&quot;.
    /// </summary>
    [EnumMember(Value = "ERUN")]
    [IsoId("_aOWBVdp-Ed-ak6NoX_4Aeg_1653742587")]
    [Description(@"Exchange of Restricted to Unrestricted (or vice versa).")]
    RestrictionExchange,

    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as &quot;FCFS&quot;.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("_aOWBVtp-Ed-ak6NoX_4Aeg_1877232404")]
    [Description(
        @"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached."
    )]
    FirstComeFirstServed,

    /// <summary>
    /// Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_aOWBV9p-Ed-ak6NoX_4Aeg_1922484994")]
    [Description(
        @"Final or last offer to holders subject to offer conditions being reached, for example, 50 percent accepted on a tender."
    )]
    FinalOffer,

    /// <summary>
    /// Tender offer for a security that is priced below the current trading price of that instrument.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_aOWBWNp-Ed-ak6NoX_4Aeg_1939108742")]
    [Description(
        @"Tender offer for a security that is priced below the current trading price of that instrument."
    )]
    MiniTender,

    /// <summary>
    /// Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aOWBWdp-Ed-ak6NoX_4Aeg_1952039931")]
    [Description(
        @"Offer made by the offeror for a portion of the outstanding shares not already owned by the offeror."
    )]
    PartialOffer,

    /// <summary>
    /// Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company.
    /// Encoded/decoded by serializers as &quot;SQUE&quot;.
    /// </summary>
    [EnumMember(Value = "SQUE")]
    [IsoId("_aOfyUNp-Ed-ak6NoX_4Aeg_1966814341")]
    [Description(
        @"Offer launched by a company, in possession of a large number of the shares (90% - 95%) of a company (generally as a result of a tender offer), in order to acquire the remaining shares of that company."
    )]
    SqueezeOutBid,
}
