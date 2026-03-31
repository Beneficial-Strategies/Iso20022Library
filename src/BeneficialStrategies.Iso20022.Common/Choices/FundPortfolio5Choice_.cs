// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio5Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio5Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio5Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio5Choice.TaxEfficientProduct),
        nameof(FundPortfolio5Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio5Choice.GeneralInvestment),
        nameof(FundPortfolio5Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio5Choice.Pension), nameof(FundPortfolio5Choice.Pension))]
    [IsoId("_nbBfUZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 5 Choice")]
    public abstract record FundPortfolio5Choice_ { }
}
