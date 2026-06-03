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
[IsoId("_Y866oajNEfCzuLlmLrhIvA")]
[DisplayName("Meeting Reference11")]
public record MeetingReference11
{
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification.
    /// </summary>
    [IsoId("_ZD4eQajNEfCzuLlmLrhIvA")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    public required IsoMax35Text MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the meeting by the issuer.
    /// </summary>
    [IsoId("_ZD4eQ6jNEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_ZD4eRajNEfCzuLlmLrhIvA")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    public required IsoISODateTime MeetingDateAndTime { get; init; }

    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement.
    /// </summary>
    [IsoId("_bjbp4ajNEfCzuLlmLrhIvA")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_ZD4eR6jNEfCzuLlmLrhIvA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; }

    /// <summary>
    /// Classification type of the meeting.
    /// </summary>
    [IsoId("_ZD4eSajNEfCzuLlmLrhIvA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice? Classification { get; init; }

    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_ZD4eS6jNEfCzuLlmLrhIvA")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public ValueList<PostalAddress1> Location { get; init; } = [];

    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_ZD4eTajNEfCzuLlmLrhIvA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification129Choice? Issuer { get; init; }
}
