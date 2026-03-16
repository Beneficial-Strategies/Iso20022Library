// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag13Choice
{
    /// <summary>
    /// Indicate that the security is not collateralised.
    /// </summary>
    [IsoId("_J_aqI8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Uncollateralised")]
    public record Uncollateralised : CollateralFlag13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Uncollsd")]
        public required NoReasonCode Value { get; init; }
    }
}
