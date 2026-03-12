// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a diagnostic from an ATM.
/// </summary>
[IsoId("_sdCFUItoEeSDLd7nI4Quzw")]
[DisplayName("ATM Diagnostic Request")]
public partial record ATMDiagnosticRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_65u_cItoEeSDLd7nI4Quzw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment9 Environment { get; init; } 
    
    
    #nullable disable
    
}
