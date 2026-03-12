// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition2Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition2Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition2Choice.Code),nameof(SettlementTransactionCondition2Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition2Choice.Proprietary),nameof(SettlementTransactionCondition2Choice.Proprietary))]
    [IsoId("_QuYG89p-Ed-ak6NoX_4Aeg_-450512718")]
    [DisplayName("Settlement Transaction Condition 2 Choice")]
    public abstract partial record SettlementTransactionCondition2Choice_
    {
    }
}
