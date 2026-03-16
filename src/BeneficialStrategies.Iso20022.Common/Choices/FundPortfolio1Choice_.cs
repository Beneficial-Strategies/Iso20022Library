// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio1Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio1Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio1Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio1Choice.TaxEfficientProduct),
        nameof(FundPortfolio1Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio1Choice.GeneralInvestment),
        nameof(FundPortfolio1Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio1Choice.Pension), nameof(FundPortfolio1Choice.Pension))]
    [IsoId("_iMMFYU4HEeiQHa-q1Uephw")]
    [DisplayName("Fund Portfolio 1 Choice")]
    public abstract record FundPortfolio1Choice_ { }
}
