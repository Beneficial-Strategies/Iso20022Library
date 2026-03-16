// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition36Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition36Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition36Choice.Code),
        nameof(SettlementTransactionCondition36Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition36Choice.Proprietary),
        nameof(SettlementTransactionCondition36Choice.Proprietary)
    )]
    [IsoId("_lfXiHSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Transaction Condition 36 Choice")]
    public abstract record SettlementTransactionCondition36Choice_ { }
}
