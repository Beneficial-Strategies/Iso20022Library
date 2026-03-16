// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Data60Choice.
    /// </summary>
    [KnownType(typeof(TradeData60Choice.DataSetAction))]
    [KnownType(typeof(TradeData60Choice.State))]
    [JsonDerivedType(
        typeof(TradeData60Choice.DataSetAction),
        nameof(TradeData60Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData60Choice.State), nameof(TradeData60Choice.State))]
    [IsoId("_5wLS4ZBBEe6Ojt1b3tfu9Q")]
    [DisplayName("Trade Data60Choice")]
    public abstract record TradeData60Choice_ { }
}
