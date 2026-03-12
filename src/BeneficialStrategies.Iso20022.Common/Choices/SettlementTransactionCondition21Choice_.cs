// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition21Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition21Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition21Choice.Code),nameof(SettlementTransactionCondition21Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition21Choice.Proprietary),nameof(SettlementTransactionCondition21Choice.Proprietary))]
    [IsoId("_5TJ-lZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition 21 Choice")]
    public abstract partial record SettlementTransactionCondition21Choice_
    {
    }
}
