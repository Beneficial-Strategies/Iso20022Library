// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a meeting.
/// </summary>
[IsoId("_bLQ9gVuPEeSmO6RkXg92Lg")]
[DisplayName("Meeting Reference")]
public record MeetingReference6
{
    /// <summary>
    /// Identification assigned to the general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_bnYRw1uPEeSmO6RkXg92Lg")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_bnYRxVuPEeSmO6RkXg92Lg")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_bnYRx1uPEeSmO6RkXg92Lg")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? MeetingDateAndTime { get; init; }

    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_bnYRyVuPEeSmO6RkXg92Lg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MeetingType3Code? Type { get; init; }

    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_bnYRy1uPEeSmO6RkXg92Lg")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Choice_? Classification { get; init; }

    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_bnYRzVuPEeSmO6RkXg92Lg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = [];
}
