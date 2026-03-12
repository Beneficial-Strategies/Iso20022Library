// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
[IsoId("_OYixZXeuEeGnSLS4l8GDAA")]
[DisplayName("Long Quantity To Quantity Ratio")]
public partial record LongQuantityToQuantityRatio2
{
    #nullable enable
    
    /// <summary>
    /// High precision numerator of the quotient of quantities.
    /// </summary>
    [IsoId("_OYixaHeuEeGnSLS4l8GDAA")]
    [DisplayName("Long Quantity")]
    [IsoXmlTag("LngQty1")]
    [IsoSimpleType(IsoSimpleType.LongDecimalNumber)]
    public required IsoLongDecimalNumber LongQuantity1 { get; init; } 
    
    /// <summary>
    /// High precision denominator of the quotient of quantities.
    /// </summary>
    [IsoId("_OYixa3euEeGnSLS4l8GDAA")]
    [DisplayName("Long Quantity")]
    [IsoXmlTag("LngQty2")]
    [IsoSimpleType(IsoSimpleType.LongDecimalNumber)]
    public required IsoLongDecimalNumber LongQuantity2 { get; init; } 
    
    
    #nullable disable
    
}
