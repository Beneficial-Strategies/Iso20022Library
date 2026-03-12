// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate18Choice.Date))]
    [KnownType(typeof(SettlementDate18Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate18Choice.Date),nameof(SettlementDate18Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate18Choice.DateCode),nameof(SettlementDate18Choice.DateCode))]
    [IsoId("_dJt0MbPvEeelzbgsFa3sqQ")]
    [DisplayName("Settlement Date 18 Choice")]
    public abstract partial record SettlementDate18Choice_
    {
    }
}
