// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio6Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio6Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio6Choice.Pension))]
    [JsonDerivedType(typeof(FundPortfolio6Choice.TaxEfficientProduct),nameof(FundPortfolio6Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio6Choice.GeneralInvestment),nameof(FundPortfolio6Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio6Choice.Pension),nameof(FundPortfolio6Choice.Pension))]
    [IsoId("_1TpcAZNMEemQB_8XA98K0Q")]
    [DisplayName("Fund Portfolio 6 Choice")]
    public abstract partial record FundPortfolio6Choice_
    {
    }
}
