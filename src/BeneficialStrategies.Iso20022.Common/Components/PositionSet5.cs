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
[IsoId("_0w3kQQ1MEeqV4s5SpzR1dQ")]
[DisplayName("Position Set")]
public partial record PositionSet5
{
    #nullable enable
    
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    [IsoId("_0xmkEQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetDimensions3 Dimensions { get; init; } 
    
    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    [IsoId("_0xmkEw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetMetrics1 Metrics { get; init; } 
    
    
    #nullable disable
    
}
