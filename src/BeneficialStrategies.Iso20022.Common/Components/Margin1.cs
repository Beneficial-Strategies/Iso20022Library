// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to calculate the collateral margin call for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_UnOn1dp-Ed-ak6NoX_4Aeg_-1003583230")]
[DisplayName("Margin")]
public partial record Margin1
{
    #nullable enable
    
    /// <summary>
    /// Elements used to calculate the collateral margin call for the variation margin.
    /// </summary>
    [IsoId("_UnOn1tp-Ed-ak6NoX_4Aeg_-1233189826")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required VariationMargin1 VariationMargin { get; init; } 
    
    /// <summary>
    /// Elements used to calculate the collateral margin call for the segregated independent amount.
    /// </summary>
    [IsoId("_UnOn19p-Ed-ak6NoX_4Aeg_1199972462")]
    [DisplayName("Segregated Independent Amount Margin")]
    [IsoXmlTag("SgrtdIndpdntAmtMrgn")]
    public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; init; } 
    
    
    #nullable disable
    
}
