// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
[IsoId("_Ys-60fFTEee_LsXdoqzkWg")]
[DisplayName("Product Characteristics")]
public partial record ProductCharacteristics4
{
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    [IsoId("_Y2I20fFTEee_LsXdoqzkWg")]
    [DisplayName("Characteristic")]
    [IsoXmlTag("Chrtc")]
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    [IsoId("_Y2Jd4fFTEee_LsXdoqzkWg")]
    [DisplayName("Value Measure")]
    [IsoXmlTag("ValMeasr")]
    public Quantity16? ValueMeasure { get; init; } 
    
    
    #nullable disable
    
}
