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
[IsoId("_jFoQQO5NEeCisYr99QEiWA_-1267586001")]
[DisplayName("Service Item Totals")]
public partial record ServiceItemTotals1
{
    #nullable enable
    
    /// <summary>
    /// Specifies a classification for the service items such as query, report, securities account, etc….
    /// </summary>
    [IsoId("_jFoQQe5NEeCisYr99QEiWA_733684317")]
    [DisplayName("Item Type")]
    [IsoXmlTag("ItmTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ItemType { get; init; } 
    
    /// <summary>
    /// Sum of total number units per service item.
    /// </summary>
    [IsoId("_jFoQQu5NEeCisYr99QEiWA_-404470029")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Quantity { get; init; } 
    
    /// <summary>
    /// Specifies the unit of the service item.
    /// </summary>
    [IsoId("_jFoQQ-5NEeCisYr99QEiWA_-482207870")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ActiveCurrencyAndAmount? UnitPrice { get; init; } 
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_jFoQRO5NEeCisYr99QEiWA_1777732204")]
    [DisplayName("Total Taxable Amount")]
    [IsoXmlTag("TtlTaxblAmt")]
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_jFyBQO5NEeCisYr99QEiWA_-1439214754")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_jFyBQe5NEeCisYr99QEiWA_426525420")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    
    
    #nullable disable
    
}
