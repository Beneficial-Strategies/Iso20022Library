// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about tax relief categories.
/// </summary>
[IsoId("_1WDUpTL3EeKU9IrkkToqcw_1580095547")]
[DisplayName("DTC Tax Relief SD")]
public partial record DTCTaxReliefSD1
{
    #nullable enable
    
    /// <summary>
    /// DTC System assigned identification for tax relief category.
    /// </summary>
    [IsoId("_1WDUpjL3EeKU9IrkkToqcw_-693454410")]
    [DisplayName("Category Identification")]
    [IsoXmlTag("CtgyId")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText CategoryIdentification { get; init; } 
    
    /// <summary>
    /// Describes tax relief category.
    /// </summary>
    [IsoId("_1WNFoDL3EeKU9IrkkToqcw_-661539457")]
    [DisplayName("Category Description")]
    [IsoXmlTag("CtgyDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CategoryDescription { get; init; } 
    
    
    #nullable disable
    
}
