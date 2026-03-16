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
[IsoId("_RwgGofNrEeqRfth943bvEA")]
[DisplayName("Individual Person")]
public record IndividualPerson42
{
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    [IsoId("_SFL9M_NrEeqRfth943bvEA")]
    [DisplayName("Preassigned Proxy")]
    [IsoXmlTag("PrssgndPrxy")]
    public PartyIdentification232Choice_? PreassignedProxy { get; init; }

    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_SFL9NfNrEeqRfth943bvEA")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification129Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    [IsoId("_SFL9N_NrEeqRfth943bvEA")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard3 AttendanceCardDetails { get; init; }
}
