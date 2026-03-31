// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition6Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition6Choice.Code),
        nameof(SettlementTransactionCondition6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition6Choice.Proprietary),
        nameof(SettlementTransactionCondition6Choice.Proprietary)
    )]
    [IsoId("_3LNsneEAEd-udr336SN7mQ")]
    [DisplayName("Settlement Transaction Condition 6 Choice")]
    public abstract record SettlementTransactionCondition6Choice_ { }
}
