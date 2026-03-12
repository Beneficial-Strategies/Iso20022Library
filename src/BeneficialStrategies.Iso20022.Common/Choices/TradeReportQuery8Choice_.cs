// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery8Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery8Choice.RecurrentQuery))]
    [JsonDerivedType(typeof(TradeReportQuery8Choice.AdHocQuery),nameof(TradeReportQuery8Choice.AdHocQuery))]
    [JsonDerivedType(typeof(TradeReportQuery8Choice.RecurrentQuery),nameof(TradeReportQuery8Choice.RecurrentQuery))]
    [IsoId("_4WULAf_lEemm3skPVSMJQg")]
    [DisplayName("Trade Report Query 8 Choice")]
    public abstract partial record TradeReportQuery8Choice_
    {
    }
}
