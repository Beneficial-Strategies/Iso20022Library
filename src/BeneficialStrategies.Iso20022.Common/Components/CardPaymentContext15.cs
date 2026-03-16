// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[IsoId("_taEoIY08EeWPUZwhUA4U-w")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext15
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_tlZuYY08EeWPUZwhUA4U-w")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public required PaymentContext15 PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_tlZuY408EeWPUZwhUA4U-w")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext2? SaleContext { get; init; }
}
