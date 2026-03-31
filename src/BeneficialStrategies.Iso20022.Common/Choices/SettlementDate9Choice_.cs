// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate9Choice.Date))]
    [KnownType(typeof(SettlementDate9Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate9Choice.Date), nameof(SettlementDate9Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate9Choice.DateCode),
        nameof(SettlementDate9Choice.DateCode)
    )]
    [IsoId("_bUxy4TqLEeWVrPy0StzzSg")]
    [DisplayName("Settlement Date 9 Choice")]
    public abstract record SettlementDate9Choice_ { }
}
