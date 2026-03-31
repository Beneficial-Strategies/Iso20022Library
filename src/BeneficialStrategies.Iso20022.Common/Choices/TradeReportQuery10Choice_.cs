// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery10Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery10Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery10Choice.AdHocQuery),
        nameof(TradeReportQuery10Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery10Choice.RecurrentQuery),
        nameof(TradeReportQuery10Choice.RecurrentQuery)
    )]
    [IsoId("_eqwjId1dEeqxpKDfBZC1vg")]
    [DisplayName("Trade Report Query 10 Choice")]
    public abstract record TradeReportQuery10Choice_ { }
}
