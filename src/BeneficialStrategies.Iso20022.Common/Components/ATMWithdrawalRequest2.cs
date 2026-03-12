// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a withdrawal from an ATM.
/// </summary>
[IsoId("_Doh40a1yEeWMg5rOByfExw")]
[DisplayName("ATM Withdrawal Request")]
public partial record ATMWithdrawalRequest2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_D0TrAa1yEeWMg5rOByfExw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment11 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_D0TrA61yEeWMg5rOByfExw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext8 Context { get; init; } 
    
    /// <summary>
    /// Withdrawal transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_D0TrBa1yEeWMg5rOByfExw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction13 Transaction { get; init; } 
    
    
    #nullable disable
    
}
