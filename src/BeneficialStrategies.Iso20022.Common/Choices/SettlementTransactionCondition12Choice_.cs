// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition12Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition12Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition12Choice.Code),nameof(SettlementTransactionCondition12Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition12Choice.Proprietary),nameof(SettlementTransactionCondition12Choice.Proprietary))]
    [IsoId("_Al_19fv0EeC5cppCUzSD9A")]
    [DisplayName("Settlement Transaction Condition 12 Choice")]
    public abstract partial record SettlementTransactionCondition12Choice_
    {
    }
}
