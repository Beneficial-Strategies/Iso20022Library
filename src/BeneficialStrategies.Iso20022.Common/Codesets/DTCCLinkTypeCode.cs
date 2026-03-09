// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies types of linked events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rziMDL3EeKU9IrkkToqcw_1576727948")]
[Description(@"Specifies types of linked events.")]
[Derivations(typeof(DTCCLinkType1Code))]
public enum DTCCLinkTypeCode
{
    /// <summary>
    /// Events that are concurrent and affect the same underlying security (for example: Stock Split followed by a Reverse Split).
    /// Encoded/decoded by serializers as &quot;COEV&quot;.
    /// </summary>
    [EnumMember(Value = "COEV")]
    [IsoId("_1rziMTL3EeKU9IrkkToqcw_-2067255615")]
    [Description(@"Events that are concurrent and affect the same underlying security (for example: Stock Split followed by a Reverse Split).")]
    CorrespondingEvent,
    
    /// <summary>
    /// Events (event records) are duplicate of each other.
    /// Encoded/decoded by serializers as &quot;DUPE&quot;.
    /// </summary>
    [EnumMember(Value = "DUPE")]
    [IsoId("_1rziMjL3EeKU9IrkkToqcw_506153812")]
    [Description(@"Events (event records) are duplicate of each other.")]
    Duplicate,
    
    /// <summary>
    /// Events that are consecutive and evolve from a Voluntary Event to a Mandatory Event but of the same basic GCA (Global Corporate Actions validation service) event type. For example Exchange - Voluntary to Exchange - Mandatory. Note: The old and new events should not overlap and the older event will remain in an &quot;approved&quot; state.
    /// Encoded/decoded by serializers as &quot;CHMA&quot;.
    /// </summary>
    [EnumMember(Value = "CHMA")]
    [IsoId("_1rziMzL3EeKU9IrkkToqcw_708692762")]
    [Description(@"Events that are consecutive and evolve from a Voluntary Event to a Mandatory Event but of the same basic GCA (Global Corporate Actions validation service) event type. For example Exchange - Voluntary to Exchange - Mandatory. Note: The old and new events should not overlap and the older event will remain in an ""approved"" state.")]
    EventChangeToMandatory,
    
    /// <summary>
    /// Event that are consecutive and evolve from a Mandatory Event to a voluntary event (for example Merger-Mandatory becomes a Merger-Voluntary).
    /// Encoded/decoded by serializers as &quot;CHVO&quot;.
    /// </summary>
    [EnumMember(Value = "CHVO")]
    [IsoId("_1rziNDL3EeKU9IrkkToqcw_1545130867")]
    [Description(@"Event that are consecutive and evolve from a Mandatory Event to a voluntary event (for example Merger-Mandatory becomes a Merger-Voluntary).")]
    EventChangeToVoluntary,
    
    /// <summary>
    /// Events are linked because of fractional security.
    /// Encoded/decoded by serializers as &quot;FRSE&quot;.
    /// </summary>
    [EnumMember(Value = "FRSE")]
    [IsoId("_1rziNTL3EeKU9IrkkToqcw_1812610543")]
    [Description(@"Events are linked because of fractional security.")]
    FractionalSecurity,
    
    /// <summary>
    /// Events are linked because of underlying security is part of hybrid security. Hybrid securities have underlying securities. As an example Telecom hybrid security is made of various Telecom securities, example ATT, Verizon etc. When there is a dividend on the underlying security the hybrid pays as well. Announcements are linked under the hybrid security payment announcement to the underlying security that is paying that event. This is the way the holders of the hybrid are informed where this income is being derived from, since on many occasions there can be multiple announcements under the hybrid at the same time since the underlying securities are paying a distribution.
    /// Encoded/decoded by serializers as &quot;HYBS&quot;.
    /// </summary>
    [EnumMember(Value = "HYBS")]
    [IsoId("_1rziNjL3EeKU9IrkkToqcw_1970409266")]
    [Description(@"Events are linked because of underlying security is part of hybrid security. Hybrid securities have underlying securities. As an example Telecom hybrid security is made of various Telecom securities, example ATT, Verizon etc. When there is a dividend on the underlying security the hybrid pays as well. Announcements are linked under the hybrid security payment announcement to the underlying security that is paying that event. This is the way the holders of the hybrid are informed where this income is being derived from, since on many occasions there can be multiple announcements under the hybrid at the same time since the underlying securities are paying a distribution.")]
    PartOfHybridSecurity,
    
    /// <summary>
    /// Events are linked because of an intermediary security (for example Rights Distribution to a Rights Subscription; Rights Subscription to an Assimilation).
    /// Encoded/decoded by serializers as &quot;ISEV&quot;.
    /// </summary>
    [EnumMember(Value = "ISEV")]
    [IsoId("_1r9TMDL3EeKU9IrkkToqcw_512870045")]
    [Description(@"Events are linked because of an intermediary security (for example Rights Distribution to a Rights Subscription; Rights Subscription to an Assimilation).")]
    EventOnIntermediarySecurity,
    
    /// <summary>
    /// Events are linked because of insured or uninsured securities. In the market there are many securities where a municipality or issuer will insure a portion of their outstanding principal. It technically is the same security, however, there are two different CUSIPs one for the insured piece and the other for the un insured part.
    /// Encoded/decoded by serializers as &quot;IUNS&quot;.
    /// </summary>
    [EnumMember(Value = "IUNS")]
    [IsoId("_1r9TMTL3EeKU9IrkkToqcw_-422705688")]
    [Description(@"Events are linked because of insured or uninsured securities. In the market there are many securities where a municipality or issuer will insure a portion of their outstanding principal. It technically is the same security, however, there are two different CUSIPs one for the insured piece and the other for the un insured part.")]
    InsuredUninsuredSecurities,
    
    /// <summary>
    /// Event that are consecutive but of a different GCA (Global Corporate actions validation service) event type. For example Tender converts to Merger Voluntary when 429 Notice issued. Note: the old and new events should not overlap and the older event will remain in an &quot;approved&quot; state.
    /// Encoded/decoded by serializers as &quot;TONU&quot;.
    /// </summary>
    [EnumMember(Value = "TONU")]
    [IsoId("_1r9TMjL3EeKU9IrkkToqcw_-441378369")]
    [Description(@"Event that are consecutive but of a different GCA (Global Corporate actions validation service) event type. For example Tender converts to Merger Voluntary when 429 Notice issued. Note: the old and new events should not overlap and the older event will remain in an ""approved"" state.")]
    EventConvertedToNewEvent,
    
    /// <summary>
    /// Events are linked because event security is listed in another market under another market security.
    /// Encoded/decoded by serializers as &quot;MMKT&quot;.
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_1r9TMzL3EeKU9IrkkToqcw_1149763892")]
    [Description(@"Events are linked because event security is listed in another market under another market security.")]
    MultiMarket,
    
    /// <summary>
    /// Cannot be classified by any of the link types.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_1r9TNDL3EeKU9IrkkToqcw_7195006")]
    [Description(@"Cannot be classified by any of the link types.")]
    Other,
    
}
