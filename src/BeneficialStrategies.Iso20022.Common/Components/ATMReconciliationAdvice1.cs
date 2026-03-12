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
[IsoId("_bn_okIttEeSLQutgI1Ulfw")]
[DisplayName("ATM Reconciliation Advice")]
public partial record ATMReconciliationAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_NRDiwItuEeSLQutgI1Ulfw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment10 Environment { get; init; } 
    
    /// <summary>
    /// Command result for reinitialisation of the transaction counters.
    /// </summary>
    [IsoId("_c9-5MItvEeSLQutgI1Ulfw")]
    [DisplayName("Command Result")]
    [IsoXmlTag("CmdRslt")]
    public ATMCommand5? CommandResult { get; init; } 
    
    /// <summary>
    /// Party which has requested the reconciliation.
    /// </summary>
    [IsoId("_8LpZoItwEeSLQutgI1Ulfw")]
    [DisplayName("Command Context")]
    [IsoXmlTag("CmdCntxt")]
    public ATMCommand6? CommandContext { get; init; } 
    
    /// <summary>
    /// Information about the reconciliation request.
    /// </summary>
    [IsoId("_uCBXEItxEeSLQutgI1Ulfw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction11 Transaction { get; init; } 
    
    
    #nullable disable
    
}
