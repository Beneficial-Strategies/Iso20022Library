// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command which has requested the device report.
/// </summary>
[IsoId("_LQmKgYr4EeSvuOJS0mmL0g")]
[DisplayName("ATM Command")]
public partial record ATMCommand3
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_LejuAYr4EeSvuOJS0mmL0g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand2Code Type { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_LejuB4r4EeSvuOJS0mmL0g")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    
    #nullable disable
    
}
