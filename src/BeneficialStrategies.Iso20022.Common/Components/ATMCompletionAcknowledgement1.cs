// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM completion from the ATM manager.
/// </summary>
[IsoId("_EgQRAIqpEeS4a4abTJTSSw")]
[DisplayName("ATM Completion Acknowledgement")]
public partial record ATMCompletionAcknowledgement1
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_X_M9AIqpEeS4a4abTJTSSw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_Yomp4IqqEeS4a4abTJTSSw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext3 Context { get; init; } 
    
    /// <summary>
    /// Acknowledgement of the completion advice.
    /// </summary>
    [IsoId("_fs3W0IqqEeS4a4abTJTSSw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction4 Transaction { get; init; } 
    
    
    #nullable disable
    
}
