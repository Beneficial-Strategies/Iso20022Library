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
[IsoId("_DhaBEa4KEeWZgJQOa6iKCQ")]
[DisplayName("ATM Withdrawal Completion Advice")]
public partial record ATMWithdrawalCompletionAdvice2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_DtofMa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment13 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_DtofM64KEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext9 Context { get; init; } 
    
    /// <summary>
    /// Withdrawal transaction for which the completion is sent.
    /// </summary>
    [IsoId("_DtofNa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction17 Transaction { get; init; } 
    
    
    #nullable disable
    
}
