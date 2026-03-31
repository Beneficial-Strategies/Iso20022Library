// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate8Choice.Date))]
    [KnownType(typeof(SettlementDate8Choice.Code))]
    [JsonDerivedType(typeof(SettlementDate8Choice.Date), nameof(SettlementDate8Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate8Choice.Code), nameof(SettlementDate8Choice.Code))]
    [IsoId("_AcsYgtokEeC60axPepSq7g_-1335452175")]
    [DisplayName("Settlement Date 8 Choice")]
    public abstract record SettlementDate8Choice_ { }
}
