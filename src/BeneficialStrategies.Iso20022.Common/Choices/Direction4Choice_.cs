// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between elements indicating the direction of the derivative transaction.
    /// </summary>
    [KnownType(typeof(Direction4Choice.Direction))]
    [KnownType(typeof(Direction4Choice.CounterpartySide))]
    [JsonDerivedType(typeof(Direction4Choice.Direction), nameof(Direction4Choice.Direction))]
    [JsonDerivedType(
        typeof(Direction4Choice.CounterpartySide),
        nameof(Direction4Choice.CounterpartySide)
    )]
    [IsoId("_ZdjwgS0WEe2ZUuvBHegNNg")]
    [DisplayName("Direction 4 Choice")]
    public abstract record Direction4Choice_ { }
}
