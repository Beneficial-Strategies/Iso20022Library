// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting, participation requirements and voting procedures.
/// </summary>
[IsoId("_WHsWwajJEfCzuLlmLrhIvA")]
[DisplayName("Meeting Notice10")]
public record MeetingNotice10
{
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification.
    /// </summary>
    [IsoId("_WPfn4ajJEfCzuLlmLrhIvA")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    public required IsoMax35Text MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the meeting by the issuer.
    /// </summary>
    [IsoId("_WPfn46jJEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Type of security holders meeting.
    /// </summary>
    [IsoId("_WPfn5ajJEfCzuLlmLrhIvA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; }

    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    [IsoId("_WPfn56jJEfCzuLlmLrhIvA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice_? Classification { get; init; }

    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_WPfn6ajJEfCzuLlmLrhIvA")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; }

    /// <summary>
    /// Indicates whether the meeting vote is held under the "one-man-one-vote" principle.
    /// </summary>
    [IsoId("_WPfn66jJEfCzuLlmLrhIvA")]
    [DisplayName("One Man One Vote Indicator")]
    [IsoXmlTag("OneManOneVoteInd")]
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; }

    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    [IsoId("_WPfn7ajJEfCzuLlmLrhIvA")]
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public ValueList<ParticipationMethod3> Participation { get; init; } = [];

    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    [IsoId("_WPfn76jJEfCzuLlmLrhIvA")]
    [DisplayName("Attendance")]
    [IsoXmlTag("Attndnc")]
    public Attendance2? Attendance { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_WPfn8ajJEfCzuLlmLrhIvA")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    public SimpleValueList<IsoMax2048Text> AdditionalDocumentationURLAddress { get; init; } = [];

    /// <summary>
    /// Web address containing information solely intended for the immediate account holder to enable or facilitate event processing.
    /// </summary>
    [IsoId("_WPfn86jJEfCzuLlmLrhIvA")]
    [DisplayName("Event Processing Web Site Address")]
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    public IsoMax2048Text? EventProcessingWebSiteAddress { get; init; }

    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures.
    /// </summary>
    [IsoId("_WPfn9ajJEfCzuLlmLrhIvA")]
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    public ValueList<AdditionalRights4> AdditionalProcedureDetails { get; init; } = [];

    /// <summary>
    /// Number of securities admitted to the vote.
    /// </summary>
    [IsoId("_WPfn96jJEfCzuLlmLrhIvA")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_WPfn-ajJEfCzuLlmLrhIvA")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_WPfn-6jJEfCzuLlmLrhIvA")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; }

    /// <summary>
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    [IsoId("_WPfn_ajJEfCzuLlmLrhIvA")]
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy5Choice_? ProxyChoice_ { get; init; }

    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_WPfn_6jJEfCzuLlmLrhIvA")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    public ValueList<MeetingContactPerson3> ContactPersonDetails { get; init; } = [];

    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_WPfoAajJEfCzuLlmLrhIvA")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; }

    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_WPfoA6jJEfCzuLlmLrhIvA")]
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    public DateFormat60Choice_? SecuritiesBlockingPeriodEndDate { get; init; }

    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement.
    /// </summary>
    [IsoId("_WPfoBajJEfCzuLlmLrhIvA")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered, specified by an intermediary.
    /// </summary>
    [IsoId("_WPfoB6jJEfCzuLlmLrhIvA")]
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered, set by the issuer.
    /// </summary>
    [IsoId("_WPfoCajJEfCzuLlmLrhIvA")]
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; }

    /// <summary>
    /// Date by which enrolment for participation must be instructed, set by the issuer.
    /// </summary>
    [IsoId("_WPfoC6jJEfCzuLlmLrhIvA")]
    [DisplayName("Enrolment Market Deadline")]
    [IsoXmlTag("EnrlmntMktDdln")]
    public DateFormat58Choice_? EnrolmentMarketDeadline { get; init; }

    /// <summary>
    /// Date by which enrolment for participation must be instructed, set by the intermediary.
    /// </summary>
    [IsoId("_WPfoDajJEfCzuLlmLrhIvA")]
    [DisplayName("Enrolment Deadline")]
    [IsoXmlTag("EnrlmntDdln")]
    public DateFormat58Choice_? EnrolmentDeadline { get; init; }
}
