// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity5Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity5Choice.TurnedQuantity))]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity5Choice.PairedOffQuantity),
        nameof(PairedOrTurnedQuantity5Choice.PairedOffQuantity)
    )]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity5Choice.TurnedQuantity),
        nameof(PairedOrTurnedQuantity5Choice.TurnedQuantity)
    )]
    [IsoId("_YE22YSqHEeyR9JrVGfaMKw")]
    [DisplayName("Paired Or Turned Quantity 5 Choice")]
    public abstract record PairedOrTurnedQuantity5Choice_ { }
}
