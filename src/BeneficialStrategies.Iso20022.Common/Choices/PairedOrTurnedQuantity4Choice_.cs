// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity4Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity4Choice.TurnedQuantity))]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity4Choice.PairedOffQuantity),
        nameof(PairedOrTurnedQuantity4Choice.PairedOffQuantity)
    )]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity4Choice.TurnedQuantity),
        nameof(PairedOrTurnedQuantity4Choice.TurnedQuantity)
    )]
    [IsoId("_5xlnoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Paired Or Turned Quantity 4 Choice")]
    public abstract record PairedOrTurnedQuantity4Choice_ { }
}
