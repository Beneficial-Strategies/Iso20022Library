// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies totals related to the invoice.
/// </summary>
[IsoId("_v9vRcUw0EfCpsI1b9uv5FQ")]
[DisplayName("Invoice Totals7")]
public record InvoiceTotals7
{
    /// <summary>
    /// Detailed information on tax applied.
    /// </summary>
    [IsoId("_xItPwUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<BillingTaxRecord2> Tax { get; init; } = [];

    /// <summary>
    /// Variance on invoice amount taking into account discounts, allowances and charges.
    /// </summary>
    [IsoId("_xItPw0w0EfCpsI1b9uv5FQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment5? Adjustment { get; init; }

    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_xItPxUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required AmountAndForeignExchange1 TotalInvoiceAmount { get; init; }

    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_xItPx0w0EfCpsI1b9uv5FQ")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    public required IsoISODate PaymentDueDate { get; init; }

    /// <summary>
    /// Cash account from which the fees are paid.
    /// </summary>
    [IsoId("_xItPyUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public AccountIdentification4Choice_? CashAccount { get; init; }
}
