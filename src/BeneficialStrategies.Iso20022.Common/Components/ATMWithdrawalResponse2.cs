// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM withdrawal from an ATM manager.
/// </summary>
[IsoId("_wifF8a16EeWMg5rOByfExw")]
[DisplayName("ATM Withdrawal Response")]
public partial record ATMWithdrawalResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_wuHHIa16EeWMg5rOByfExw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment12 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_wuHHI616EeWMg5rOByfExw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext9 Context { get; init; } 
    
    /// <summary>
    /// Response to the withdrawal transaction request.
    /// </summary>
    [IsoId("_wuHHJa16EeWMg5rOByfExw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction14 Transaction { get; init; } 
    
    
    #nullable disable
    
}
