// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode7Choice.Code))]
    [KnownType(typeof(SettlementDateCode7Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementDateCode7Choice.Code),nameof(SettlementDateCode7Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode7Choice.Proprietary),nameof(SettlementDateCode7Choice.Proprietary))]
    [IsoId("_b0UOpzqLEeWVrPy0StzzSg")]
    [DisplayName("Settlement Date Code 7 Choice")]
    public abstract partial record SettlementDateCode7Choice_
    {
    }
}
