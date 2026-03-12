// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of processing change command status.
    /// </summary>
    [KnownType(typeof(SettlementConditionModificationStatus4Choice.Code))]
    [KnownType(typeof(SettlementConditionModificationStatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus4Choice.Code),nameof(SettlementConditionModificationStatus4Choice.Code))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus4Choice.Proprietary),nameof(SettlementConditionModificationStatus4Choice.Proprietary))]
    [IsoId("_8QcPyZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Condition Modification Status 4 Choice")]
    public abstract partial record SettlementConditionModificationStatus4Choice_
    {
    }
}
