// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies totals related to the invoice.
/// </summary>
[IsoId("_eJ9o3mliEeGaMcKyqKNRfQ_-773420460")]
[DisplayName("Invoice Totals")]
public partial record InvoiceTotals2
{
    #nullable enable
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_eJ9o32liEeGaMcKyqKNRfQ_-773420429")]
    [DisplayName("Total Taxable Amount")]
    [IsoXmlTag("TtlTaxblAmt")]
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_eJ9o4GliEeGaMcKyqKNRfQ_-773420428")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    
    /// <summary>
    /// Variance on invoice amount taking into account discounts, allowances and charges.
    /// </summary>
    [IsoId("_eJ9o4WliEeGaMcKyqKNRfQ_2076378677")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment5? Adjustment { get; init; } 
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_eJ9o4mliEeGaMcKyqKNRfQ_-773420399")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    
    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_eJ9o42liEeGaMcKyqKNRfQ_-773420121")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDueDate { get; init; } 
    
    
    #nullable disable
    
}
