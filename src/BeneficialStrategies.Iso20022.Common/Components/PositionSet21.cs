// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set21.
/// </summary>
[IsoId("_jRH0yxTjEe61h9tfoUrWyw")]
[DisplayName("Position Set21")]
public record PositionSet21
{
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
}
