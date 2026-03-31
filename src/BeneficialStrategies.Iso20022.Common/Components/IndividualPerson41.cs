// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_7io28fNiEeqRfth943bvEA")]
[DisplayName("Individual Person")]
public record IndividualPerson41
{
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    [IsoId("_8LjRE_NiEeqRfth943bvEA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification232Choice_? Identification { get; init; }

    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_pwPvMPNpEeqRfth943bvEA")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public VotingParticipationMethod2Code? ParticipationMethod { get; init; }

    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_8LjRFfNiEeqRfth943bvEA")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification129Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    [IsoId("_8LjRF_NiEeqRfth943bvEA")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard3 AttendanceCardDetails { get; init; }
}
