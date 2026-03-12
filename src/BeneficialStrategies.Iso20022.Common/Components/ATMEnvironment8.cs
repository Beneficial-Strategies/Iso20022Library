// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the key download.
/// </summary>
[IsoId("_PfGckYtLEeSxlKlAGYErFg")]
[DisplayName("ATM Environment")]
public partial record ATMEnvironment8
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_PrddkYtLEeSxlKlAGYErFg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 
    
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_Prddk4tLEeSxlKlAGYErFg")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_PrddlYtLEeSxlKlAGYErFg")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_Prddl4tLEeSxlKlAGYErFg")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine6 ATM { get; init; } 
    
    
    #nullable disable
    
}
