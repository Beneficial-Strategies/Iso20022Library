// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD4Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD4Choice.Repo))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD4Choice.StockLoan),nameof(AdjustedBalanceTypeSD4Choice.StockLoan))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD4Choice.Repo),nameof(AdjustedBalanceTypeSD4Choice.Repo))]
    [IsoId("_RWpyEcSTEeeRJJtE9TSlkw")]
    [DisplayName("Adjusted Balance Type SD 4 Choice")]
    public abstract partial record AdjustedBalanceTypeSD4Choice_
    {
    }
}
