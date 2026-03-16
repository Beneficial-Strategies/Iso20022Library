// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode6Choice
{
    /// <summary>
    /// Margin Portfolio Code.
    /// </summary>
    [DisplayName("Margin Portfolio Code")]
    public record MarginPortfolioCode : CollateralPortfolioCode6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MrgnPrtflCd")]
        public required MarginPortfolio4 Value { get; init; }
    }
}
