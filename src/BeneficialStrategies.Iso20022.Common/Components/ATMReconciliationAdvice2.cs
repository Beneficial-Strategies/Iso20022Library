// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation of an ATM.
/// </summary>
[IsoId("_MEvd0a47EeWRfYPBaeOY8w")]
[DisplayName("ATM Reconciliation Advice")]
public partial record ATMReconciliationAdvice2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_MPxpIa47EeWRfYPBaeOY8w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment10 Environment { get; init; } 
    
    /// <summary>
    /// Command result for reinitialisation of the transaction counters.
    /// </summary>
    [IsoId("_MPxpI647EeWRfYPBaeOY8w")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ATMCommand8? CommandResult { get; init; } 
    
    /// <summary>
    /// Party which has requested the reconciliation.
    /// </summary>
    [IsoId("_MPxpJa47EeWRfYPBaeOY8w")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand9? CommandContext { get; init; } 
    
    /// <summary>
    /// Information about the reconciliation request.
    /// </summary>
    [IsoId("_MPxpJ647EeWRfYPBaeOY8w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction25 Transaction { get; init; } 
    
    
    #nullable disable
    
}
