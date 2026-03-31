// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition11Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition11Choice.Code),
        nameof(SettlementTransactionCondition11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition11Choice.Proprietary),
        nameof(SettlementTransactionCondition11Choice.Proprietary)
    )]
    [IsoId("_AbDZxNokEeC60axPepSq7g_-1908896660")]
    [DisplayName("Settlement Transaction Condition 11 Choice")]
    public abstract record SettlementTransactionCondition11Choice_ { }
}
