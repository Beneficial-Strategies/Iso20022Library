// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate22Choice.Date))]
    [KnownType(typeof(SettlementDate22Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate22Choice.Date),nameof(SettlementDate22Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate22Choice.DateCode),nameof(SettlementDate22Choice.DateCode))]
    [IsoId("_5TmBm83yEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 22 Choice")]
    public abstract partial record SettlementDate22Choice_
    {
    }
}
