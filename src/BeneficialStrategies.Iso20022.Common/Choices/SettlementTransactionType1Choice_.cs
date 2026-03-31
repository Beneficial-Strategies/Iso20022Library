// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SettlementTransactionType1Choice.Code))]
    [KnownType(typeof(SettlementTransactionType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementTransactionType1Choice.Code),
        nameof(SettlementTransactionType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementTransactionType1Choice.Proprietary),
        nameof(SettlementTransactionType1Choice.Proprietary)
    )]
    [IsoId("_AbWUstokEeC60axPepSq7g_-595952701")]
    [DisplayName("Settlement Transaction Type 1 Choice")]
    public abstract record SettlementTransactionType1Choice_ { }
}
