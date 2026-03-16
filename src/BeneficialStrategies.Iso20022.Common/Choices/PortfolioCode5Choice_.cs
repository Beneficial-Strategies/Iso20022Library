// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a known portfolio code and a code applicable when the code is unknown.
    /// </summary>
    [KnownType(typeof(PortfolioCode5Choice.Portfolio))]
    [KnownType(typeof(PortfolioCode5Choice.NoPortfolio))]
    [JsonDerivedType(
        typeof(PortfolioCode5Choice.Portfolio),
        nameof(PortfolioCode5Choice.Portfolio)
    )]
    [JsonDerivedType(
        typeof(PortfolioCode5Choice.NoPortfolio),
        nameof(PortfolioCode5Choice.NoPortfolio)
    )]
    [IsoId("_wm77UTICEe2fXedS_ucFOA")]
    [DisplayName("Portfolio Code 5 Choice")]
    public abstract record PortfolioCode5Choice_ { }
}
