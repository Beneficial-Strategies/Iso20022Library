// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate32Choice.Date))]
    [KnownType(typeof(SettlementDate32Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate32Choice.Date),nameof(SettlementDate32Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate32Choice.DateCode),nameof(SettlementDate32Choice.DateCode))]
    [IsoId("_vE8fa832Eee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 32 Choice")]
    public abstract partial record SettlementDate32Choice_
    {
    }
}
