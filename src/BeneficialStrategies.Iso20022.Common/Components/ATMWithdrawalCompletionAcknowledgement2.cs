// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM withdrawal from the ATM manager.
/// </summary>
[IsoId("_eR-ZMa4NEeWZgJQOa6iKCQ")]
[DisplayName("ATM Withdrawal Completion Acknowledgement")]
public partial record ATMWithdrawalCompletionAcknowledgement2
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_ecj4ka4NEeWZgJQOa6iKCQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_ecj4k64NEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext9 Context { get; init; } 
    
    /// <summary>
    /// Acknowledgement of the withdrawal completion advice.
    /// </summary>
    [IsoId("_ecj4la4NEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction18 Transaction { get; init; } 
    
    
    #nullable disable
    
}
