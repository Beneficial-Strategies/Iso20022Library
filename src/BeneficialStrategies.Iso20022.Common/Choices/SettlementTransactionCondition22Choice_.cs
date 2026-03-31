// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition22Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition22Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition22Choice.Code),
        nameof(SettlementTransactionCondition22Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition22Choice.Proprietary),
        nameof(SettlementTransactionCondition22Choice.Proprietary)
    )]
    [IsoId("_5m5aZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition 22 Choice")]
    public abstract record SettlementTransactionCondition22Choice_ { }
}
