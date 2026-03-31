// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements which allow to identify a meeting.
/// </summary>
[IsoId("_TlgsINp-Ed-ak6NoX_4Aeg_-1687570906")]
[DisplayName("Meeting Reference")]
public record MeetingReference3
{
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TlgsIdp-Ed-ak6NoX_4Aeg_-1687570904")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TlgsItp-Ed-ak6NoX_4Aeg_-1687570888")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TlgsI9p-Ed-ak6NoX_4Aeg_-1687570871")]
    [DisplayName("Meeting Date And Time")]
    [IsoXmlTag("MtgDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime MeetingDateAndTime { get; init; }

    /// <summary>
    /// Specifies the type of meeting for which instructions are sent.
    /// </summary>
    [IsoId("_TlgsJNp-Ed-ak6NoX_4Aeg_-1687570853")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType2Code Type { get; init; }

    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlgsJdp-Ed-ak6NoX_4Aeg_-1687570828")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Code? Classification { get; init; }

    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    [IsoId("_TlgsJtp-Ed-ak6NoX_4Aeg_1906473527")]
    [DisplayName("Extended Classification")]
    [IsoXmlTag("XtndedClssfctn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedClassification { get; init; }

    /// <summary>
    /// Place of the company meeting for the scheduled meeting date.
    /// </summary>
    [IsoId("_TlgsJ9p-Ed-ak6NoX_4Aeg_-1687570810")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Location { get; init; } = [];
}
