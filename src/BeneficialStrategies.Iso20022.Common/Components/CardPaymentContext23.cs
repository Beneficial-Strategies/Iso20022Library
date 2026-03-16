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
[IsoId("_XMF5cbDIEeaW-9Sj0pzN5A")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext23
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_XWl5QbDIEeaW-9Sj0pzN5A")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public required PaymentContext23 PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_XWl5Q7DIEeaW-9Sj0pzN5A")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext2? SaleContext { get; init; }
}
