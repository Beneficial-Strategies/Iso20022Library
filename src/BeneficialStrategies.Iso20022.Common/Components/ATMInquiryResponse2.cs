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
[IsoId("_iDudca4WEeW_TaP-ygI0SQ")]
[DisplayName("ATM Inquiry Response")]
public partial record ATMInquiryResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_iOdGwa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment12 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    [IsoId("_iOdGw64WEeW_TaP-ygI0SQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required ATMContext15 Context { get; init; } 
    
    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    [IsoId("_iOdGxa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction21 Transaction { get; init; } 
    
    
    #nullable disable
    
}
