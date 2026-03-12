// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of processing change command status.
    /// </summary>
    [KnownType(typeof(SettlementConditionModificationStatus3Choice.Code))]
    [KnownType(typeof(SettlementConditionModificationStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus3Choice.Code),nameof(SettlementConditionModificationStatus3Choice.Code))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus3Choice.Proprietary),nameof(SettlementConditionModificationStatus3Choice.Proprietary))]
    [IsoId("_8wlDMTqqEeWyoP0PbocV1Q")]
    [DisplayName("Settlement Condition Modification Status 3 Choice")]
    public abstract partial record SettlementConditionModificationStatus3Choice_
    {
    }
}
