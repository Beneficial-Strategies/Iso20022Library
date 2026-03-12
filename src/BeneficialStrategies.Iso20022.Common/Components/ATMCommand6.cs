// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party which has requested the reconciliation.
/// </summary>
[IsoId("_bScvAYtwEeSLQutgI1Ulfw")]
[DisplayName("ATM Command")]
public partial record ATMCommand6
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_bfH5EYtwEeSLQutgI1Ulfw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand3Code Type { get; init; } 
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_bfH5E4twEeSLQutgI1Ulfw")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    
    
    #nullable disable
    
}
