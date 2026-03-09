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
/// Information about a meeting, participation requirements and voting procedures.
/// </summary>
[IsoId("_WbwwURreEeyhRdHRjakS2w")]
[DisplayName("Meeting Notice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingNotice7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingNotice7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingNotice7( System.String reqMeetingIdentification,MeetingType4Code reqType )
    {
        MeetingIdentification = reqMeetingIdentification;
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    [IsoId("_WwxXAxreEeyhRdHRjakS2w")]
    [DisplayName("Meeting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgId")]
    #endif
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MeetingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MeetingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MeetingIdentification { get; init; } 
    #else
    public System.String MeetingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_WwxXBRreEeyhRdHRjakS2w")]
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
    /// Type of security holders meeting.
    /// </summary>
    [IsoId("_WwxXBxreEeyhRdHRjakS2w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingType4Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingType4Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingType4Code Type { get; init; } 
    #else
    public MeetingType4Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    [IsoId("_WwxXCRreEeyhRdHRjakS2w")]
    [DisplayName("Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clssfctn")]
    #endif
    [IsoXmlTag("Clssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    #else
    public MeetingTypeClassification2Choice_? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_WwxXCxreEeyhRdHRjakS2w")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the meeting vote is held under the &quot;one-man-one-vote&quot; principle, also known as &quot;per capita vote&quot; whereby the shareholder attending the meeting has one vote only, regardless of the holding positions.
    /// </summary>
    [IsoId("_WwxXDRreEeyhRdHRjakS2w")]
    [DisplayName("One Man One Vote Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneManOneVoteInd")]
    #endif
    [IsoXmlTag("OneManOneVoteInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OneManOneVoteIndicator { get; init; } 
    #else
    public System.String? OneManOneVoteIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    [IsoId("_WwxXDxreEeyhRdHRjakS2w")]
    [DisplayName("Participation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtcptn")]
    #endif
    [IsoXmlTag("Prtcptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ParticipationMethod2? Participation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParticipationMethod2? Participation { get; init; } 
    #else
    public ParticipationMethod2? Participation { get; set; } 
    #endif
    
    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    [IsoId("_WwxXERreEeyhRdHRjakS2w")]
    [DisplayName("Attendance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attndnc")]
    #endif
    [IsoXmlTag("Attndnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Attendance2? Attendance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Attendance2? Attendance { get; init; } 
    #else
    public Attendance2? Attendance { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_WwxXExreEeyhRdHRjakS2w")]
    [DisplayName("Additional Documentation URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDcmnttnURLAdr")]
    #endif
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? AdditionalDocumentationURLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalDocumentationURLAddress { get; init; } 
    #else
    public System.String? AdditionalDocumentationURLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Provides web address of an account servicer (or of a service provider) that contains information solely intended for the immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_TaszERreEeyhRdHRjakS2w")]
    [DisplayName("Event Processing Web Site Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtPrcgWebSiteAdr")]
    #endif
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventProcessingWebSiteAddress { get; init; } 
    #else
    public System.String? EventProcessingWebSiteAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_WwxXFRreEeyhRdHRjakS2w")]
    [DisplayName("Additional Procedure Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPrcdrDtls")]
    #endif
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights3> AdditionalProcedureDetails { get; init; } = new ValueList<AdditionalRights3>(){};
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_WwxXFxreEeyhRdHRjakS2w")]
    [DisplayName("Total Number Of Securities Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfSctiesOutsdng")]
    #endif
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_WwxXGRreEeyhRdHRjakS2w")]
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
    [IsoId("_WwxXGxreEeyhRdHRjakS2w")]
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
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    [IsoId("_WwxXHRreEeyhRdHRjakS2w")]
    [DisplayName("Proxy Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyChc")]
    #endif
    [IsoXmlTag("PrxyChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy5Choice_? ProxyChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy5Choice_? ProxyChoice { get; init; } 
    #else
    public Proxy5Choice_? ProxyChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_WwxXHxreEeyhRdHRjakS2w")]
    [DisplayName("Contact Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsnDtls")]
    #endif
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson3> ContactPersonDetails { get; init; } = new ValueList<MeetingContactPerson3>(){};
    
    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_WwxXIRreEeyhRdHRjakS2w")]
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
    
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_WwxXIxreEeyhRdHRjakS2w")]
    [DisplayName("Securities Blocking Period End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgPrdEndDt")]
    #endif
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    #else
    public System.DateTime? SecuritiesBlockingPeriodEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement, for example, record date, book close date.
    /// </summary>
    [IsoId("_WwxXJRreEeyhRdHRjakS2w")]
    [DisplayName("Entitlement Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntFxgDt")]
    #endif
    [IsoXmlTag("EntitlmntFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat1? EntitlementFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat1? EntitlementFixingDate { get; init; } 
    #else
    public DateFormat1? EntitlementFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_WwxXJxreEeyhRdHRjakS2w")]
    [DisplayName("Registration Securities Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesDdln")]
    #endif
    [IsoXmlTag("RegnSctiesDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #else
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_WwxXKRreEeyhRdHRjakS2w")]
    [DisplayName("Registration Securities Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesMktDdln")]
    #endif
    [IsoXmlTag("RegnSctiesMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
