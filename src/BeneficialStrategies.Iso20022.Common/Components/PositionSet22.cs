// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set22.
/// </summary>
[IsoId("_W3mxART8Ee61h9tfoUrWyw")]
[DisplayName("Position Set22")]
public record PositionSet22
{
    /// <summary>
    /// Dimensions.
    /// </summary>
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetCollateralDimensions3 Dimensions { get; init; }

    /// <summary>
    /// Metrics.
    /// </summary>
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetCollateralMetrics2 Metrics { get; init; }
}
