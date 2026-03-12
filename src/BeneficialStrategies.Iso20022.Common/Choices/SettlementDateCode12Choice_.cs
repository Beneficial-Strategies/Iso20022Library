// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode12Choice.Code))]
    [KnownType(typeof(SettlementDateCode12Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementDateCode12Choice.Code),nameof(SettlementDateCode12Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode12Choice.Proprietary),nameof(SettlementDateCode12Choice.Proprietary))]
    [IsoId("_GxX0yZBhEeakHoV5BVecAQ")]
    [DisplayName("Settlement Date Code 12 Choice")]
    public abstract partial record SettlementDateCode12Choice_
    {
    }
}
