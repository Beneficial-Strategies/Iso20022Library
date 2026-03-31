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
[IsoId("_X0GdZbIPEemux5trsZcCpw")]
[DisplayName("Individual Person")]
public record IndividualPerson40
{
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    [IsoId("_X0GdabIPEemux5trsZcCpw")]
    [DisplayName("Preassigned Proxy")]
    [IsoXmlTag("PrssgndPrxy")]
    public PartyIdentification223Choice_? PreassignedProxy { get; init; }

    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    [IsoId("_X0GdaLIPEemux5trsZcCpw")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification129Choice_? EmployingParty { get; init; }
}
