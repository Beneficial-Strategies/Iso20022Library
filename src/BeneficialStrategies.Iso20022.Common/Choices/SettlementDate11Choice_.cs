// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate11Choice.Date))]
    [KnownType(typeof(SettlementDate11Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate11Choice.Date),nameof(SettlementDate11Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate11Choice.DateCode),nameof(SettlementDate11Choice.DateCode))]
    [IsoId("_UrxegTtPEeWRTLSN0i0tng")]
    [DisplayName("Settlement Date 11 Choice")]
    public abstract partial record SettlementDate11Choice_
    {
    }
}
