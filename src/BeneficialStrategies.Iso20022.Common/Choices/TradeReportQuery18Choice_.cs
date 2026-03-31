// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Report Query18Choice.
    /// </summary>
    [KnownType(typeof(TradeReportQuery18Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery18Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery18Choice.AdHocQuery),
        nameof(TradeReportQuery18Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery18Choice.RecurrentQuery),
        nameof(TradeReportQuery18Choice.RecurrentQuery)
    )]
    [IsoId("_-yIjoZjCEe6BApM7bIoABA")]
    [DisplayName("Trade Report Query18Choice")]
    public abstract record TradeReportQuery18Choice_ { }
}
