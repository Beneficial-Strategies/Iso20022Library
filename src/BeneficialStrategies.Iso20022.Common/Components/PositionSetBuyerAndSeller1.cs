// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_xOo7VcWEEeiRga8tPu1L4Q")]
[DisplayName("Position Set Buyer And Seller")]
public partial record PositionSetBuyerAndSeller1
{
    #nullable enable
    
    /// <summary>
    /// Refers to the aggregated data for the buyer counterparty.
    /// </summary>
    [IsoId("_xOo7VsWEEeiRga8tPu1L4Q")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PositionSetTotal1? Buyer { get; init; } 
    
    /// <summary>
    /// Refers to the aggregated data for the seller counterparty.
    /// </summary>
    [IsoId("_xOo7WMWEEeiRga8tPu1L4Q")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PositionSetTotal1? Seller { get; init; } 
    
    
    #nullable disable
    
}
