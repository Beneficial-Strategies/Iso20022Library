// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for settlement unit type.
    /// </summary>
    [KnownType(typeof(SettlementUnitType3Choice.Code))]
    [KnownType(typeof(SettlementUnitType3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementUnitType3Choice.Code),nameof(SettlementUnitType3Choice.Code))]
    [JsonDerivedType(typeof(SettlementUnitType3Choice.Proprietary),nameof(SettlementUnitType3Choice.Proprietary))]
    [IsoId("_dzq1AeLxEeWOD7aAy2fAcA")]
    [DisplayName("Settlement Unit Type 3 Choice")]
    public abstract partial record SettlementUnitType3Choice_
    {
    }
}
