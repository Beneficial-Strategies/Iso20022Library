// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a known portfolio code and a code applicable when the code is unknown.
    /// </summary>
    [KnownType(typeof(PortfolioCode3Choice.Code))]
    [KnownType(typeof(PortfolioCode3Choice.NoPortfolio))]
    [JsonDerivedType(typeof(PortfolioCode3Choice.Code), nameof(PortfolioCode3Choice.Code))]
    [JsonDerivedType(
        typeof(PortfolioCode3Choice.NoPortfolio),
        nameof(PortfolioCode3Choice.NoPortfolio)
    )]
    [IsoId("_WMQcEVzGEeyTL-yEabFeNg")]
    [DisplayName("Portfolio Code 3 Choice")]
    public abstract record PortfolioCode3Choice_ { }
}
