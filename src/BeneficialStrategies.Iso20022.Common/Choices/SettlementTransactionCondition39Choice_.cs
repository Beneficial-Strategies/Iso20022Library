// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition39Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition39Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition39Choice.Code),
        nameof(SettlementTransactionCondition39Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition39Choice.Proprietary),
        nameof(SettlementTransactionCondition39Choice.Proprietary)
    )]
    [IsoId("_NIiaMSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Transaction Condition 39 Choice")]
    public abstract record SettlementTransactionCondition39Choice_ { }
}
