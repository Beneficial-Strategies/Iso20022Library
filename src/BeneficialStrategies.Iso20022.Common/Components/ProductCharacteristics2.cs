// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
[IsoId("_TACHXAEcEeCQm6a_G2yO_w_369739834")]
[DisplayName("Product Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductCharacteristics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    [IsoId("_TACHXQEcEeCQm6a_G2yO_w_-181031001")]
    [DisplayName("Characteristic")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtc")]
    #endif
    [IsoXmlTag("Chrtc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    #else
    public ProductCharacteristics1Choice_? Characteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    [IsoId("_TACHXgEcEeCQm6a_G2yO_w_-285398100")]
    [DisplayName("Value Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValMeasr")]
    #endif
    [IsoXmlTag("ValMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? ValueMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? ValueMeasure { get; init; } 
    #else
    public Quantity3? ValueMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
