// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the unique codes identifying the portfolio.
    /// </summary>
    [KnownType(typeof(CollateralPortfolioCode5Choice.Portfolio))]
    [KnownType(typeof(CollateralPortfolioCode5Choice.MarginPortfolioCode))]
    [JsonDerivedType(typeof(CollateralPortfolioCode5Choice.Portfolio),nameof(CollateralPortfolioCode5Choice.Portfolio))]
    [JsonDerivedType(typeof(CollateralPortfolioCode5Choice.MarginPortfolioCode),nameof(CollateralPortfolioCode5Choice.MarginPortfolioCode))]
    [IsoId("_YwE-cTIDEe2fXedS_ucFOA")]
    [DisplayName("Collateral Portfolio Code 5 Choice")]
    public abstract partial record CollateralPortfolioCode5Choice_
    {
    }
}
