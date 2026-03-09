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
[IsoId("_6lq6QVtgEeSwKe7KuKvXhg")]
[DisplayName("Meeting Notice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingNotice4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingNotice4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingNotice4( MeetingType3Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party notifying the meeting. It must be unique for the party notifying the meeting.
    /// </summary>
    [IsoId("_7DISU1tgEeSwKe7KuKvXhg")]
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
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_7DISVVtgEeSwKe7KuKvXhg")]
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
    [IsoId("_7DISV1tgEeSwKe7KuKvXhg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingType3Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingType3Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingType3Code Type { get; init; } 
    #else
    public MeetingType3Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_7DISWVtgEeSwKe7KuKvXhg")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingTypeClassification1Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingTypeClassification1Choice_? Classification { get; init; } 
    #else
    public MeetingTypeClassification1Choice_? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_7DISW1tgEeSwKe7KuKvXhg")]
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
    /// Indicates whether physical participation to the meeting is required in order to be allowed to vote.
    /// </summary>
    [IsoId("_7DISXVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncReqrd")]
    #endif
    [IsoXmlTag("AttndncReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AttendanceRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttendanceRequired { get; init; } 
    #else
    public System.String? AttendanceRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_7DISX1tgEeSwKe7KuKvXhg")]
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
    /// Date and time by which the beneficial owner or agent must notify of its intention to participate in the meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_7DISYVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfDdln")]
    #endif
    [IsoXmlTag("AttndncConfDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? AttendanceConfirmationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? AttendanceConfirmationDeadline { get; init; } 
    #else
    public DateFormat29Choice_? AttendanceConfirmationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must notify of its intention to participate in the meeting (STP mode). This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_7DISY1tgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfSTPDdln")]
    #endif
    [IsoXmlTag("AttndncConfSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? AttendanceConfirmationSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? AttendanceConfirmationSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? AttendanceConfirmationSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_7DISZVtgEeSwKe7KuKvXhg")]
    [DisplayName("Attendance Confirmation Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncConfMktDdln")]
    #endif
    [IsoXmlTag("AttndncConfMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? AttendanceConfirmationMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? AttendanceConfirmationMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? AttendanceConfirmationMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_7DISZ1tgEeSwKe7KuKvXhg")]
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
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_7DISaVtgEeSwKe7KuKvXhg")]
    [DisplayName("Additional Procedure Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPrcdrDtls")]
    #endif
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights2> AdditionalProcedureDetails { get; init; } = new ValueList<AdditionalRights2>(){};
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_7DISa1tgEeSwKe7KuKvXhg")]
    [DisplayName("Total Number Of Securities Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfSctiesOutsdng")]
    #endif
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? TotalNumberOfSecuritiesOutstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_7DISbVtgEeSwKe7KuKvXhg")]
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
    [IsoId("_7DISb1tgEeSwKe7KuKvXhg")]
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
    /// Indicates whether a proxy is allowed.
    /// </summary>
    [IsoId("_7DIScVtgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyChc")]
    #endif
    [IsoXmlTag("PrxyChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy2Choice_? ProxyChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy2Choice_? ProxyChoice { get; init; } 
    #else
    public Proxy2Choice_? ProxyChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_7DISc1tgEeSwKe7KuKvXhg")]
    [DisplayName("Contact Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsnDtls")]
    #endif
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson2> ContactPersonDetails { get; init; } = new ValueList<MeetingContactPerson2>(){};
    
    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_7DISdVtgEeSwKe7KuKvXhg")]
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
