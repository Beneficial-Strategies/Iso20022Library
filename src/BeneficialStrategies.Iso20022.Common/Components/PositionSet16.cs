// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the values used to calculate positions.
/// </summary>
[IsoId("_ZiA5wcKxEeuM4pgP8Vixbg")]
[DisplayName("Position Set")]
public partial record PositionSet16
{
    #nullable enable
    
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    [IsoId("_ZkZfYcKxEeuM4pgP8Vixbg")]
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetDimensions14 Dimensions { get; init; } 
    
    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    [IsoId("_ZkZfY8KxEeuM4pgP8Vixbg")]
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetMetrics7 Metrics { get; init; } 
    
    
    #nullable disable
    
}
