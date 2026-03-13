// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting, participation requirements and voting procedures.
/// </summary>
[IsoId("_WbwwURreEeyhRdHRjakS2w")]
[DisplayName("Meeting Notice")]
public partial record MeetingNotice7
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    [IsoId("_WwxXAxreEeyhRdHRjakS2w")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MeetingIdentification { get; init; } 
    
    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_WwxXBRreEeyhRdHRjakS2w")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; } 
    
    /// <summary>
    /// Type of security holders meeting.
    /// </summary>
    [IsoId("_WwxXBxreEeyhRdHRjakS2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; } 
    
    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    [IsoId("_WwxXCRreEeyhRdHRjakS2w")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice_? Classification { get; init; } 
    
    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_WwxXCxreEeyhRdHRjakS2w")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the meeting vote is held under the &quot;one-man-one-vote&quot; principle, also known as &quot;per capita vote&quot; whereby the shareholder attending the meeting has one vote only, regardless of the holding positions.
    /// </summary>
    [IsoId("_WwxXDRreEeyhRdHRjakS2w")]
    [DisplayName("One Man One Vote Indicator")]
    [IsoXmlTag("OneManOneVoteInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; } 
    
    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    [IsoId("_WwxXDxreEeyhRdHRjakS2w")]
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public ParticipationMethod2? Participation { get; init; } 
    
    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    [IsoId("_WwxXERreEeyhRdHRjakS2w")]
    [DisplayName("Attendance")]
    [IsoXmlTag("Attndnc")]
    public Attendance2? Attendance { get; init; } 
    
    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_WwxXExreEeyhRdHRjakS2w")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? AdditionalDocumentationURLAddress { get; init; } 
    
    /// <summary>
    /// Provides web address of an account servicer (or of a service provider) that contains information solely intended for the immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_TaszERreEeyhRdHRjakS2w")]
    [DisplayName("Event Processing Web Site Address")]
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; } 
    
    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_WwxXFRreEeyhRdHRjakS2w")]
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights3> AdditionalProcedureDetails { get; init; } = [];
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_WwxXFxreEeyhRdHRjakS2w")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; } 
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_WwxXGRreEeyhRdHRjakS2w")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    
    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_WwxXGxreEeyhRdHRjakS2w")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; } 
    
    /// <summary>
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    [IsoId("_WwxXHRreEeyhRdHRjakS2w")]
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy5Choice_? ProxyChoice { get; init; } 
    
    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_WwxXHxreEeyhRdHRjakS2w")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson3> ContactPersonDetails { get; init; } = [];
    
    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_WwxXIRreEeyhRdHRjakS2w")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; } 
    
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_WwxXIxreEeyhRdHRjakS2w")]
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    
    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement, for example, record date, book close date.
    /// </summary>
    [IsoId("_WwxXJRreEeyhRdHRjakS2w")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; } 
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_WwxXJxreEeyhRdHRjakS2w")]
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_WwxXKRreEeyhRdHRjakS2w")]
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    
    
    #nullable disable
    
}
