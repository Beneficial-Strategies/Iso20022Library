// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition28Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition28Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition28Choice.Code),
        nameof(SettlementTransactionCondition28Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition28Choice.Proprietary),
        nameof(SettlementTransactionCondition28Choice.Proprietary)
    )]
    [IsoId("_6SbDLZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Transaction Condition 28 Choice")]
    public abstract record SettlementTransactionCondition28Choice_ { }
}
