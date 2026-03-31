// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement3Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement3Choice.Return))]
    [JsonDerivedType(
        typeof(CollateralMovement3Choice.CollateralMovementDirection),
        nameof(CollateralMovement3Choice.CollateralMovementDirection)
    )]
    [JsonDerivedType(
        typeof(CollateralMovement3Choice.Return),
        nameof(CollateralMovement3Choice.Return)
    )]
    [IsoId("_QQNJlV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Movement 3 Choice")]
    public abstract record CollateralMovement3Choice_ { }
}
