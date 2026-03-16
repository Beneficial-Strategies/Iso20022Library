// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
[IsoId("_TACHXAEcEeCQm6a_G2yO_w_369739834")]
[DisplayName("Product Characteristics")]
public record ProductCharacteristics2
{
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    [IsoId("_TACHXQEcEeCQm6a_G2yO_w_-181031001")]
    [DisplayName("Characteristic")]
    [IsoXmlTag("Chrtc")]
    public ProductCharacteristics1Choice_? Characteristic { get; init; }

    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    [IsoId("_TACHXgEcEeCQm6a_G2yO_w_-285398100")]
    [DisplayName("Value Measure")]
    [IsoXmlTag("ValMeasr")]
    public Quantity3? ValueMeasure { get; init; }
}
