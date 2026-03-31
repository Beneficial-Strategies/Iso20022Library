// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement4Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement4Choice.Return))]
    [JsonDerivedType(
        typeof(CollateralMovement4Choice.CollateralMovementDirection),
        nameof(CollateralMovement4Choice.CollateralMovementDirection)
    )]
    [JsonDerivedType(
        typeof(CollateralMovement4Choice.Return),
        nameof(CollateralMovement4Choice.Return)
    )]
    [IsoId("_yGZ5JYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Movement 4 Choice")]
    public abstract record CollateralMovement4Choice_ { }
}
