// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio4Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio4Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio4Choice.Pension))]
    [JsonDerivedType(typeof(FundPortfolio4Choice.TaxEfficientProduct),nameof(FundPortfolio4Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio4Choice.GeneralInvestment),nameof(FundPortfolio4Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio4Choice.Pension),nameof(FundPortfolio4Choice.Pension))]
    [IsoId("_U3qR0ZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 4 Choice")]
    public abstract partial record FundPortfolio4Choice_
    {
    }
}
