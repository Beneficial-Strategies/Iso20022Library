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
[IsoId("_mQH0X-F6EeWCAvUNsZ5u6g")]
[DisplayName("Service Category Totals")]
public partial record ServiceCategoryTotals2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of an securities account or cash account belonging to billed customer.
    /// </summary>
    [IsoId("_ma_AgeF6EeWCAvUNsZ5u6g")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification38Choice_? AccountIdentification { get; init; } 
    
    /// <summary>
    /// BIC of the party which is invoiced by the CSD/NCB.
    /// </summary>
    [IsoId("_ma_Ag-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Billed Customer Identification")]
    [IsoXmlTag("BlldCstmrId")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public IsoBICFIIdentifier? BilledCustomerIdentification { get; init; } 
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    [IsoId("_ma_AheF6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Taxable Amount")]
    [IsoXmlTag("TtlTaxblAmt")]
    public ActiveCurrencyAndAmount? TotalTaxableAmount { get; init; } 
    
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    [IsoId("_ma_Ah-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveCurrencyAndAmount? TotalTaxAmount { get; init; } 
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_ma_AieF6EeWCAvUNsZ5u6g")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_ma_Ai-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Service Category")]
    [IsoXmlTag("SvcCtgy")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ServiceCategory { get; init; } 
    
    /// <summary>
    /// Specifies totals related to the invoice.
    /// </summary>
    [IsoId("_ma_AjeF6EeWCAvUNsZ5u6g")]
    [DisplayName("Service Item Totals")]
    [IsoXmlTag("SvcItmTtls")]
    public ServiceItemTotals1? ServiceItemTotals { get; init; } 
    
    
    #nullable disable
    
}
