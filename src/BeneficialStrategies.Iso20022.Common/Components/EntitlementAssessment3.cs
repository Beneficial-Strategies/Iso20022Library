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
[IsoId("_HEDOEVuDEeSmO6RkXg92Lg")]
[DisplayName("Entitlement Assessment")]
public record EntitlementAssessment3
{
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_HfuddVuDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Deadline")]
    [IsoXmlTag("SctiesBlckgDdln")]
    public DateFormat29Choice_? SecuritiesBlockingDeadline { get; init; }

    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer (STP mode).
    /// </summary>
    [IsoId("_Hfudd1uDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking STP Deadline")]
    [IsoXmlTag("SctiesBlckgSTPDdln")]
    public DateFormat29Choice_? SecuritiesBlockingSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_HfudeVuDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Market Deadline")]
    [IsoXmlTag("SctiesBlckgMktDdln")]
    public DateFormat29Choice_? SecuritiesBlockingMarketDeadline { get; init; }

    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_Hfude1uDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Period End Date")]
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; }

    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, for example. record date, book close date.
    /// </summary>
    [IsoId("_HfudfVuDEeSmO6RkXg92Lg")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    public DateFormat1? EntitlementFixingDate { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_Hfudf1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities Deadline")]
    [IsoXmlTag("RegnSctiesDdln")]
    public DateFormat29Choice_? RegistrationSecuritiesDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_HfudgVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities STP Deadline")]
    [IsoXmlTag("RegnSctiesSTPDdln")]
    public DateFormat29Choice_? RegistrationSecuritiesSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Hfudg1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities Market Deadline")]
    [IsoXmlTag("RegnSctiesMktDdln")]
    public DateFormat29Choice_? RegistrationSecuritiesMarketDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_HfudhVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation Deadline")]
    [IsoXmlTag("RegnPrtcptnDdln")]
    public DateFormat29Choice_? RegistrationParticipationDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_Hfudh1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation STP Deadline")]
    [IsoXmlTag("RegnPrtcptnSTPDdln")]
    public DateFormat29Choice_? RegistrationParticipationSTPDeadline { get; init; }

    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_HfudiVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation Market Deadline")]
    [IsoXmlTag("RegnPrtcptnMktDdln")]
    public DateFormat29Choice_? RegistrationParticipationMarketDeadline { get; init; }

    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    [IsoId("_Hfudi1uDEeSmO6RkXg92Lg")]
    [DisplayName("Entitlement")]
    [IsoXmlTag("Entitlmnt")]
    public Entitlement1Choice_? Entitlement { get; init; }
}
