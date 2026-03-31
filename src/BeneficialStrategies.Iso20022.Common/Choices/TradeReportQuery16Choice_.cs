// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery16Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery16Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery16Choice.AdHocQuery),
        nameof(TradeReportQuery16Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery16Choice.RecurrentQuery),
        nameof(TradeReportQuery16Choice.RecurrentQuery)
    )]
    [IsoId("_nktkcWE3Ee2S65ml6YCOtA")]
    [DisplayName("Trade Report Query 16 Choice")]
    public abstract record TradeReportQuery16Choice_ { }
}
