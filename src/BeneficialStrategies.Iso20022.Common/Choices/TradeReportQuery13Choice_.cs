// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery13Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery13Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery13Choice.AdHocQuery),
        nameof(TradeReportQuery13Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery13Choice.RecurrentQuery),
        nameof(TradeReportQuery13Choice.RecurrentQuery)
    )]
    [IsoId("_1LqeURfMEeyPHpqpKwtFdw")]
    [DisplayName("Trade Report Query 13 Choice")]
    public abstract record TradeReportQuery13Choice_ { }
}
