// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate17Choice.Date))]
    [KnownType(typeof(SettlementDate17Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate17Choice.Date), nameof(SettlementDate17Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate17Choice.DateCode),
        nameof(SettlementDate17Choice.DateCode)
    )]
    [IsoId("_-3KbsbPuEeelzbgsFa3sqQ")]
    [DisplayName("Settlement Date 17 Choice")]
    public abstract record SettlementDate17Choice_ { }
}
