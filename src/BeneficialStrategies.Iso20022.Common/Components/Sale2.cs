// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of good and services included in the sale.
/// </summary>
[IsoId("_3kUpYSCAEey8XKHwKquEQw")]
[DisplayName("Sale")]
public partial record Sale2
{
    #nullable enable
    
    /// <summary>
    /// Sale summary information.
    /// </summary>
    [IsoId("_3pk80SCAEey8XKHwKquEQw")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public SaleSummary1? Summary { get; init; } 
    
    /// <summary>
    /// Sale line item information.
    /// </summary>
    [IsoId("_3pk80yCAEey8XKHwKquEQw")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public SaleItem3? LineItem { get; init; } 
    
    
    #nullable disable
    
}
