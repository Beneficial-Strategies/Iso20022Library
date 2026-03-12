// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a fund transfer from an ATM.
/// </summary>
[IsoId("_KJLG0K4sEeWLdt0vLARX2Q")]
[DisplayName("ATM Transfer Request")]
public partial record ATMTransferRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the fund transfer is performed.
    /// </summary>
    [IsoId("_QwCGEK4sEeWLdt0vLARX2Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment11 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the fund transfer is performed.
    /// </summary>
    [IsoId("_aevAAK4sEeWLdt0vLARX2Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public ATMContext18? Context { get; init; } 
    
    /// <summary>
    /// Transfer information for the transaction.
    /// </summary>
    [IsoId("_h8A0cK4tEeWLdt0vLARX2Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction23 Transaction { get; init; } 
    
    
    #nullable disable
    
}
