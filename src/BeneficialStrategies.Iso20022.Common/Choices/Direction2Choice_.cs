// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between elements indicating the direction of the derivative transaction.
    /// </summary>
    [KnownType(typeof(Direction2Choice.DirectionOfTheFirstLeg))]
    [KnownType(typeof(Direction2Choice.CounterpartySide))]
    [JsonDerivedType(
        typeof(Direction2Choice.DirectionOfTheFirstLeg),
        nameof(Direction2Choice.DirectionOfTheFirstLeg)
    )]
    [JsonDerivedType(
        typeof(Direction2Choice.CounterpartySide),
        nameof(Direction2Choice.CounterpartySide)
    )]
    [IsoId("_n79FOXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction 2 Choice")]
    public abstract record Direction2Choice_ { }
}
