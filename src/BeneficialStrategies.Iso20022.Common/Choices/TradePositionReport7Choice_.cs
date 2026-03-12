// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the relevant action types for trade positions.
    /// </summary>
    [KnownType(typeof(TradePositionReport7Choice.New))]
    [KnownType(typeof(TradePositionReport7Choice.Modification))]
    [KnownType(typeof(TradePositionReport7Choice.Correction))]
    [KnownType(typeof(TradePositionReport7Choice.EarlyTermination))]
    [KnownType(typeof(TradePositionReport7Choice.ValuationUpdate))]
    [KnownType(typeof(TradePositionReport7Choice.Error))]
    [KnownType(typeof(TradePositionReport7Choice.Other))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.New),nameof(TradePositionReport7Choice.New))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.Modification),nameof(TradePositionReport7Choice.Modification))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.Correction),nameof(TradePositionReport7Choice.Correction))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.EarlyTermination),nameof(TradePositionReport7Choice.EarlyTermination))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.ValuationUpdate),nameof(TradePositionReport7Choice.ValuationUpdate))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.Error),nameof(TradePositionReport7Choice.Error))]
    [JsonDerivedType(typeof(TradePositionReport7Choice.Other),nameof(TradePositionReport7Choice.Other))]
    [IsoId("_bV7RKRLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Position Report 7 Choice")]
    public abstract partial record TradePositionReport7Choice_
    {
    }
}
