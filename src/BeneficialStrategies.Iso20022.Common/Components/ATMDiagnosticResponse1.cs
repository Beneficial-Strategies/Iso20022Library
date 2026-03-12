// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a diagnostic from an ATM manager.
/// </summary>
[IsoId("_XQgAsItpEeSDLd7nI4Quzw")]
[DisplayName("ATM Diagnostic Response")]
public partial record ATMDiagnosticResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_nEQNUItpEeSDLd7nI4Quzw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment6 Environment { get; init; } 
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_rlVy4ItpEeSDLd7nI4Quzw")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; } 
    
    
    #nullable disable
    
}
