// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition37Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition37Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition37Choice.Code),nameof(SettlementTransactionCondition37Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition37Choice.Proprietary),nameof(SettlementTransactionCondition37Choice.Proprietary))]
    [IsoId("_38PHjyAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Transaction Condition 37 Choice")]
    public abstract partial record SettlementTransactionCondition37Choice_
    {
    }
}
