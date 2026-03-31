// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a known portfolio code and a code applicable when the code is unknown.
    /// </summary>
    [KnownType(typeof(PortfolioCode1Choice.Portfolio))]
    [KnownType(typeof(PortfolioCode1Choice.NoCode))]
    [JsonDerivedType(
        typeof(PortfolioCode1Choice.Portfolio),
        nameof(PortfolioCode1Choice.Portfolio)
    )]
    [JsonDerivedType(typeof(PortfolioCode1Choice.NoCode), nameof(PortfolioCode1Choice.NoCode))]
    [IsoId("_FQG3gHixEeqKjIYaFgh_2g")]
    [DisplayName("Portfolio Code 1 Choice")]
    public abstract record PortfolioCode1Choice_ { }
}
