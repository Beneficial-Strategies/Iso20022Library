// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice data pertaining to the payment transaction.
/// </summary>
[IsoId("_179yk_PSEeihCvvpsmGI2w")]
[DisplayName("Invoice")]
public partial record Invoice1
{
    #nullable enable
    
    /// <summary>
    /// Invoice summary information.
    /// </summary>
    [IsoId("_179ylfPSEeihCvvpsmGI2w")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public InvoiceSummary1? Summary { get; init; } 
    
    /// <summary>
    /// Line item information.
    /// </summary>
    [IsoId("_179ylPPSEeihCvvpsmGI2w")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public InvoiceLineItem1? LineItem { get; init; } 
    
    
    #nullable disable
    
}
