// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio9Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio9Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio9Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio9Choice.TaxEfficientProduct),
        nameof(FundPortfolio9Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio9Choice.GeneralInvestment),
        nameof(FundPortfolio9Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio9Choice.Pension), nameof(FundPortfolio9Choice.Pension))]
    [IsoId("_ZCbGTelqEeuvhrZwLF0fDg")]
    [DisplayName("Fund Portfolio 9 Choice")]
    public abstract record FundPortfolio9Choice_ { }
}
