// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition18Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition18Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition18Choice.Code),
        nameof(SettlementTransactionCondition18Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition18Choice.Proprietary),
        nameof(SettlementTransactionCondition18Choice.Proprietary)
    )]
    [IsoId("_rSNc0Tw0EeW3QqUkIQtIUA")]
    [DisplayName("Settlement Transaction Condition 18 Choice")]
    public abstract record SettlementTransactionCondition18Choice_ { }
}
