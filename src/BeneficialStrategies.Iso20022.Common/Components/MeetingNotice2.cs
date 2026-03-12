// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the shareholders meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_TlqdLdp-Ed-ak6NoX_4Aeg_-507959976")]
[DisplayName("Meeting Notice")]
public partial record MeetingNotice2
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TlznENp-Ed-ak6NoX_4Aeg_-507959974")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TlznEdp-Ed-ak6NoX_4Aeg_-507959959")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the type of security holders meeting.
    /// </summary>
    [IsoId("_TlznEtp-Ed-ak6NoX_4Aeg_-507959941")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType2Code Type { get; init; } 
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlznE9p-Ed-ak6NoX_4Aeg_2025977833")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification1Code? Classification { get; init; } 
    
    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    [IsoId("_TlznFNp-Ed-ak6NoX_4Aeg_-1590199402")]
    [DisplayName("Extended Classification")]
    [IsoXmlTag("XtndedClssfctn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedClassification { get; init; } 
    
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_TlznFdp-Ed-ak6NoX_4Aeg_-507959916")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Indicates whether physical participation to a meeting is required in order to be allowed to vote.
    /// </summary>
    [IsoId("_TlznFtp-Ed-ak6NoX_4Aeg_-507959899")]
    [DisplayName("Attendance Required")]
    [IsoXmlTag("AttndncReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AttendanceRequired { get; init; } 
    
    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_TlznF9p-Ed-ak6NoX_4Aeg_-507959881")]
    [DisplayName("Attendance Confirmation Information")]
    [IsoXmlTag("AttndncConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AttendanceConfirmationInformation { get; init; } 
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TlznGNp-Ed-ak6NoX_4Aeg_-507959864")]
    [DisplayName("Attendance Confirmation Deadline")]
    [IsoXmlTag("AttndncConfDdln")]
    public DateFormat2Choice_? AttendanceConfirmationDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_Tl9YENp-Ed-ak6NoX_4Aeg_-507959629")]
    [DisplayName("Attendance Confirmation STP Deadline")]
    [IsoXmlTag("AttndncConfSTPDdln")]
    public DateFormat2Choice_? AttendanceConfirmationSTPDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Tl9YEdp-Ed-ak6NoX_4Aeg_-507959604")]
    [DisplayName("Attendance Confirmation Market Deadline")]
    [IsoXmlTag("AttndncConfMktDdln")]
    public DateFormat2Choice_? AttendanceConfirmationMarketDeadline { get; init; } 
    
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on the meeting may be found.
    /// </summary>
    [IsoId("_Tl9YEtp-Ed-ak6NoX_4Aeg_-507959569")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalDocumentationURLAddress { get; init; } 
    
    /// <summary>
    /// Date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_Tl9YE9p-Ed-ak6NoX_4Aeg_-507959544")]
    [DisplayName("Resolution Proposal Deadline")]
    [IsoXmlTag("RsltnPrpslDdln")]
    public DateFormat2Choice_? ResolutionProposalDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Tl9YFNp-Ed-ak6NoX_4Aeg_-507959527")]
    [DisplayName("Resolution Proposal Market Deadline")]
    [IsoXmlTag("RsltnPrpslMktDdln")]
    public DateFormat2Choice_? ResolutionProposalMarketDeadline { get; init; } 
    
    /// <summary>
    /// Specifies the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_Tl9YFdp-Ed-ak6NoX_4Aeg_-507959509")]
    [DisplayName("Resolution Proposal Threshold")]
    [IsoXmlTag("RsltnPrpslThrshld")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ResolutionProposalThreshold { get; init; } 
    
    /// <summary>
    /// Specifies the minimum stake in share capital or cash value or number of security holders required to table resolutions. This minimum is expressed as a percentage.
    /// </summary>
    [IsoId("_Tl9YFtp-Ed-ak6NoX_4Aeg_-507959492")]
    [DisplayName("Resolution Proposal Threshold Percentage")]
    [IsoXmlTag("RsltnPrpslThrshldPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ResolutionProposalThresholdPercentage { get; init; } 
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_Tl9YF9p-Ed-ak6NoX_4Aeg_-507959474")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_Tl9YGNp-Ed-ak6NoX_4Aeg_-507959201")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_Tl9YGdp-Ed-ak6NoX_4Aeg_-507959122")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    
    /// <summary>
    /// Indicates that no proxy is allowed for a meeting.
    /// </summary>
    [IsoId("_TmHJENp-Ed-ak6NoX_4Aeg_-507959166")]
    [DisplayName("Proxy Not Allowed")]
    [IsoXmlTag("PrxyNotAllwd")]
    public ProxyNotAllowedCode? ProxyNotAllowed { get; init; } 
    
    /// <summary>
    /// Specifies the elements required to assign a proxy.
    /// </summary>
    [IsoId("_TmHJEdp-Ed-ak6NoX_4Aeg_-507958985")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAppointmentInformation1? Proxy { get; init; } 
    
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_TmHJEtp-Ed-ak6NoX_4Aeg_-207913774")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson1> ContactPersonDetails { get; init; } = new ValueList<MeetingContactPerson1>(){};
    
    /// <summary>
    /// Date on which a company publishes the results of its meeting.
    /// </summary>
    [IsoId("_TmHJE9p-Ed-ak6NoX_4Aeg_-507959184")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    
    
    #nullable disable
    
}
