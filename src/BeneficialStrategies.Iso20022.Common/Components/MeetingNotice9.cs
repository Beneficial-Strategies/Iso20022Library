// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Meeting Notice9.
/// </summary>
[IsoId("_NWvMkYZEEe-5eN4DwJpixA")]
[DisplayName("Meeting Notice9")]
public record MeetingNotice9
{
    /// <summary>
    /// Additional Documentation URL Address.
    /// </summary>
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    public ValueList<IsoMax2048Text> AdditionalDocumentationURLAddress { get; init; } = [];

    /// <summary>
    /// Additional Procedure Details.
    /// </summary>
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    public AdditionalRights4? AdditionalProcedureDetails { get; init; }

    /// <summary>
    /// Announcement Date.
    /// </summary>
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; }

    /// <summary>
    /// Attendance.
    /// </summary>
    [DisplayName("Attendance")]
    [IsoXmlTag("Attndnc")]
    public Attendance2? Attendance { get; init; }

    /// <summary>
    /// Classification.
    /// </summary>
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice_? Classification { get; init; }

    /// <summary>
    /// Contact Person Details.
    /// </summary>
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    public MeetingContactPerson3? ContactPersonDetails { get; init; }

    /// <summary>
    /// Enrolment Deadline.
    /// </summary>
    [DisplayName("Enrolment Deadline")]
    [IsoXmlTag("EnrlmntDdln")]
    public DateFormat58Choice_? EnrolmentDeadline { get; init; }

    /// <summary>
    /// Enrolment Market Deadline.
    /// </summary>
    [DisplayName("Enrolment Market Deadline")]
    [IsoXmlTag("EnrlmntMktDdln")]
    public DateFormat58Choice_? EnrolmentMarketDeadline { get; init; }

    /// <summary>
    /// Entitlement Fixing Date.
    /// </summary>
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Event Processing Web Site Address.
    /// </summary>
    [DisplayName("Event Processing Web Site Address")]
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; }

    /// <summary>
    /// Issuer Meeting Identification.
    /// </summary>
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Meeting Identification.
    /// </summary>
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    public required IsoMax35Text MeetingIdentification { get; init; }

    /// <summary>
    /// One Man One Vote Indicator.
    /// </summary>
    [DisplayName("One Man One Vote Indicator")]
    [IsoXmlTag("OneManOneVoteInd")]
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; }

    /// <summary>
    /// Participation.
    /// </summary>
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public ValueList<ParticipationMethod2> Participation { get; init; } = [];

    /// <summary>
    /// Proxy Appointment Notification Address.
    /// </summary>
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; }

    /// <summary>
    /// Proxy Choice.
    /// </summary>
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy5Choice_? ProxyChoice { get; init; }

    /// <summary>
    /// Registration Securities Deadline.
    /// </summary>
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; }

    /// <summary>
    /// Registration Securities Market Deadline.
    /// </summary>
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; }

    /// <summary>
    /// Result Publication Date.
    /// </summary>
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; }

    /// <summary>
    /// Securities Blocking Period End Date.
    /// </summary>
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    public DateFormat60Choice_? SecuritiesBlockingPeriodEndDate { get; init; }

    /// <summary>
    /// Total Number Of Securities Outstanding.
    /// </summary>
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Total Number Of Voting Rights.
    /// </summary>
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; }
}
