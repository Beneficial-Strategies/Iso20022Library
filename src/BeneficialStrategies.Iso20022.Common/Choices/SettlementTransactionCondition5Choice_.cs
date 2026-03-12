// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition5Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition5Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionCondition5Choice.Code),nameof(SettlementTransactionCondition5Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionCondition5Choice.Proprietary),nameof(SettlementTransactionCondition5Choice.Proprietary))]
    [IsoId("_8alx8d0gEd-Cb-IGbQ4hBQ")]
    [DisplayName("Settlement Transaction Condition 5 Choice")]
    public abstract partial record SettlementTransactionCondition5Choice_
    {
    }
}
