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
[IsoId("_FVtuAQuJEeqYM5yH99IYQw")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext28
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_FgqZwQuJEeqYM5yH99IYQw")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext27? PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_FgqZwwuJEeqYM5yH99IYQw")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext4? SaleContext { get; init; }

    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_FgqZxQuJEeqYM5yH99IYQw")]
    [DisplayName("Direct Debit Context")]
    [IsoXmlTag("DrctDbtCntxt")]
    public CardDirectDebit2? DirectDebitContext { get; init; }
}
