// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about single invoice/instalment financing result, such as result of request (financed or not financed), amount, percentage applied.
/// </summary>
[IsoId("_ThypxNp-Ed-ak6NoX_4Aeg_1200073540")]
[DisplayName("Invoice Financing Details")]
public partial record InvoiceFinancingDetails1
{
    #nullable enable
    
    /// <summary>
    /// General information that unambiguously identifies the invoice contained in the original request.
    /// </summary>
    [IsoId("_Thypxdp-Ed-ak6NoX_4Aeg_1348559933")]
    [DisplayName("Original Invoice Information")]
    [IsoXmlTag("OrgnlInvcInf")]
    public required OriginalInvoiceInformation1 OriginalInvoiceInformation { get; init; } 
    
    /// <summary>
    /// Person or organization that represents the creditor for the invoice to be financed.
    /// </summary>
    [IsoId("_Thypxtp-Ed-ak6NoX_4Aeg_-989546543")]
    [DisplayName("Supplier")]
    [IsoXmlTag("Spplr")]
    public PartyIdentification8? Supplier { get; init; } 
    
    /// <summary>
    /// Information about result of invoice financing request.
    /// </summary>
    [IsoId("_Thypx9p-Ed-ak6NoX_4Aeg_1696461890")]
    [DisplayName("Invoice Financing Result")]
    [IsoXmlTag("InvcFincgRslt")]
    public required FinancingResult1 InvoiceFinancingResult { get; init; } 
    
    /// <summary>
    /// Includes details about a single instalment within an invoice, such as identification and amount.
    /// </summary>
    [IsoId("_ThypyNp-Ed-ak6NoX_4Aeg_2076029175")]
    [DisplayName("Instalment Financing Information")]
    [IsoXmlTag("InstlmtFincgInf")]
    public InstalmentFinancingInformation1? InstalmentFinancingInformation { get; init; } 
    
    
    #nullable disable
    
}
