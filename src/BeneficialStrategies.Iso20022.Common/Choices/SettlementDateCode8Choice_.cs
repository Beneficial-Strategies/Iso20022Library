// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode8Choice.Code))]
    [KnownType(typeof(SettlementDateCode8Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementDateCode8Choice.Code),nameof(SettlementDateCode8Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode8Choice.Proprietary),nameof(SettlementDateCode8Choice.Proprietary))]
    [IsoId("_4U7hpztKEeWRTLSN0i0tng")]
    [DisplayName("Settlement Date Code 8 Choice")]
    public abstract partial record SettlementDateCode8Choice_
    {
    }
}
