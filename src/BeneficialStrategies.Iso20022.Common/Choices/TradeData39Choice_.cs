// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData39Choice.DataSetAction))]
    [KnownType(typeof(TradeData39Choice.Report))]
    [JsonDerivedType(typeof(TradeData39Choice.DataSetAction),nameof(TradeData39Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData39Choice.Report),nameof(TradeData39Choice.Report))]
    [IsoId("_SHUFscg2EeuGrNSsxk3B0A")]
    [DisplayName("Trade Data 39 Choice")]
    public abstract partial record TradeData39Choice_
    {
    }
}
