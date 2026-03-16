// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat6Choice
{
    /// <summary>
    /// Standard code to specify the type of intermediate security distribution.
    /// </summary>
    [IsoId("_x8Lwk-AZEd-D2OAFXdoRmA")]
    [DisplayName("Code")]
    public record Code : IntermediateSecuritiesDistributionTypeFormat6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of intermediate security distribution.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required IntermediateSecurityDistributionType4Code Value { get; init; }
    }
}
