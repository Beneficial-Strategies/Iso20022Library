// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData40Choice.DataSetAction))]
    [KnownType(typeof(TradeData40Choice.Report))]
    [JsonDerivedType(typeof(TradeData40Choice.DataSetAction),nameof(TradeData40Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData40Choice.Report),nameof(TradeData40Choice.Report))]
    [IsoId("_zryFccg3EeuGrNSsxk3B0A")]
    [DisplayName("Trade Data 40 Choice")]
    public abstract partial record TradeData40Choice_
    {
    }
}
