// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
    /// </summary>
    [KnownType(typeof(CollateralMovement5Choice.CollateralMovementDirection))]
    [KnownType(typeof(CollateralMovement5Choice.Return))]
    [JsonDerivedType(typeof(CollateralMovement5Choice.CollateralMovementDirection),nameof(CollateralMovement5Choice.CollateralMovementDirection))]
    [JsonDerivedType(typeof(CollateralMovement5Choice.Return),nameof(CollateralMovement5Choice.Return))]
    [IsoId("_sHMX9YpIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Movement 5 Choice")]
    public abstract partial record CollateralMovement5Choice_
    {
    }
}
