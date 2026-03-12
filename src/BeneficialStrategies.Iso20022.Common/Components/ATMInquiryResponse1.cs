// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM inquiry from an ATM manager.
/// </summary>
[IsoId("__fAEAIqwEeSIDtZ76p6McQ")]
[DisplayName("ATM Inquiry Response")]
public partial record ATMInquiryResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_7KDnkIqxEeSIDtZ76p6McQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment5 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    [IsoId("_ovjlsIqyEeSIDtZ76p6McQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext6 Context { get; init; } 
    
    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    [IsoId("_JYrM8IqzEeSIDtZ76p6McQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction7 Transaction { get; init; } 
    
    
    #nullable disable
    
}
