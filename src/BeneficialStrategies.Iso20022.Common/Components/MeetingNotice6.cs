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
[IsoId("_9YWLsfKvEeqRfth943bvEA")]
[DisplayName("Meeting Notice")]
public record MeetingNotice6
{
    /// <summary>
    /// Identification assigned to the general meeting by the party that provides the meeting notification. It must be unique to the party providing the notification
    /// </summary>
    [IsoId("_9tCCQ_KvEeqRfth943bvEA")]
    [DisplayName("Meeting Identification")]
    [IsoXmlTag("MtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MeetingIdentification { get; init; }

    /// <summary>
    /// Identification assigned to the meeting by the issuer. It must be unique for the issuer.
    /// </summary>
    [IsoId("_9tCCRfKvEeqRfth943bvEA")]
    [DisplayName("Issuer Meeting Identification")]
    [IsoXmlTag("IssrMtgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerMeetingIdentification { get; init; }

    /// <summary>
    /// Type of security holders meeting.
    /// </summary>
    [IsoId("_9tCCR_KvEeqRfth943bvEA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MeetingType4Code Type { get; init; }

    /// <summary>
    /// Classification of the meeting.
    /// </summary>
    [IsoId("_9tCCSfKvEeqRfth943bvEA")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MeetingTypeClassification2Choice_? Classification { get; init; }

    /// <summary>
    /// Official meeting announcement date.
    /// </summary>
    [IsoId("_9tCCS_KvEeqRfth943bvEA")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateAndDateTime2Choice_? AnnouncementDate { get; init; }

    /// <summary>
    /// Indicates whether the meeting vote is held under the &quot;one-man-one-vote&quot; principle, also known as &quot;per capita vote&quot; whereby the shareholder attending the meeting has one vote only, regardless of the holding positions.
    /// </summary>
    [IsoId("_0wBlkPNgEeqRfth943bvEA")]
    [DisplayName("One Man One Vote Indicator")]
    [IsoXmlTag("OneManOneVoteInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OneManOneVoteIndicator { get; init; }

    /// <summary>
    /// Method of voting participation to the general meeting and related voting deadline per method of participation.
    /// </summary>
    [IsoId("_9tCCTfKvEeqRfth943bvEA")]
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public ValueList<ParticipationMethod1> Participation { get; init; } = [];

    /// <summary>
    /// Information and conditions for physical attendance at the general meeting.
    /// </summary>
    [IsoId("_9tCCT_KvEeqRfth943bvEA")]
    [DisplayName("Attendance")]
    [IsoXmlTag("Attndnc")]
    public Attendance2? Attendance { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where additional information on the meeting may be found.
    /// </summary>
    [IsoId("_9tCCUfKvEeqRfth943bvEA")]
    [DisplayName("Additional Documentation URL Address")]
    [IsoXmlTag("AddtlDcmnttnURLAdr")]
    public SimpleValueList<IsoMax2048Text> AdditionalDocumentationURLAddress { get; init; } = [];

    /// <summary>
    /// Additional procedural information about the general meeting, specifying the participation requirements and the voting procedures. Alternatively, this may indicate where such information may be obtained.
    /// </summary>
    [IsoId("_9tCCU_KvEeqRfth943bvEA")]
    [DisplayName("Additional Procedure Details")]
    [IsoXmlTag("AddtlPrcdrDtls")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<AdditionalRights3> AdditionalProcedureDetails { get; init; } = [];

    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_9tCCVfKvEeqRfth943bvEA")]
    [DisplayName("Total Number Of Securities Outstanding")]
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    public FinancialInstrumentQuantity18Choice_? TotalNumberOfSecuritiesOutstanding { get; init; }

    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_9tCCV_KvEeqRfth943bvEA")]
    [DisplayName("Total Number Of Voting Rights")]
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfVotingRights { get; init; }

    /// <summary>
    /// Address where the information on the proxy should be sent.
    /// </summary>
    [IsoId("_9tCCWfKvEeqRfth943bvEA")]
    [DisplayName("Proxy Appointment Notification Address")]
    [IsoXmlTag("PrxyAppntmntNtfctnAdr")]
    public PostalAddress1? ProxyAppointmentNotificationAddress { get; init; }

    /// <summary>
    /// Specifies the proxy or whether a proxy is not allowed.
    /// </summary>
    [IsoId("_9tCCW_KvEeqRfth943bvEA")]
    [DisplayName("Proxy Choice")]
    [IsoXmlTag("PrxyChc")]
    public Proxy4Choice_? ProxyChoice { get; init; }

    /// <summary>
    /// Contact person at the party organising the meeting, at the issuer or at an intermediary.
    /// </summary>
    [IsoId("_9tCCXfKvEeqRfth943bvEA")]
    [DisplayName("Contact Person Details")]
    [IsoXmlTag("CtctPrsnDtls")]
    [MinLength(0)]
    [MaxLength(12)]
    public ValueList<MeetingContactPerson3> ContactPersonDetails { get; init; } = [];

    /// <summary>
    /// Date on which the company publishes the results of its meeting.
    /// </summary>
    [IsoId("_9tCCX_KvEeqRfth943bvEA")]
    [DisplayName("Result Publication Date")]
    [IsoXmlTag("RsltPblctnDt")]
    public DateFormat3Choice_? ResultPublicationDate { get; init; }

    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_9tCCYfKvEeqRfth943bvEA")]
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; }

    /// <summary>
    /// Date at which the positions are struck to record which parties will receive the entitlement, for example, record date, book close date.
    /// </summary>
    [IsoId("_9tCCY_KvEeqRfth943bvEA")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_9tCCZfKvEeqRfth943bvEA")]
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_9tCCZ_KvEeqRfth943bvEA")]
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat58Choice_? RegistrationSecuritiesMarketDeadline { get; init; }
}
