// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode5Choice
{
    /// <summary>
    /// Collateralisation was performed on a transaction level basis or if the collateral portfolio code is not known at the time of reporting.
    /// </summary>
    [IsoId("_wnwaszICEe2fXedS_ucFOA")]
    [DisplayName("No Portfolio")]
    public record NoPortfolio : PortfolioCode5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies special purpose codes.
        /// </summary>
        [IsoXmlTag("NoPrtfl")]
        public required NotApplicable1Code Value { get; init; }
    }
}
