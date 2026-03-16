// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Reconciliation Advice3.
/// </summary>
[IsoId("_CiOzMZ-VEe-nbM0aSPcoiQ")]
[DisplayName("ATM Reconciliation Advice3")]
public partial record ATMReconciliationAdvice3
{
    #nullable enable

    /// <summary>
    /// Command Context.
    /// </summary>
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand9? CommandContext { get; init; } 

    /// <summary>
    /// Command Result.
    /// </summary>
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ValueList<ATMCommand8> CommandResult { get; init; } = [];

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment22 Environment { get; init; } 

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction36 Transaction { get; init; } 

    
    #nullable disable
    
}
