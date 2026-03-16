// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Request7.
/// </summary>
[IsoId("_DIWnkZ9fEe-nbM0aSPcoiQ")]
[DisplayName("Payment Request7")]
public partial record PaymentRequest7
{
    #nullable enable

    /// <summary>
    /// Loyalty Data.
    /// </summary>
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];

    /// <summary>
    /// Payment Transaction.
    /// </summary>
    [DisplayName("Payment Transaction")]
    [IsoXmlTag("PmtTx")]
    public PaymentTransaction165? PaymentTransaction { get; init; } 

    
    #nullable disable
    
}
