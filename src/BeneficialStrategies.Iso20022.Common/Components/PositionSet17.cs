// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the values used to calculate positions.
/// </summary>
[IsoId("_LndN8cKyEeuM4pgP8Vixbg")]
[DisplayName("Position Set")]
public record PositionSet17
{
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    [IsoId("_LpIo8cKyEeuM4pgP8Vixbg")]
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetDimensions14 Dimensions { get; init; }

    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    [IsoId("_LpIo88KyEeuM4pgP8Vixbg")]
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetMetrics13 Metrics { get; init; }
}
