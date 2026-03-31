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
[IsoId("_YhyLATAOEeOqioR9srQH1g")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext5
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_Yx2AQTAOEeOqioR9srQH1g")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public required PaymentContext5 PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_Yx2AQzAOEeOqioR9srQH1g")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext1? SaleContext { get; init; }
}
