// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition20Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition20Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition20Choice.Code),
        nameof(SettlementTransactionCondition20Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition20Choice.Proprietary),
        nameof(SettlementTransactionCondition20Choice.Proprietary)
    )]
    [IsoId("_moCnIWaOEeWZev0W8F756g")]
    [DisplayName("Settlement Transaction Condition 20 Choice")]
    public abstract record SettlementTransactionCondition20Choice_ { }
}
