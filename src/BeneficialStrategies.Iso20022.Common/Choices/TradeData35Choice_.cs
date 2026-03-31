// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData35Choice.DataSetAction))]
    [KnownType(typeof(TradeData35Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData35Choice.DataSetAction),
        nameof(TradeData35Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData35Choice.Report), nameof(TradeData35Choice.Report))]
    [IsoId("_hQSv4cK4EeuFNp8LZAnorg")]
    [DisplayName("Trade Data 35 Choice")]
    public abstract record TradeData35Choice_ { }
}
