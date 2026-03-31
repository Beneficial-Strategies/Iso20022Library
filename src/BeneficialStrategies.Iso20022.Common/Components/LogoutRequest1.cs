// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Logout Request message.
/// </summary>
[IsoId("_pv3ZIN6JEeiwsev40qZGEQ")]
[DisplayName("Logout Request")]
public record LogoutRequest1
{
    /// <summary>
    /// Indicates that the POI terminal is able to go(or have to go) to maintenance.
    /// </summary>
    [IsoId("_z9QaMN6JEeiwsev40qZGEQ")]
    [DisplayName("Maintenance Allowed")]
    [IsoXmlTag("MntncAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceAllowed { get; init; }
}
