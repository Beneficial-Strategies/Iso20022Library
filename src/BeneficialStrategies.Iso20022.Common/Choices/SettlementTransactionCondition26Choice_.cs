// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition26Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition26Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition26Choice.Code),nameof(SettlementTransactionCondition26Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition26Choice.Proprietary),nameof(SettlementTransactionCondition26Choice.Proprietary))]
    [IsoId("_6IdOp5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition 26 Choice")]
    public abstract partial record SettlementTransactionCondition26Choice_
    {
    }
}
