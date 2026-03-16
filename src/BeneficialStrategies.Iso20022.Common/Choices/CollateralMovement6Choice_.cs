// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement6Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement6Choice.Return))]
    [JsonDerivedType(
        typeof(CollateralMovement6Choice.CollateralMovementDirection),
        nameof(CollateralMovement6Choice.CollateralMovementDirection)
    )]
    [JsonDerivedType(
        typeof(CollateralMovement6Choice.Return),
        nameof(CollateralMovement6Choice.Return)
    )]
    [IsoId("_6IUJJSqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Movement 6 Choice")]
    public abstract record CollateralMovement6Choice_ { }
}
