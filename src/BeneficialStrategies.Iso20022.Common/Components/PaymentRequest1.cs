// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data required to request a Payment.
/// </summary>
[IsoId("_afOuoNt-EeiXqq0XHEoNUA")]
[DisplayName("Payment Request")]
public partial record PaymentRequest1
{
    #nullable enable
    
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_iOcdENt-EeiXqq0XHEoNUA")]
    [DisplayName("Payment Transaction")]
    [IsoXmlTag("PmtTx")]
    public CardPaymentTransaction91? PaymentTransaction { get; init; } 
    
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_6xSugNuDEeiXqq0XHEoNUA")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public LoyaltyRequestData1? LoyaltyData { get; init; } 
    
    
    #nullable disable
    
}
