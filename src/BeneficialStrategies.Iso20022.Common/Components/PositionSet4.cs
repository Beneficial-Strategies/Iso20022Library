// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Values either taken directly from the reporting fields as defined in the local regulation or derived from those fields that will be used by trade repositories to calculate positions.
/// </summary>
[IsoId("_8sobkeNfEeiTop2HXWk15w")]
[DisplayName("Position Set")]
public record PositionSet4
{
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    [IsoId("_83N68eNfEeiTop2HXWk15w")]
    [DisplayName("Dimensions")]
    [IsoXmlTag("Dmnsns")]
    public required PositionSetCollateralDimensions2 Dimensions { get; init; }

    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    [IsoId("_83N68-NfEeiTop2HXWk15w")]
    [DisplayName("Metrics")]
    [IsoXmlTag("Mtrcs")]
    public required PositionSetCollateralMetrics1 Metrics { get; init; }
}
