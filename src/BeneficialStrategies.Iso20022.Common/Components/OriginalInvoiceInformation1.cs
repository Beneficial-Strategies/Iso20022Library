// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the invoice contained in the original request.
/// </summary>
[IsoId("_ThfHwtp-Ed-ak6NoX_4Aeg_1135889353")]
[DisplayName("Original Invoice Information")]
public partial record OriginalInvoiceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_ThfHw9p-Ed-ak6NoX_4Aeg_-710957131")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DocumentNumber { get; init; } 
    
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice additional amounts (allowances and charges) and total tax amounts.
    /// </summary>
    [IsoId("_ThfHxNp-Ed-ak6NoX_4Aeg_-601981200")]
    [DisplayName("Total Invoice Amount")]
    [IsoXmlTag("TtlInvcAmt")]
    public required ActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_ThfHxdp-Ed-ak6NoX_4Aeg_-255658965")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; } 
    
    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    [IsoId("_ThfHxtp-Ed-ak6NoX_4Aeg_696882678")]
    [DisplayName("Payment Due Date")]
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PaymentDueDate { get; init; } 
    
    
    #nullable disable
    
}
