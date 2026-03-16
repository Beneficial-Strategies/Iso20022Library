// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode6Choice
{
    /// <summary>
    /// Portfolio.
    /// </summary>
    [DisplayName("Portfolio")]
    public record Portfolio : CollateralPortfolioCode6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prtfl")]
        public required PortfolioCode3Choice_ Value { get; init; }
    }
}
