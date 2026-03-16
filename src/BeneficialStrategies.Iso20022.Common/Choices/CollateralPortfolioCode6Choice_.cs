// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Collateral Portfolio Code6Choice.
    /// </summary>
    [KnownType(typeof(CollateralPortfolioCode6Choice.MarginPortfolioCode))]
    [KnownType(typeof(CollateralPortfolioCode6Choice.Portfolio))]
    [JsonDerivedType(typeof(CollateralPortfolioCode6Choice.MarginPortfolioCode),nameof(CollateralPortfolioCode6Choice.MarginPortfolioCode))]
    [JsonDerivedType(typeof(CollateralPortfolioCode6Choice.Portfolio),nameof(CollateralPortfolioCode6Choice.Portfolio))]
    [IsoId("_PhHpcbEtEe63r8FIfzOHCQ")]
    [DisplayName("Collateral Portfolio Code6Choice")]
    public abstract partial record CollateralPortfolioCode6Choice_
    {
    }
}
