// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financing information and status.
/// </summary>
[IsoId("_RYGZYtp-Ed-ak6NoX_4Aeg_645590457")]
[DisplayName("Financing Information And Status")]
public partial record FinancingInformationAndStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies summary information about invoices/instalments financed, such as total amount financed, number of single requests accepted.
    /// </summary>
    [IsoId("_RYGZY9p-Ed-ak6NoX_4Aeg_-1388553810")]
    [DisplayName("Financing Allowed Summary")]
    [IsoXmlTag("FincgAllwdSummry")]
    public required FinancingAllowedSummary1 FinancingAllowedSummary { get; init; } 
    
    /// <summary>
    /// Specifies detailed information about single invoice/instalment financing result, such as result of request (financed or not financed), amount, percentage applied.
    /// </summary>
    [IsoId("_RYGZZNp-Ed-ak6NoX_4Aeg_1262872441")]
    [DisplayName("Invoice Financing Details")]
    [IsoXmlTag("InvcFincgDtls")]
    public ValueList<InvoiceFinancingDetails1> InvoiceFinancingDetails { get; init; } = [];
    // ID for the above is _RYGZZNp-Ed-ak6NoX_4Aeg_1262872441
    
    
    #nullable disable
    
}
