// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition7Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition7Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition7Choice.Code),nameof(SettlementTransactionCondition7Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition7Choice.Proprietary),nameof(SettlementTransactionCondition7Choice.Proprietary))]
    [IsoId("_EQSYV_IwEd-dOvqmSLSz5g")]
    [DisplayName("Settlement Transaction Condition 7 Choice")]
    public abstract partial record SettlementTransactionCondition7Choice_
    {
    }
}
