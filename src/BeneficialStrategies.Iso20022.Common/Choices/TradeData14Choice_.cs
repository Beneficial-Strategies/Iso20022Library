// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData14Choice.DataSetAction))]
    [KnownType(typeof(TradeData14Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData14Choice.DataSetAction),
        nameof(TradeData14Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData14Choice.Report), nameof(TradeData14Choice.Report))]
    [IsoId("_ClNWAf_oEemm3skPVSMJQg")]
    [DisplayName("Trade Data 14 Choice")]
    public abstract record TradeData14Choice_ { }
}
