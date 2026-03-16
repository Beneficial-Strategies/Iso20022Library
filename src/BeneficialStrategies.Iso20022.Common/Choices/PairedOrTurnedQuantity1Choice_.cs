// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity1Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity1Choice.TurnedQuantity))]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity1Choice.PairedOffQuantity),
        nameof(PairedOrTurnedQuantity1Choice.PairedOffQuantity)
    )]
    [JsonDerivedType(
        typeof(PairedOrTurnedQuantity1Choice.TurnedQuantity),
        nameof(PairedOrTurnedQuantity1Choice.TurnedQuantity)
    )]
    [IsoId("_UdsRU9p-Ed-ak6NoX_4Aeg_259253644")]
    [DisplayName("Paired Or Turned Quantity 1 Choice")]
    public abstract record PairedOrTurnedQuantity1Choice_ { }
}
