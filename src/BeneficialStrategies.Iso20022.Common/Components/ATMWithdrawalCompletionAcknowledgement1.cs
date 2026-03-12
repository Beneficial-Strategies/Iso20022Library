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
[IsoId("_iAvFoIqkEeS4a4abTJTSSw")]
[DisplayName("ATM Withdrawal Completion Acknowledgement")]
public partial record ATMWithdrawalCompletionAcknowledgement1
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_J3exMIqlEeS4a4abTJTSSw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_S248MIqlEeS4a4abTJTSSw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext2 Context { get; init; } 
    
    /// <summary>
    /// Acknowledgement of the withdrawal completion advice.
    /// </summary>
    [IsoId("_l5XuoIqlEeS4a4abTJTSSw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction4 Transaction { get; init; } 
    
    
    #nullable disable
    
}
