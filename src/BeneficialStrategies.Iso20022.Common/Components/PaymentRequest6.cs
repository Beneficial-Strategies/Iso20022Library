// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Request6.
/// </summary>
[IsoId("_1f44sZLOEe6-zvj9Dw-ctg")]
[DisplayName("Payment Request6")]
public record PaymentRequest6
{
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
    public CardPaymentTransaction136? PaymentTransaction { get; init; }
}
