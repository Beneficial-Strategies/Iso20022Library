// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction conditions.
    /// </summary>
    [KnownType(typeof(SettlementTransactionCondition1Choice.Code))]
    [KnownType(typeof(SettlementTransactionCondition1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition1Choice.Code),
        nameof(SettlementTransactionCondition1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionCondition1Choice.Proprietary),
        nameof(SettlementTransactionCondition1Choice.Proprietary)
    )]
    [IsoId("_QwK2tdp-Ed-ak6NoX_4Aeg_453401651")]
    [DisplayName("Settlement Transaction Condition 1 Choice")]
    public abstract record SettlementTransactionCondition1Choice_ { }
}
