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
[IsoId("_Tho4zNp-Ed-ak6NoX_4Aeg_-773420460")]
[DisplayName("Invoice Totals")]
public record InvoiceTotals1
{
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_Tho4zdp-Ed-ak6NoX_4Aeg_-773420429")]
    [DisplayName("Total Taxable Amount")]
    [IsoXmlTag("TtlTaxblAmt")]
    public required ActiveCurrencyAndAmount TotalTaxableAmount { get; init; }

    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_ThypwNp-Ed-ak6NoX_4Aeg_-773420428")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public required ActiveCurrencyAndAmount TotalTaxAmount { get; init; }

    /// <summary>
    /// Variance on invoice amount taking into account discounts, allowances and charges.
    /// </summary>
    [IsoId("_Thypwdp-Ed-ak6NoX_4Aeg_2076378677")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment5? Adjustment { get; init; }

    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_Thypwtp-Ed-ak6NoX_4Aeg_-773420399")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; }

    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_Thypw9p-Ed-ak6NoX_4Aeg_-773420121")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDueDate { get; init; }
}
