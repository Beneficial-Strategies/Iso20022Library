// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Environment18.
/// </summary>
[IsoId("_j1y9IaErEe-MRKYsaX6JDg")]
[DisplayName("ATM Environment18")]
public partial record ATMEnvironment18
{
    #nullable enable

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 

    /// <summary>
    /// ATM.
    /// </summary>
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine12 ATM { get; init; } 

    /// <summary>
    /// ATM Manager Identification.
    /// </summary>
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    public IsoMax35Text? ATMManagerIdentification { get; init; } 

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard36? Card { get; init; } 

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer8 Customer { get; init; } 

    /// <summary>
    /// Hosting Entity.
    /// </summary>
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 

    
    #nullable disable
    
}
