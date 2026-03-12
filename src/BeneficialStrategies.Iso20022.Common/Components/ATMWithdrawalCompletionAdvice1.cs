// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the completion of a withdrawal on the ATM.
/// </summary>
[IsoId("_E6Ru0IqOEeSRT5rEzcAHEw")]
[DisplayName("ATM Withdrawal Completion Advice")]
public partial record ATMWithdrawalCompletionAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_FXnVoIqPEeSRT5rEzcAHEw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment3 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_LsLOgIqQEeSRT5rEzcAHEw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext2 Context { get; init; } 
    
    /// <summary>
    /// Withdrawal transaction for which the completion is sent.
    /// </summary>
    [IsoId("_cb8-gIqQEeSRT5rEzcAHEw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction3 Transaction { get; init; } 
    
    
    #nullable disable
    
}
