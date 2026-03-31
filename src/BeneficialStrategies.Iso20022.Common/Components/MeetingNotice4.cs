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
[IsoId("_6lq6QVtgEeSwKe7KuKvXhg")]
[DisplayName("Meeting Notice")]
public record MeetingNotice4
{
    /// <summary>
    /// Identification assigned to the general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_7DISU1tgEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_7DISVVtgEeSwKe7KuKvXhg")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Specifies the type of security holders meeting.
    /// </summary>
    [IsoId("_7DISV1tgEeSwKe7KuKvXhg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType3Code Type { get; init; }

    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_7DISWVtgEeSwKe7KuKvXhg")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Choice_? Classification { get; init; }

    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_7DISW1tgEeSwKe7KuKvXhg")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AnnouncementDate { get; init; }

    /// <summary>
    /// Indicates whether physical participation to the meeting is required in order to be allowed to vote.
    /// </summary>
    [IsoId("_7DISXVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Required")]
    [IsoXmlTag("AttndncReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AttendanceRequired { get; init; }

    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_7DISX1tgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation Information")]
    [IsoXmlTag("AttndncConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AttendanceConfirmationInformation { get; init; }

    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of its intention to participate in the meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_7DISYVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation Deadline")]
    [IsoXmlTag("AttndncConfDdln")]
    public DateFormat29Choice_? AttendanceConfirmationDeadline { get; init; }

    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of its intention to participate in the meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_7DISY1tgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation STP Deadline")]
    [IsoXmlTag("AttndncConfSTPDdln")]
    public DateFormat29Choice_? AttendanceConfirmationSTPDeadline { get; init; }

    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_7DISZVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation Market Deadline")]
    [IsoXmlTag("AttndncConfMktDdln")]
    public DateFormat29Choice_? AttendanceConfirmationMarketDeadline { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_7DISZ1tgEeSwKe7KuKvXhg")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalDocumentationURLAddress { get; init; }

    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_7DISaVtgEeSwKe7KuKvXhg")]
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights2> AdditionalProcedureDetails { get; init; } = [];

    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_7DISa1tgEeSwKe7KuKvXhg")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public UnitOrFaceAmount1Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_7DISbVtgEeSwKe7KuKvXhg")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_7DISb1tgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; }

    /// <summary>
    /// Indicates whether a proxy is allowed.
    /// </summary>
    [IsoId("_7DIScVtgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy2Choice_? ProxyChoice { get; init; }

    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_7DISc1tgEeSwKe7KuKvXhg")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson2> ContactPersonDetails { get; init; } = [];

    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_7DISdVtgEeSwKe7KuKvXhg")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; }
}
