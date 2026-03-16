// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery4Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery4Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery4Choice.AdHocQuery),
        nameof(TradeReportQuery4Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery4Choice.RecurrentQuery),
        nameof(TradeReportQuery4Choice.RecurrentQuery)
    )]
    [IsoId("_P3lVAYeAEei-Poi-FosJdw")]
    [DisplayName("Trade Report Query 4 Choice")]
    public abstract record TradeReportQuery4Choice_ { }
}
