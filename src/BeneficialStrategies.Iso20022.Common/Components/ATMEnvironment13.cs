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
[IsoId("_KRspIa4KEeWZgJQOa6iKCQ")]
[DisplayName("ATM Environment")]
public partial record ATMEnvironment13
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_KdxWQa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 
    
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_KdxWQ64KEeWZgJQOa6iKCQ")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_KdxWRa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_KdxWR64KEeWZgJQOa6iKCQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine9 ATM { get; init; } 
    
    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_KdxWSa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer6 Customer { get; init; } 
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_KdxWS64KEeWZgJQOa6iKCQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard23? Card { get; init; } 
    
    
    #nullable disable
    
}
