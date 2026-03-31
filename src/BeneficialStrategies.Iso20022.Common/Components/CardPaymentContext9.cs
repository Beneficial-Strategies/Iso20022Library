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
[IsoId("_vAyd4WluEeSGkpGpjm7tzg")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext9
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_vNdn8WluEeSGkpGpjm7tzg")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public required PaymentContext9 PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_vNdn82luEeSGkpGpjm7tzg")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext1? SaleContext { get; init; }
}
