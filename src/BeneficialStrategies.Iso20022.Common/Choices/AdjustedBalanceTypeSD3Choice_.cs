// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD3Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD3Choice.Repo))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD3Choice.StockLoan),nameof(AdjustedBalanceTypeSD3Choice.StockLoan))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD3Choice.Repo),nameof(AdjustedBalanceTypeSD3Choice.Repo))]
    [IsoId("_RPc5-6GGEeSpipW1FBSFVg")]
    [DisplayName("Adjusted Balance Type SD 3 Choice")]
    public abstract partial record AdjustedBalanceTypeSD3Choice_
    {
    }
}
