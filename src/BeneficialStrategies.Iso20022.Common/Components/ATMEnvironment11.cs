// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
[IsoId("_96Bd4a1xEeWMg5rOByfExw")]
[DisplayName("ATM Environment")]
public partial record ATMEnvironment11
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_-HIs0a1xEeWMg5rOByfExw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 
    
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_-HIs061xEeWMg5rOByfExw")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_-HIs1a1xEeWMg5rOByfExw")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_-HIs161xEeWMg5rOByfExw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine9 ATM { get; init; } 
    
    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_-HIs2a1xEeWMg5rOByfExw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer4 Customer { get; init; } 
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_-HIs261xEeWMg5rOByfExw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard22? Card { get; init; } 
    
    
    #nullable disable
    
}
