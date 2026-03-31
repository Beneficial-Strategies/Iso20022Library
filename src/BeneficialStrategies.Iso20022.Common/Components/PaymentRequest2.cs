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
[IsoId("_iaHBoQ1HEeqjM-rxn3HuXQ")]
[DisplayName("Payment Request")]
public record PaymentRequest2
{
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_ioFMMQ1HEeqjM-rxn3HuXQ")]
    [DisplayName("Payment Transaction")]
    [IsoXmlTag("PmtTx")]
    public CardPaymentTransaction100? PaymentTransaction { get; init; }

    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_ioFMMw1HEeqjM-rxn3HuXQ")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData2> LoyaltyData { get; init; } = [];
}
