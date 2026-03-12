// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice of the two leg transaction type.
    /// </summary>
    [KnownType(typeof(TwoLegTransactionType1Choice.FutureOrOptionDetails))]
    [KnownType(typeof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType1Choice.FutureOrOptionDetails),nameof(TwoLegTransactionType1Choice.FutureOrOptionDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails),nameof(TwoLegTransactionType1Choice.SecuritiesFinancingDetails))]
    [IsoId("_AYOINdokEeC60axPepSq7g_1757509328")]
    [DisplayName("Two Leg Transaction Type 1 Choice")]
    public abstract partial record TwoLegTransactionType1Choice_
    {
    }
}
