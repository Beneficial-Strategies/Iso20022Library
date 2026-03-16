// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set21.
/// </summary>
[IsoId("_jRH0yxTjEe61h9tfoUrWyw")]
[DisplayName("Position Set21")]
public partial record PositionSet21
{
    #nullable enable

    /// <summary>
    /// Dimensions.
    /// </summary>
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetDimensions16 Dimensions { get; init; } 

    /// <summary>
    /// Metrics.
    /// </summary>
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetMetrics14 Metrics { get; init; } 

    
    #nullable disable
    
}
