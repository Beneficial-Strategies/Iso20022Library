// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralType22Choice
{
    /// <summary>
    /// General Collateral.
    /// </summary>
    [DisplayName("General Collateral")]
    public record GeneralCollateral : CollateralType22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("GnlColl")]
        public required GeneralCollateral4 Value { get; init; }
    }
}
