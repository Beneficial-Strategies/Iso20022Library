// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a PIN management from an ATM.
/// </summary>
[IsoId("_clVlUa4aEeW_TaP-ygI0SQ")]
[DisplayName("ATMPIN Management Request")]
public partial record ATMPINManagementRequest2
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the transaction is performed.
    /// </summary>
    [IsoId("_cwEOoa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment11 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_cwEOo64aEeW_TaP-ygI0SQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext16 Context { get; init; } 
    
    /// <summary>
    /// Transaction for which the service is requested.
    /// </summary>
    [IsoId("_cwEOpa4aEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction9 Transaction { get; init; } 
    
    
    #nullable disable
    
}
