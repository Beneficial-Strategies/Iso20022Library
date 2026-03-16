// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettleStyle2Choice
{
    /// <summary>
    /// Settle style expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_ra2T0eLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : SettleStyle2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when the option contract settles.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettleStyle1Code Value { get; init; }
    }
}
