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
[IsoId("_XPBhMdpsEeearpaEPXv9UA")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext26
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_XXrG4dpsEeearpaEPXv9UA")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext24? PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_XXrG49psEeearpaEPXv9UA")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext2? SaleContext { get; init; }

    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_fJgEcNpsEeearpaEPXv9UA")]
    [DisplayName("Direct Debit Context")]
    [IsoXmlTag("DrctDbtCntxt")]
    public CardDirectDebit1? DirectDebitContext { get; init; }
}
