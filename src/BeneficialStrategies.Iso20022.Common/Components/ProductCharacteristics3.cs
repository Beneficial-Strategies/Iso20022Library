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
[IsoId("_CYo1scNUEeWGDrnsYu2p6g")]
[DisplayName("Product Characteristics")]
public partial record ProductCharacteristics3
{
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    [IsoId("_ClCS8cNUEeWGDrnsYu2p6g")]
    [DisplayName("Characteristic")]
    [IsoXmlTag("Chrtc")]
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    [IsoId("_ClCS88NUEeWGDrnsYu2p6g")]
    [DisplayName("Value Measure")]
    [IsoXmlTag("ValMeasr")]
    public Quantity10? ValueMeasure { get; init; } 
    
    
    #nullable disable
    
}
