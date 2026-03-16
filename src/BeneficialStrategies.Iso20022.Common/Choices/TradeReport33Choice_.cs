// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Report33Choice.
    /// </summary>
    [KnownType(typeof(TradeReport33Choice.Compression))]
    [KnownType(typeof(TradeReport33Choice.Correction))]
    [KnownType(typeof(TradeReport33Choice.Error))]
    [KnownType(typeof(TradeReport33Choice.Modification))]
    [KnownType(typeof(TradeReport33Choice.New))]
    [KnownType(typeof(TradeReport33Choice.Other))]
    [KnownType(typeof(TradeReport33Choice.PortOut))]
    [KnownType(typeof(TradeReport33Choice.PositionComponent))]
    [KnownType(typeof(TradeReport33Choice.Revive))]
    [KnownType(typeof(TradeReport33Choice.Termination))]
    [KnownType(typeof(TradeReport33Choice.ValuationUpdate))]
    [JsonDerivedType(
        typeof(TradeReport33Choice.Compression),
        nameof(TradeReport33Choice.Compression)
    )]
    [JsonDerivedType(
        typeof(TradeReport33Choice.Correction),
        nameof(TradeReport33Choice.Correction)
    )]
    [JsonDerivedType(typeof(TradeReport33Choice.Error), nameof(TradeReport33Choice.Error))]
    [JsonDerivedType(
        typeof(TradeReport33Choice.Modification),
        nameof(TradeReport33Choice.Modification)
    )]
    [JsonDerivedType(typeof(TradeReport33Choice.New), nameof(TradeReport33Choice.New))]
    [JsonDerivedType(typeof(TradeReport33Choice.Other), nameof(TradeReport33Choice.Other))]
    [JsonDerivedType(typeof(TradeReport33Choice.PortOut), nameof(TradeReport33Choice.PortOut))]
    [JsonDerivedType(
        typeof(TradeReport33Choice.PositionComponent),
        nameof(TradeReport33Choice.PositionComponent)
    )]
    [JsonDerivedType(typeof(TradeReport33Choice.Revive), nameof(TradeReport33Choice.Revive))]
    [JsonDerivedType(
        typeof(TradeReport33Choice.Termination),
        nameof(TradeReport33Choice.Termination)
    )]
    [JsonDerivedType(
        typeof(TradeReport33Choice.ValuationUpdate),
        nameof(TradeReport33Choice.ValuationUpdate)
    )]
    [IsoId("_8qzg8Y-REe6Ojt1b3tfu9Q")]
    [DisplayName("Trade Report33Choice")]
    public abstract record TradeReport33Choice_ { }
}
