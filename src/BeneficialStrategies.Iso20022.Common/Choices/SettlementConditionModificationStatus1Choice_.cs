// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of processing change command status.
    /// </summary>
    [KnownType(typeof(SettlementConditionModificationStatus1Choice.Code))]
    [KnownType(typeof(SettlementConditionModificationStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus1Choice.Code),nameof(SettlementConditionModificationStatus1Choice.Code))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus1Choice.Proprietary),nameof(SettlementConditionModificationStatus1Choice.Proprietary))]
    [IsoId("_UYeaItp-Ed-ak6NoX_4Aeg_-936948787")]
    [DisplayName("Settlement Condition Modification Status 1 Choice")]
    public abstract partial record SettlementConditionModificationStatus1Choice_
    {
    }
}
