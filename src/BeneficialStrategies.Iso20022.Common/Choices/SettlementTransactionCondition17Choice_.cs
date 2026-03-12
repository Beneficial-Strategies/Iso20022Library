// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition17Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition17Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition17Choice.Code),nameof(SettlementTransactionCondition17Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition17Choice.Proprietary),nameof(SettlementTransactionCondition17Choice.Proprietary))]
    [IsoId("_hUsvITqlEeWyoP0PbocV1Q")]
    [DisplayName("Settlement Transaction Condition 17 Choice")]
    public abstract partial record SettlementTransactionCondition17Choice_
    {
    }
}
