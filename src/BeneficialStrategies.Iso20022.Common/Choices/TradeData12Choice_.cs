// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData12Choice.DataSetAction))]
    [KnownType(typeof(TradeData12Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData12Choice.DataSetAction),
        nameof(TradeData12Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData12Choice.Report), nameof(TradeData12Choice.Report))]
    [IsoId("_SLQaof_kEemm3skPVSMJQg")]
    [DisplayName("Trade Data 12 Choice")]
    public abstract record TradeData12Choice_ { }
}
