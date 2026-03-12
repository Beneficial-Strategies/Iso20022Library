// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData56Choice.DataSetAction))]
    [KnownType(typeof(TradeData56Choice.State))]
    [JsonDerivedType(typeof(TradeData56Choice.DataSetAction),nameof(TradeData56Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData56Choice.State),nameof(TradeData56Choice.State))]
    [IsoId("_SAnYMV52Ee2a_-MvhEjKmA")]
    [DisplayName("Trade Data 56 Choice")]
    public abstract partial record TradeData56Choice_
    {
    }
}
