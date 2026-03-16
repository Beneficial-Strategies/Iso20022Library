// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio3Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio3Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio3Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio3Choice.TaxEfficientProduct),
        nameof(FundPortfolio3Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio3Choice.GeneralInvestment),
        nameof(FundPortfolio3Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio3Choice.Pension), nameof(FundPortfolio3Choice.Pension))]
    [IsoId("_UorNQU7cEeifNrXGwadPmg")]
    [DisplayName("Fund Portfolio 3 Choice")]
    public abstract record FundPortfolio3Choice_ { }
}
