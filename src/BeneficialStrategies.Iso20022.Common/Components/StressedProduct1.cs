// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument stressed under a stress test scenario.
/// </summary>
[IsoId("_DU0dAas2Eeayv9XxdmMwKQ")]
[DisplayName("Stressed Product")]
public partial record StressedProduct1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the product.
    /// </summary>
    [IsoId("_De8CU6s2Eeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification168 Identification { get; init; } 
    
    /// <summary>
    /// Maximum move across the curve for the stressed product.
    /// </summary>
    [IsoId("_Je6nwKs2Eeayv9XxdmMwKQ")]
    [DisplayName("Maximum Stress Size")]
    [IsoXmlTag("MaxStrssSz")]
    public required StressSize1Choice_ MaximumStressSize { get; init; } 
    
    /// <summary>
    /// Minimum move across the curve for the stressed product.
    /// </summary>
    [IsoId("_ect90HeOEee4S4mjz5XBYA")]
    [DisplayName("Minimum Stress Size")]
    [IsoXmlTag("MinStrssSz")]
    public required StressSize1Choice_ MinimumStressSize { get; init; } 
    
    
    #nullable disable
    
}
