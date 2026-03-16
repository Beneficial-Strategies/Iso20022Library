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
[IsoId("_UmnwQU36Eey_VecAUE-C9Q")]
[DisplayName("Payment Request")]
public record PaymentRequest4
{
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_UtDIYU36Eey_VecAUE-C9Q")]
    [DisplayName("Payment Transaction")]
    [IsoXmlTag("PmtTx")]
    public CardPaymentTransaction120? PaymentTransaction { get; init; }

    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_UtDIY036Eey_VecAUE-C9Q")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];
}
