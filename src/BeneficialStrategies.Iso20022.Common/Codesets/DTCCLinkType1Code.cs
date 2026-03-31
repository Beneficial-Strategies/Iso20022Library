// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies types of linked events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1r9TNTL3EeKU9IrkkToqcw_1920534619")]
[Description(@"Specifies types of linked events.")]
[DerivedFrom(typeof(DTCCLinkTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCCLinkType1Code>))]
#endif
public enum DTCCLinkType1Code
{
    /// <summary>
    /// Events that are concurrent and affect the same underlying security (for example: Stock Split followed by a Reverse Split).
    /// Encoded/decoded by serializers as &quot;COEV&quot;.
    /// </summary>
    [EnumMember(Value = "COEV")]
    [IsoId("_1r9TNjL3EeKU9IrkkToqcw_1305917374")]
    [Description(
        @"Events that are concurrent and affect the same underlying security (for example: Stock Split followed by a Reverse Split)."
    )]
    CorrespondingEvent = DTCCLinkTypeCode.CorrespondingEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events (event records) are duplicate of each other.
    /// Encoded/decoded by serializers as &quot;DUPE&quot;.
    /// </summary>
    [EnumMember(Value = "DUPE")]
    [IsoId("_1sHEMDL3EeKU9IrkkToqcw_1192078308")]
    [Description(@"Events (event records) are duplicate of each other.")]
    Duplicate = DTCCLinkTypeCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events that are consecutive and evolve from a Voluntary Event to a Mandatory Event but of the same basic GCA (Global Corporate Actions validation service) event type. For example Exchange - Voluntary to Exchange - Mandatory. Note: The old and new events should not overlap and the older event will remain in an &quot;approved&quot; state.
    /// Encoded/decoded by serializers as &quot;CHMA&quot;.
    /// </summary>
    [EnumMember(Value = "CHMA")]
    [IsoId("_1sHEMTL3EeKU9IrkkToqcw_1294818597")]
    [Description(
        @"Events that are consecutive and evolve from a Voluntary Event to a Mandatory Event but of the same basic GCA (Global Corporate Actions validation service) event type. For example Exchange - Voluntary to Exchange - Mandatory. Note: The old and new events should not overlap and the older event will remain in an ""approved"" state."
    )]
    EventChangeToMandatory = DTCCLinkTypeCode.EventChangeToMandatory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event that are consecutive and evolve from a Mandatory Event to a voluntary event (for example Merger-Mandatory becomes a Merger-Voluntary).
    /// Encoded/decoded by serializers as &quot;CHVO&quot;.
    /// </summary>
    [EnumMember(Value = "CHVO")]
    [IsoId("_1sHEMjL3EeKU9IrkkToqcw_1748905866")]
    [Description(
        @"Event that are consecutive and evolve from a Mandatory Event to a voluntary event (for example Merger-Mandatory becomes a Merger-Voluntary)."
    )]
    EventChangeToVoluntary = DTCCLinkTypeCode.EventChangeToVoluntary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events are linked because of fractional security.
    /// Encoded/decoded by serializers as &quot;FRSE&quot;.
    /// </summary>
    [EnumMember(Value = "FRSE")]
    [IsoId("_1sHEMzL3EeKU9IrkkToqcw_1635066800")]
    [Description(@"Events are linked because of fractional security.")]
    FractionalSecurity = DTCCLinkTypeCode.FractionalSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events are linked because of underlying security is part of hybrid security. Hybrid securities have underlying securities. As an example Telecom hybrid security is made of various Telecom securities, example ATT, Verizon etc. When there is a dividend on the underlying security the hybrid pays as well. Announcements are linked under the hybrid security payment announcement to the underlying security that is paying that event. This is the way the holders of the hybrid are informed where this income is being derived from, since on many occasions there can be multiple announcements under the hybrid at the same time since the underlying securities are paying a distribution.
    /// Encoded/decoded by serializers as &quot;HYBS&quot;.
    /// </summary>
    [EnumMember(Value = "HYBS")]
    [IsoId("_1sHENDL3EeKU9IrkkToqcw_56725669")]
    [Description(
        @"Events are linked because of underlying security is part of hybrid security. Hybrid securities have underlying securities. As an example Telecom hybrid security is made of various Telecom securities, example ATT, Verizon etc. When there is a dividend on the underlying security the hybrid pays as well. Announcements are linked under the hybrid security payment announcement to the underlying security that is paying that event. This is the way the holders of the hybrid are informed where this income is being derived from, since on many occasions there can be multiple announcements under the hybrid at the same time since the underlying securities are paying a distribution."
    )]
    PartOfHybridSecurity = DTCCLinkTypeCode.PartOfHybridSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events are linked because of an intermediary security (for example Rights Distribution to a Rights Subscription; Rights Subscription to an Assimilation).
    /// Encoded/decoded by serializers as &quot;ISEV&quot;.
    /// </summary>
    [EnumMember(Value = "ISEV")]
    [IsoId("_1sHENTL3EeKU9IrkkToqcw_-261050992")]
    [Description(
        @"Events are linked because of an intermediary security (for example Rights Distribution to a Rights Subscription; Rights Subscription to an Assimilation)."
    )]
    EventOnIntermediarySecurity = DTCCLinkTypeCode.EventOnIntermediarySecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events are linked because of insured or uninsured securities. In the market there are many securities where a municipality or issuer will insure a portion of their outstanding principal. It technically is the same security, however, there are two different CUSIPs one for the insured piece and the other for the un insured part.
    /// Encoded/decoded by serializers as &quot;IUNS&quot;.
    /// </summary>
    [EnumMember(Value = "IUNS")]
    [IsoId("_1sHENjL3EeKU9IrkkToqcw_-374890058")]
    [Description(
        @"Events are linked because of insured or uninsured securities. In the market there are many securities where a municipality or issuer will insure a portion of their outstanding principal. It technically is the same security, however, there are two different CUSIPs one for the insured piece and the other for the un insured part."
    )]
    InsuredUninsuredSecurities = DTCCLinkTypeCode.InsuredUninsuredSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event that are consecutive but of a different GCA (Global Corporate actions validation service) event type. For example Tender converts to Merger Voluntary when 429 Notice issued. Note: the old and new events should not overlap and the older event will remain in an &quot;approved&quot; state.
    /// Encoded/decoded by serializers as &quot;TONU&quot;.
    /// </summary>
    [EnumMember(Value = "TONU")]
    [IsoId("_1sQOIDL3EeKU9IrkkToqcw_1096759964")]
    [Description(
        @"Event that are consecutive but of a different GCA (Global Corporate actions validation service) event type. For example Tender converts to Merger Voluntary when 429 Notice issued. Note: the old and new events should not overlap and the older event will remain in an ""approved"" state."
    )]
    EventConvertedToNewEvent = DTCCLinkTypeCode.EventConvertedToNewEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Events are linked because event security is listed in another market under another market security.
    /// Encoded/decoded by serializers as &quot;MMKT&quot;.
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_1sQOITL3EeKU9IrkkToqcw_-1201915425")]
    [Description(
        @"Events are linked because event security is listed in another market under another market security."
    )]
    MultiMarket = DTCCLinkTypeCode.MultiMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cannot be classified by any of the link types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_1sQOIjL3EeKU9IrkkToqcw_2105408816")]
    [Description(@"Cannot be classified by any of the link types.")]
    Other = DTCCLinkTypeCode.Other, // same ordinal as derivation source for type conversions
}
