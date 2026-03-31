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
[IsoId("_fQtPUa-SEemJ1NnLPsTFaw")]
[DisplayName("Individual Person")]
public record IndividualPerson39
{
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    [IsoId("_fliP16-SEemJ1NnLPsTFaw")]
    [DisplayName("Preassigned Proxy")]
    [IsoXmlTag("PrssgndPrxy")]
    public PartyIdentification223Choice_? PreassignedProxy { get; init; }

    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_fliP26-SEemJ1NnLPsTFaw")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification129Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    [IsoId("_fliP3a-SEemJ1NnLPsTFaw")]
    [DisplayName("Attendance Card Details")]
    [IsoXmlTag("AttndncCardDtls")]
    public required AttendanceCard2 AttendanceCardDetails { get; init; }
}
