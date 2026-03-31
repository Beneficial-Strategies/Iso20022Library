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
[IsoId("_Sv8c7AEcEeCQm6a_G2yO_w_1757665416")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext1
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_Sv8c7QEcEeCQm6a_G2yO_w_-489437241")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public required PaymentContext1 PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_SwFm0AEcEeCQm6a_G2yO_w_-369547769")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext1? SaleContext { get; init; }
}
