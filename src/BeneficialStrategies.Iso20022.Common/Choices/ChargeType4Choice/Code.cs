// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType4Choice
{
    /// <summary>
    /// Type of charge expressed as a code.
    /// </summary>
    [IsoId("_wTqbsQatEeS3lpTattq7hg")]
    [DisplayName("Code")]
    public record Code : ChargeType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which a charge is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeType12Code Value { get; init; }
    }
}
