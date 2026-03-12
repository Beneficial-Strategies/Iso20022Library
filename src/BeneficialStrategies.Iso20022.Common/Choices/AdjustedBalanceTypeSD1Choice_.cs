// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD1Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD1Choice.Repo))]
    [KnownType(typeof(AdjustedBalanceTypeSD1Choice.Fail))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD1Choice.StockLoan),nameof(AdjustedBalanceTypeSD1Choice.StockLoan))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD1Choice.Repo),nameof(AdjustedBalanceTypeSD1Choice.Repo))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD1Choice.Fail),nameof(AdjustedBalanceTypeSD1Choice.Fail))]
    [IsoId("_1hE44zL3EeKU9IrkkToqcw_-166456088")]
    [DisplayName("Adjusted Balance Type SD 1 Choice")]
    public abstract partial record AdjustedBalanceTypeSD1Choice_
    {
    }
}
