// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition34Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition34Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition34Choice.Code),
        nameof(SettlementTransactionCondition34Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition34Choice.Proprietary),
        nameof(SettlementTransactionCondition34Choice.Proprietary)
    )]
    [IsoId("_U3q2uQllEeuQ1MenzX1l-g")]
    [DisplayName("Settlement Transaction Condition 34 Choice")]
    public abstract record SettlementTransactionCondition34Choice_ { }
}
