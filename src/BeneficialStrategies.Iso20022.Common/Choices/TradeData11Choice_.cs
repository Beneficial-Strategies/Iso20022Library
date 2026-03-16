// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData11Choice.DataSetAction))]
    [KnownType(typeof(TradeData11Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData11Choice.DataSetAction),
        nameof(TradeData11Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData11Choice.Report), nameof(TradeData11Choice.Report))]
    [IsoId("_BKjIoa4UEemB_csI4yyKLA")]
    [DisplayName("Trade Data 11 Choice")]
    public abstract record TradeData11Choice_ { }
}
