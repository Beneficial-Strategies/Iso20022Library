// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition30Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition30Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition30Choice.Code),
        nameof(SettlementTransactionCondition30Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition30Choice.Proprietary),
        nameof(SettlementTransactionCondition30Choice.Proprietary)
    )]
    [IsoId("_1VRycUc8EeaBWtcfqEyXyw")]
    [DisplayName("Settlement Transaction Condition 30 Choice")]
    public abstract record SettlementTransactionCondition30Choice_ { }
}
