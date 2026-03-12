// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("__Y3nkYtEEeSxlKlAGYErFg")]
[DisplayName("ATM Environment")]
public partial record ATMEnvironment7
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("__lr7kYtEEeSxlKlAGYErFg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 
    
    /// <summary>
    /// Institution in charge of managing the ATM.
    /// </summary>
    [IsoId("__lr7k4tEEeSxlKlAGYErFg")]
    [DisplayName("ATM Manager")]
    [IsoXmlTag("ATMMgr")]
    public Acquirer8? ATMManager { get; init; } 
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("__lr7lYtEEeSxlKlAGYErFg")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("__lr7l4tEEeSxlKlAGYErFg")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    
    
    #nullable disable
    
}
