// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the shareholders meeting, specifying the participation requirements and the voting procedures. Alternatively, it may indicate where such information may be obtained.
/// </summary>
[IsoId("_TlqdLdp-Ed-ak6NoX_4Aeg_-507959976")]
[DisplayName("Meeting Notice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingNotice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingNotice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingNotice2( MeetingType2Code reqType,System.String reqAttendanceRequired )
    {
        Type = reqType;
        AttendanceRequired = reqAttendanceRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_TlznENp-Ed-ak6NoX_4Aeg_-507959974")]
    [DisplayName("Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgId")]
    #endif
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MeetingIdentification { get; init; } 
    #else
    public System.String? MeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to a meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_TlznEdp-Ed-ak6NoX_4Aeg_-507959959")]
    [DisplayName("Issuer Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrMtgId")]
    #endif
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerMeetingIdentification { get; init; } 
    #else
    public System.String? IssuerMeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of security holders meeting.
    /// </summary>
    [IsoId("_TlznEtp-Ed-ak6NoX_4Aeg_-507959941")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingType2Code Type { get; init; } 
    #else
    public MeetingType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_TlznE9p-Ed-ak6NoX_4Aeg_2025977833")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingTypeClassification1Code? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingTypeClassification1Code? Classification { get; init; } 
    #else
    public MeetingTypeClassification1Code? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// This code can be used in case another meeting classifications is required.
    /// </summary>
    [IsoId("_TlznFNp-Ed-ak6NoX_4Aeg_-1590199402")]
    [DisplayName("Extended Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedClssfctn")]
    #endif
    [IsoXmlTag("XtndedClssfctn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedClassification { get; init; } 
    #else
    public System.String? ExtendedClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_TlznFdp-Ed-ak6NoX_4Aeg_-507959916")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AnnouncementDate { get; init; } 
    #else
    public System.DateOnly? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether physical participation to a meeting is required in order to be allowed to vote.
    /// </summary>
    [IsoId("_TlznFtp-Ed-ak6NoX_4Aeg_-507959899")]
    [DisplayName("Attendance Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncReqrd")]
    #endif
    [IsoXmlTag("AttndncReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AttendanceRequired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AttendanceRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AttendanceRequired { get; init; } 
    #else
    public System.String AttendanceRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_TlznF9p-Ed-ak6NoX_4Aeg_-507959881")]
    [DisplayName("Attendance Confirmation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfInf")]
    #endif
    [IsoXmlTag("AttndncConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AttendanceConfirmationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttendanceConfirmationInformation { get; init; } 
    #else
    public System.String? AttendanceConfirmationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TlznGNp-Ed-ak6NoX_4Aeg_-507959864")]
    [DisplayName("Attendance Confirmation Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfDdln")]
    #endif
    [IsoXmlTag("AttndncConfDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? AttendanceConfirmationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? AttendanceConfirmationDeadline { get; init; } 
    #else
    public DateFormat2Choice_? AttendanceConfirmationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of their intention to participate in a meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_Tl9YENp-Ed-ak6NoX_4Aeg_-507959629")]
    [DisplayName("Attendance Confirmation STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfSTPDdln")]
    #endif
    [IsoXmlTag("AttndncConfSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? AttendanceConfirmationSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? AttendanceConfirmationSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? AttendanceConfirmationSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Tl9YEdp-Ed-ak6NoX_4Aeg_-507959604")]
    [DisplayName("Attendance Confirmation Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfMktDdln")]
    #endif
    [IsoXmlTag("AttndncConfMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? AttendanceConfirmationMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? AttendanceConfirmationMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? AttendanceConfirmationMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where addtional information on the meeting may be found.
    /// </summary>
    [IsoId("_Tl9YEtp-Ed-ak6NoX_4Aeg_-507959569")]
    [DisplayName("Additional Documentation URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDcmnttnURLAdr")]
    #endif
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalDocumentationURLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalDocumentationURLAddress { get; init; } 
    #else
    public System.String? AdditionalDocumentationURLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which security holders can propose amendments or new resolutions. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_Tl9YE9p-Ed-ak6NoX_4Aeg_-507959544")]
    [DisplayName("Resolution Proposal Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnPrpslDdln")]
    #endif
    [IsoXmlTag("RsltnPrpslDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? ResolutionProposalDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? ResolutionProposalDeadline { get; init; } 
    #else
    public DateFormat2Choice_? ResolutionProposalDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which security holders can propose amendments or new resolutions. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Tl9YFNp-Ed-ak6NoX_4Aeg_-507959527")]
    [DisplayName("Resolution Proposal Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnPrpslMktDdln")]
    #endif
    [IsoXmlTag("RsltnPrpslMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? ResolutionProposalMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? ResolutionProposalMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? ResolutionProposalMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_Tl9YFdp-Ed-ak6NoX_4Aeg_-507959509")]
    [DisplayName("Resolution Proposal Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnPrpslThrshld")]
    #endif
    [IsoXmlTag("RsltnPrpslThrshld")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ResolutionProposalThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResolutionProposalThreshold { get; init; } 
    #else
    public System.String? ResolutionProposalThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the minimum stake in share capital or cash value or number of security holders required to table resolutions. This minimum is expressed as a percentage.
    /// </summary>
    [IsoId("_Tl9YFtp-Ed-ak6NoX_4Aeg_-507959492")]
    [DisplayName("Resolution Proposal Threshold Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnPrpslThrshldPctg")]
    #endif
    [IsoXmlTag("RsltnPrpslThrshldPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ResolutionProposalThresholdPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ResolutionProposalThresholdPercentage { get; init; } 
    #else
    public System.Decimal? ResolutionProposalThresholdPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_Tl9YF9p-Ed-ak6NoX_4Aeg_-507959474")]
    [DisplayName("Total Number Of Securities Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfSctiesOutsdng")]
    #endif
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #else
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_Tl9YGNp-Ed-ak6NoX_4Aeg_-507959201")]
    [DisplayName("Total Number Of Voting Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfVtngRghts")]
    #endif
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfVotingRights { get; init; } 
    #else
    public System.UInt64? TotalNumberOfVotingRights { get; set; } 
    #endif
    
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_Tl9YGdp-Ed-ak6NoX_4Aeg_-507959122")]
    [DisplayName("Proxy Appointment Notification Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyAppntmntNtfctnAdr")]
    #endif
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    #else
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that no proxy is allowed for a meeting.
    /// </summary>
    [IsoId("_TmHJENp-Ed-ak6NoX_4Aeg_-507959166")]
    [DisplayName("Proxy Not Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyNotAllwd")]
    #endif
    [IsoXmlTag("PrxyNotAllwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProxyNotAllowedCode? ProxyNotAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyNotAllowedCode? ProxyNotAllowed { get; init; } 
    #else
    public ProxyNotAllowedCode? ProxyNotAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the elements required to assign a proxy.
    /// </summary>
    [IsoId("_TmHJEdp-Ed-ak6NoX_4Aeg_-507958985")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProxyAppointmentInformation1? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyAppointmentInformation1? Proxy { get; init; } 
    #else
    public ProxyAppointmentInformation1? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_TmHJEtp-Ed-ak6NoX_4Aeg_-207913774")]
    [DisplayName("Contact Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsnDtls")]
    #endif
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson1> ContactPersonDetails { get; init; } = new ValueList<MeetingContactPerson1>(){};
    
    /// <summary>
    /// Date on which a company publishes the results of its meeting.
    /// </summary>
    [IsoId("_TmHJE9p-Ed-ak6NoX_4Aeg_-507959184")]
    [DisplayName("Result Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltPblctnDt")]
    #endif
    [IsoXmlTag("RsltPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    #else
    public DateFormat3Choice_? ResultPublicationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
