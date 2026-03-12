// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position/transaction reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(TradeReport32Choice.New))]
    [KnownType(typeof(TradeReport32Choice.Modification))]
    [KnownType(typeof(TradeReport32Choice.Correction))]
    [KnownType(typeof(TradeReport32Choice.Termination))]
    [KnownType(typeof(TradeReport32Choice.PositionComponent))]
    [KnownType(typeof(TradeReport32Choice.ValuationUpdate))]
    [KnownType(typeof(TradeReport32Choice.Compression))]
    [KnownType(typeof(TradeReport32Choice.Error))]
    [KnownType(typeof(TradeReport32Choice.PortOut))]
    [KnownType(typeof(TradeReport32Choice.Revive))]
    [KnownType(typeof(TradeReport32Choice.Other))]
    [JsonDerivedType(typeof(TradeReport32Choice.New),nameof(TradeReport32Choice.New))]
    [JsonDerivedType(typeof(TradeReport32Choice.Modification),nameof(TradeReport32Choice.Modification))]
    [JsonDerivedType(typeof(TradeReport32Choice.Correction),nameof(TradeReport32Choice.Correction))]
    [JsonDerivedType(typeof(TradeReport32Choice.Termination),nameof(TradeReport32Choice.Termination))]
    [JsonDerivedType(typeof(TradeReport32Choice.PositionComponent),nameof(TradeReport32Choice.PositionComponent))]
    [JsonDerivedType(typeof(TradeReport32Choice.ValuationUpdate),nameof(TradeReport32Choice.ValuationUpdate))]
    [JsonDerivedType(typeof(TradeReport32Choice.Compression),nameof(TradeReport32Choice.Compression))]
    [JsonDerivedType(typeof(TradeReport32Choice.Error),nameof(TradeReport32Choice.Error))]
    [JsonDerivedType(typeof(TradeReport32Choice.PortOut),nameof(TradeReport32Choice.PortOut))]
    [JsonDerivedType(typeof(TradeReport32Choice.Revive),nameof(TradeReport32Choice.Revive))]
    [JsonDerivedType(typeof(TradeReport32Choice.Other),nameof(TradeReport32Choice.Other))]
    [IsoId("__e7PwWEUEe2P-L9DBerEgA")]
    [DisplayName("Trade Report 32 Choice")]
    public abstract partial record TradeReport32Choice_
    {
    }
}
