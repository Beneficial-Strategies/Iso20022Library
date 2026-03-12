// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery12Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery12Choice.RecurrentQuery))]
    [JsonDerivedType(typeof(TradeReportQuery12Choice.AdHocQuery),nameof(TradeReportQuery12Choice.AdHocQuery))]
    [JsonDerivedType(typeof(TradeReportQuery12Choice.RecurrentQuery),nameof(TradeReportQuery12Choice.RecurrentQuery))]
    [IsoId("_P2sHMa5pEeuo-IflVgGqiA")]
    [DisplayName("Trade Report Query 12 Choice")]
    public abstract partial record TradeReportQuery12Choice_
    {
    }
}
