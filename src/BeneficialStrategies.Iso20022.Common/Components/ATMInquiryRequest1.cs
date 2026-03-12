// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of an inquiry from an ATM.
/// </summary>
[IsoId("_04cHQIqrEeSIDtZ76p6McQ")]
[DisplayName("ATM Inquiry Request")]
public partial record ATMInquiryRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the inquiry is performed.
    /// </summary>
    [IsoId("_UrtEkIqsEeSIDtZ76p6McQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment4 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    [IsoId("_n-f5AIquEeSIDtZ76p6McQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext5 Context { get; init; } 
    
    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    [IsoId("_JfAl0IqwEeSIDtZ76p6McQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction6 Transaction { get; init; } 
    
    
    #nullable disable
    
}
