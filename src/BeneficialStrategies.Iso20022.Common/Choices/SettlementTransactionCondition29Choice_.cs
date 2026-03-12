// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition29Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition29Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition29Choice.Code),nameof(SettlementTransactionCondition29Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition29Choice.Proprietary),nameof(SettlementTransactionCondition29Choice.Proprietary))]
    [IsoId("_6dqpp5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition 29 Choice")]
    public abstract partial record SettlementTransactionCondition29Choice_
    {
    }
}
