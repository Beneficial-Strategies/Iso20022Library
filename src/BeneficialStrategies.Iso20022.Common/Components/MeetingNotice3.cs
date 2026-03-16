// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the shareholders meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_TkBeZtp-Ed-ak6NoX_4Aeg_-1325036860")]
[DisplayName("Meeting Notice")]
public record MeetingNotice3
{
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TkBeZ9p-Ed-ak6NoX_4Aeg_-1325036828")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TkBeaNp-Ed-ak6NoX_4Aeg_-1325036798")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Specifies the type of security holders meeting.
    /// </summary>
    [IsoId("_TkBeadp-Ed-ak6NoX_4Aeg_-1325036737")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType2Code Type { get; init; }

    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TkLPYNp-Ed-ak6NoX_4Aeg_-1325036706")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Choice_? Classification { get; init; }

    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_TkLPYdp-Ed-ak6NoX_4Aeg_-1325036645")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AnnouncementDate { get; init; }

    /// <summary>
    /// Indicates whether physical participation to a meeting is required in order to be allowed to vote.
    /// </summary>
    [IsoId("_TkLPYtp-Ed-ak6NoX_4Aeg_-1325036622")]
    [DisplayName("Attendance Required")]
    [IsoXmlTag("AttndncReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AttendanceRequired { get; init; }

    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_TkLPY9p-Ed-ak6NoX_4Aeg_-1325036591")]
    [DisplayName("Attendance Confirmation Information")]
    [IsoXmlTag("AttndncConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AttendanceConfirmationInformation { get; init; }

    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TkLPZNp-Ed-ak6NoX_4Aeg_-1325036583")]
    [DisplayName("Attendance Confirmation Deadline")]
    [IsoXmlTag("AttndncConfDdln")]
    public DateFormat2Choice_? AttendanceConfirmationDeadline { get; init; }

    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TkLPZdp-Ed-ak6NoX_4Aeg_-1325036343")]
    [DisplayName("Attendance Confirmation STP Deadline")]
    [IsoXmlTag("AttndncConfSTPDdln")]
    public DateFormat2Choice_? AttendanceConfirmationSTPDeadline { get; init; }

    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TkLPZtp-Ed-ak6NoX_4Aeg_-1325036313")]
    [DisplayName("Attendance Confirmation Market Deadline")]
    [IsoXmlTag("AttndncConfMktDdln")]
    public DateFormat2Choice_? AttendanceConfirmationMarketDeadline { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on the meeting may be found.
    /// </summary>
    [IsoId("_TkLPZ9p-Ed-ak6NoX_4Aeg_-1325036282")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalDocumentationURLAddress { get; init; }

    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_TkLPaNp-Ed-ak6NoX_4Aeg_-141349463")]
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights1> AdditionalProcedureDetails { get; init; } = [];

    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_TkLPadp-Ed-ak6NoX_4Aeg_-1324116189")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public ActiveCurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_TkUZUNp-Ed-ak6NoX_4Aeg_-1324116158")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_TkUZUdp-Ed-ak6NoX_4Aeg_-1324116004")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; }

    /// <summary>
    /// Choice to signalize whether proxy is allowed.
    /// </summary>
    [IsoId("_TkUZUtp-Ed-ak6NoX_4Aeg_-901483829")]
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy1Choice_? ProxyChoice { get; init; }

    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_TkUZU9p-Ed-ak6NoX_4Aeg_-1324116034")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson1> ContactPersonDetails { get; init; } = [];

    /// <summary>
    /// Date on which a company publishes the results of its meeting.
    /// </summary>
    [IsoId("_TkUZVNp-Ed-ak6NoX_4Aeg_-1324116157")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; }
}
