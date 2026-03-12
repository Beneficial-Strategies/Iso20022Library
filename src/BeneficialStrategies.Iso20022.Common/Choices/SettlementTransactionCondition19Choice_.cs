// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition19Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition19Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition19Choice.Code),nameof(SettlementTransactionCondition19Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition19Choice.Proprietary),nameof(SettlementTransactionCondition19Choice.Proprietary))]
    [IsoId("_GNYdQTxKEeW5v6FXICU4Ew")]
    [DisplayName("Settlement Transaction Condition 19 Choice")]
    public abstract partial record SettlementTransactionCondition19Choice_
    {
    }
}
