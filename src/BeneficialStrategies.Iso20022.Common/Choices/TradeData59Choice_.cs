// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Data59Choice.
    /// </summary>
    [KnownType(typeof(TradeData59Choice.DataSetAction))]
    [KnownType(typeof(TradeData59Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData59Choice.DataSetAction),
        nameof(TradeData59Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData59Choice.Report), nameof(TradeData59Choice.Report))]
    [IsoId("_8pD0gY-REe6Ojt1b3tfu9Q")]
    [DisplayName("Trade Data59Choice")]
    public abstract record TradeData59Choice_ { }
}
