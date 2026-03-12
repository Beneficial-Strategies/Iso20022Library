// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Logout Request message.
/// </summary>
[IsoId("_pv3ZIN6JEeiwsev40qZGEQ")]
[DisplayName("Logout Request")]
public partial record LogoutRequest1
{
    #nullable enable
    
    /// <summary>
    /// Indicates that the POI terminal is able to go(or have to go) to maintenance.
    /// </summary>
    [IsoId("_z9QaMN6JEeiwsev40qZGEQ")]
    [DisplayName("Maintenance Allowed")]
    [IsoXmlTag("MntncAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceAllowed { get; init; } 
    
    
    #nullable disable
    
}
