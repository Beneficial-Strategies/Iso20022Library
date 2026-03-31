// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position/transaction reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(TradeData17Choice.DataSetAction))]
    [KnownType(typeof(TradeData17Choice.Report))]
    [KnownType(typeof(TradeData17Choice.State))]
    [JsonDerivedType(
        typeof(TradeData17Choice.DataSetAction),
        nameof(TradeData17Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData17Choice.Report), nameof(TradeData17Choice.Report))]
    [JsonDerivedType(typeof(TradeData17Choice.State), nameof(TradeData17Choice.State))]
    [IsoId("_bN4vcRLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Data 17 Choice")]
    public abstract record TradeData17Choice_ { }
}
