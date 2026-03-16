// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio2Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio2Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio2Choice.Pension))]
    [JsonDerivedType(
        typeof(FundPortfolio2Choice.TaxEfficientProduct),
        nameof(FundPortfolio2Choice.TaxEfficientProduct)
    )]
    [JsonDerivedType(
        typeof(FundPortfolio2Choice.GeneralInvestment),
        nameof(FundPortfolio2Choice.GeneralInvestment)
    )]
    [JsonDerivedType(typeof(FundPortfolio2Choice.Pension), nameof(FundPortfolio2Choice.Pension))]
    [IsoId("_ozJ3sU4aEeiQHa-q1Uephw")]
    [DisplayName("Fund Portfolio 2 Choice")]
    public abstract record FundPortfolio2Choice_ { }
}
