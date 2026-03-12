// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition35Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition35Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition35Choice.Code),nameof(SettlementTransactionCondition35Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition35Choice.Proprietary),nameof(SettlementTransactionCondition35Choice.Proprietary))]
    [IsoId("_wPWpUQzTEeuTPv2wqaotHg")]
    [DisplayName("Settlement Transaction Condition 35 Choice")]
    public abstract partial record SettlementTransactionCondition35Choice_
    {
    }
}
