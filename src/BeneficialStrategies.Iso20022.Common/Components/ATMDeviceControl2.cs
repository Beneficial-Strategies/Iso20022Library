// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the control of an ATM device.
/// </summary>
[IsoId("_GmxrcV27EeekzJIz1JxYSQ")]
[DisplayName("ATM Device Control")]
public partial record ATMDeviceControl2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Gv_44V27EeekzJIz1JxYSQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; } 
    
    /// <summary>
    /// Maintenance command the ATM must perform.
    /// </summary>
    [IsoId("_Gv_44127EeekzJIz1JxYSQ")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand10? Command { get; init; } 
    
    
    #nullable disable
    
}
