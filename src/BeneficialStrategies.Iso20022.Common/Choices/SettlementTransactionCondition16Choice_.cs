// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition16Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition16Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition16Choice.Code),nameof(SettlementTransactionCondition16Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition16Choice.Proprietary),nameof(SettlementTransactionCondition16Choice.Proprietary))]
    [IsoId("_Qc_ObTqEEeWVrPy0StzzSg")]
    [DisplayName("Settlement Transaction Condition 16 Choice")]
    public abstract partial record SettlementTransactionCondition16Choice_
    {
    }
}
