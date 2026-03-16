// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Collateral Metrics2.
/// </summary>
[IsoId("_Hj5tURc0Ee6tpciIp9JEYw")]
[DisplayName("Position Set Collateral Metrics2")]
public record PositionSetCollateralMetrics2
{
    /// <summary>
    /// Clean.
    /// </summary>
    [DisplayName("Clean")]
    [IsoXmlTag("Clean")]
    public PositionSetCollateralTotal2? Clean { get; init; }

    /// <summary>
    /// Total.
    /// </summary>
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public PositionSetCollateralTotal2? Total { get; init; }
}
