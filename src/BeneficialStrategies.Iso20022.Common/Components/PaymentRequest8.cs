// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data required to request a Payment.
/// </summary>
[IsoId("_iBmSwbZYEfCUZfsQO4rYeA")]
[DisplayName("Payment Request8")]
public record PaymentRequest8
{
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_iCgRtbZYEfCUZfsQO4rYeA")]
    [DisplayName("Payment Transaction")]
    [IsoXmlTag("PmtTx")]
    public PaymentTransaction183? PaymentTransaction { get; init; }

    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_iCgRu7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];
}
