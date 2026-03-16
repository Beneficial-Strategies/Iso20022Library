// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio8Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio8Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio8Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio8Choice.TaxEfficientProduct),
        nameof(FundPortfolio8Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio8Choice.GeneralInvestment),
        nameof(FundPortfolio8Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio8Choice.Pension), nameof(FundPortfolio8Choice.Pension))]
    [IsoId("_X_g32elqEeuvhrZwLF0fDg")]
    [DisplayName("Fund Portfolio 8 Choice")]
    public abstract record FundPortfolio8Choice_ { }
}
