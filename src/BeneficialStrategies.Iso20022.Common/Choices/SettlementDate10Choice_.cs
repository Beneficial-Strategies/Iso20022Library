// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate10Choice.Date))]
    [KnownType(typeof(SettlementDate10Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate10Choice.Date), nameof(SettlementDate10Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate10Choice.DateCode),
        nameof(SettlementDate10Choice.DateCode)
    )]
    [IsoId("_3z5RETtKEeWRTLSN0i0tng")]
    [DisplayName("Settlement Date 10 Choice")]
    public abstract record SettlementDate10Choice_ { }
}
