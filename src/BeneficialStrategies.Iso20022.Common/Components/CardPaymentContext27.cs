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
[IsoId("_4XRM4dgyEeipBO1pkKK6zg")]
[DisplayName("Card Payment Context")]
public record CardPaymentContext27
{
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_4hW9AdgyEeipBO1pkKK6zg")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext26? PaymentContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_4hW9A9gyEeipBO1pkKK6zg")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext3? SaleContext { get; init; }

    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_4hW9BdgyEeipBO1pkKK6zg")]
    [DisplayName("Direct Debit Context")]
    [IsoXmlTag("DrctDbtCntxt")]
    public CardDirectDebit2? DirectDebitContext { get; init; }
}
