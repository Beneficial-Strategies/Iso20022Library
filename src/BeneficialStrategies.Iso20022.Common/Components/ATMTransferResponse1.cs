// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM transfer from an ATM manager.
/// </summary>
[IsoId("_7PP2cK4xEeWpsoxRhdX-8A")]
[DisplayName("ATM Transfer Response")]
public partial record ATMTransferResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_E-Y1QK4yEeWpsoxRhdX-8A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment12 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transfer is performed.
    /// </summary>
    [IsoId("_UNOW8K4yEeWpsoxRhdX-8A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext19 Context { get; init; } 
    
    /// <summary>
    /// Transfer information for the transaction.
    /// </summary>
    [IsoId("_93engK4yEeWpsoxRhdX-8A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction24 Transaction { get; init; } 
    
    
    #nullable disable
    
}
