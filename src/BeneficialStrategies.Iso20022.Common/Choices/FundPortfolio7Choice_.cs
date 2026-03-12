// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio7Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio7Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio7Choice.Pension))]
    [JsonDerivedType(typeof(FundPortfolio7Choice.TaxEfficientProduct),nameof(FundPortfolio7Choice.TaxEfficientProduct))]
    [JsonDerivedType(typeof(FundPortfolio7Choice.GeneralInvestment),nameof(FundPortfolio7Choice.GeneralInvestment))]
    [JsonDerivedType(typeof(FundPortfolio7Choice.Pension),nameof(FundPortfolio7Choice.Pension))]
    [IsoId("_Xn1_oelfEeu9cf4XM82AQQ")]
    [DisplayName("Fund Portfolio 7 Choice")]
    public abstract partial record FundPortfolio7Choice_
    {
    }
}
