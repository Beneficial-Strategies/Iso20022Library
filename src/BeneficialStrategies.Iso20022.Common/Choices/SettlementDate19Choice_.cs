// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate19Choice.Date))]
    [KnownType(typeof(SettlementDate19Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate19Choice.Date),nameof(SettlementDate19Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate19Choice.DateCode),nameof(SettlementDate19Choice.DateCode))]
    [IsoId("_qq8vIbPwEeelzbgsFa3sqQ")]
    [DisplayName("Settlement Date 19 Choice")]
    public abstract partial record SettlementDate19Choice_
    {
    }
}
