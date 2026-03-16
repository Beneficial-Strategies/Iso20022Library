// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters, such as dates, used to calculate the entitlement to vote at a general meeting.
/// </summary>
[IsoId("_TmHJH9p-Ed-ak6NoX_4Aeg_-30513816")]
[DisplayName("Entitlement Assessment")]
public record EntitlementAssessment1
{
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_TmQTANp-Ed-ak6NoX_4Aeg_-30513814")]
    [DisplayName("Securities Blocking Deadline")]
    [IsoXmlTag("SctiesBlckgDdln")]
    public DateFormat2Choice_? SecuritiesBlockingDeadline { get; init; }

    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer. (STP mode).
    /// </summary>
    [IsoId("_TmQTAdp-Ed-ak6NoX_4Aeg_2054659303")]
    [DisplayName("Securities Blocking STP Deadline")]
    [IsoXmlTag("SctiesBlckgSTPDdln")]
    public DateFormat2Choice_? SecuritiesBlockingSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmQTAtp-Ed-ak6NoX_4Aeg_-30513799")]
    [DisplayName("Securities Blocking Market Deadline")]
    [IsoXmlTag("SctiesBlckgMktDdln")]
    public DateFormat2Choice_? SecuritiesBlockingMarketDeadline { get; init; }

    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_TmQTA9p-Ed-ak6NoX_4Aeg_-30513781")]
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; }

    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, e.g. record date, book close date.
    /// </summary>
    [IsoId("_TmQTBNp-Ed-ak6NoX_4Aeg_-30513444")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat3Choice_? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TmQTBdp-Ed-ak6NoX_4Aeg_-120826273")]
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat2Choice_? RegistrationSecuritiesDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TmQTBtp-Ed-ak6NoX_4Aeg_46327692")]
    [DisplayName("Registration Securities STP Deadline")]
    [IsoXmlTag("RegnSctiesSTPDdln")]
    public DateFormat2Choice_? RegistrationSecuritiesSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmQTB9p-Ed-ak6NoX_4Aeg_305836980")]
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat2Choice_? RegistrationSecuritiesMarketDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TmQTCNp-Ed-ak6NoX_4Aeg_453602280")]
    [DisplayName("Registration Participation Deadline")]
    [IsoXmlTag("RegnPrtcptnDdln")]
    public DateFormat2Choice_? RegistrationParticipationDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TmQTCdp-Ed-ak6NoX_4Aeg_722345516")]
    [DisplayName("Registration Participation STP Deadline")]
    [IsoXmlTag("RegnPrtcptnSTPDdln")]
    public DateFormat2Choice_? RegistrationParticipationSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmaEANp-Ed-ak6NoX_4Aeg_735277287")]
    [DisplayName("Registration Participation Market Deadline")]
    [IsoXmlTag("RegnPrtcptnMktDdln")]
    public DateFormat2Choice_? RegistrationParticipationMarketDeadline { get; init; }

    /// <summary>
    /// Specifies the calculation method of the number of votes assigned to one security. This element should be used when the entitlement calculation rule is complex.
    /// </summary>
    [IsoId("_TmaEAdp-Ed-ak6NoX_4Aeg_-30513409")]
    [DisplayName("Entitlement Description")]
    [IsoXmlTag("EntitlmntDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? EntitlementDescription { get; init; }

    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    [IsoId("_TmaEAtp-Ed-ak6NoX_4Aeg_-30513427")]
    [DisplayName("Entitlement Ratio")]
    [IsoXmlTag("EntitlmntRatio")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? EntitlementRatio { get; init; }
}
