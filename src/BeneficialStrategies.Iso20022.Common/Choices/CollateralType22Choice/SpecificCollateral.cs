// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralType22Choice
{
    /// <summary>
    /// Specific Collateral.
    /// </summary>
    [DisplayName("Specific Collateral")]
    public record SpecificCollateral : CollateralType22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SpcfcColl")]
        public required SpecificCollateral3 Value { get; init; }
    }
}
