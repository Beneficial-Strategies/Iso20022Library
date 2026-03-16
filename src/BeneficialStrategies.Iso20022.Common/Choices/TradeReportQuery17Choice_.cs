// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Report Query17Choice.
    /// </summary>
    [KnownType(typeof(TradeReportQuery17Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery17Choice.RecurrentQuery))]
    [JsonDerivedType(
        typeof(TradeReportQuery17Choice.AdHocQuery),
        nameof(TradeReportQuery17Choice.AdHocQuery)
    )]
    [JsonDerivedType(
        typeof(TradeReportQuery17Choice.RecurrentQuery),
        nameof(TradeReportQuery17Choice.RecurrentQuery)
    )]
    [IsoId("_hNy68frgEe2mU4Wi2q3MzQ")]
    [DisplayName("Trade Report Query17Choice")]
    public abstract record TradeReportQuery17Choice_ { }
}
