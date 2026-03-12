// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition31Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition31Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition31Choice.Code),nameof(SettlementTransactionCondition31Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition31Choice.Proprietary),nameof(SettlementTransactionCondition31Choice.Proprietary))]
    [IsoId("_sWKeMZCBEeakHoV5BVecAQ")]
    [DisplayName("Settlement Transaction Condition 31 Choice")]
    public abstract partial record SettlementTransactionCondition31Choice_
    {
    }
}
