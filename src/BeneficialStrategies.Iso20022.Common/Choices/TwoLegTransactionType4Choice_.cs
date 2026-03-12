// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice of the two leg transaction type.
    /// </summary>
    [KnownType(typeof(TwoLegTransactionType4Choice.FutureOrOptionDetails))]
    [KnownType(typeof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType4Choice.FutureOrOptionDetails),nameof(TwoLegTransactionType4Choice.FutureOrOptionDetails))]
    [JsonDerivedType(typeof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails),nameof(TwoLegTransactionType4Choice.SecuritiesFinancingDetails))]
    [IsoId("_854_sQhKEe2fOITqoTnSLQ")]
    [DisplayName("Two Leg Transaction Type 4 Choice")]
    public abstract partial record TwoLegTransactionType4Choice_
    {
    }
}
