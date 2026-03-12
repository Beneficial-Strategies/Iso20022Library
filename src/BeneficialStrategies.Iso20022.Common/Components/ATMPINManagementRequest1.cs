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
[IsoId("_lJ1JQIq_EeSgLpgNvMAP2g")]
[DisplayName("ATMPIN Management Request")]
public partial record ATMPINManagementRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the transaction is performed.
    /// </summary>
    [IsoId("_3c5Q8Iq_EeSgLpgNvMAP2g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment1 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_IIPM4IrAEeSgLpgNvMAP2g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext7 Context { get; init; } 
    
    /// <summary>
    /// Transaction for which the service is requested.
    /// </summary>
    [IsoId("_AIVhoIrBEeSgLpgNvMAP2g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction9 Transaction { get; init; } 
    
    
    #nullable disable
    
}
