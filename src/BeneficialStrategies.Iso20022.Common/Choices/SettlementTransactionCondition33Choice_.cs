// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition33Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition33Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition33Choice.Code),nameof(SettlementTransactionCondition33Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition33Choice.Proprietary),nameof(SettlementTransactionCondition33Choice.Proprietary))]
    [IsoId("_N_w2sQzXEeuUZuaHWzkTew")]
    [DisplayName("Settlement Transaction Condition 33 Choice")]
    public abstract partial record SettlementTransactionCondition33Choice_
    {
    }
}
