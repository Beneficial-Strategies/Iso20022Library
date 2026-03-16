// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the notification advice.
/// </summary>
[IsoId("_UKUpZtp-Ed-ak6NoX_4Aeg_1910542710")]
[DisplayName("Corporate Action Notification")]
public record CorporateActionNotification1
{
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_UKUpZ9p-Ed-ak6NoX_4Aeg_1619065277")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat4Choice_? AnnouncementDate { get; init; }

    /// <summary>
    /// Date/time at which additional information on the event will be announced, eg, exchange ratio announcement date.
    /// </summary>
    [IsoId("_UKUpaNp-Ed-ak6NoX_4Aeg_1630150555")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat4Choice_? FurtherDetailedAnnouncementDate { get; init; }

    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, eg, publication by a governmental administration.
    /// </summary>
    [IsoId("_UKUpadp-Ed-ak6NoX_4Aeg_-1290955122")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat4Choice_? OfficialAnnouncementPublicationDate { get; init; }

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_UKUpatp-Ed-ak6NoX_4Aeg_1527353717")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus1FormatChoice_ ProcessingStatus { get; init; }
}
