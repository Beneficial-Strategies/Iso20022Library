// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType2FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of charge.
    /// </summary>
    [IsoId("_Rl0FRdp-Ed-ak6NoX_4Aeg_-1541781007")]
    [DisplayName("Code")]
    public record Code : ChargeType2FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies charges linked to the type of service.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeType14Code Value { get; init; }
    }
}
