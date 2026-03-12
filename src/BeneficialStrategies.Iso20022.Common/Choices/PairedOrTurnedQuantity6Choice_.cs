// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity6Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity6Choice.TurnedQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity6Choice.PairedOffQuantity),nameof(PairedOrTurnedQuantity6Choice.PairedOffQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity6Choice.TurnedQuantity),nameof(PairedOrTurnedQuantity6Choice.TurnedQuantity))]
    [IsoId("_dJccjTi8Eeydid5dcNPKvg")]
    [DisplayName("Paired Or Turned Quantity 6 Choice")]
    public abstract partial record PairedOrTurnedQuantity6Choice_
    {
    }
}
