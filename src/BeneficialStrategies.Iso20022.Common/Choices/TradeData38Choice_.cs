// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData38Choice.DataSetAction))]
    [KnownType(typeof(TradeData38Choice.State))]
    [JsonDerivedType(
        typeof(TradeData38Choice.DataSetAction),
        nameof(TradeData38Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData38Choice.State), nameof(TradeData38Choice.State))]
    [IsoId("_4-rgQcgoEeuGrNSsxk3B0A")]
    [DisplayName("Trade Data 38 Choice")]
    public abstract record TradeData38Choice_ { }
}
