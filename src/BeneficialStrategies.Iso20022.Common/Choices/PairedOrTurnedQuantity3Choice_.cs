// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity3Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity3Choice.TurnedQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity3Choice.PairedOffQuantity),nameof(PairedOrTurnedQuantity3Choice.PairedOffQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity3Choice.TurnedQuantity),nameof(PairedOrTurnedQuantity3Choice.TurnedQuantity))]
    [IsoId("_DSejUTtCEeWRTLSN0i0tng")]
    [DisplayName("Paired Or Turned Quantity 3 Choice")]
    public abstract partial record PairedOrTurnedQuantity3Choice_
    {
    }
}
