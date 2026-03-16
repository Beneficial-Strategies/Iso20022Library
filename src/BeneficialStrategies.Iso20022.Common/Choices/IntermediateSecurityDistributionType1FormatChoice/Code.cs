// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecurityDistributionType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of intermediate security distribution.
    /// </summary>
    [IsoId("_Rms2E9p-Ed-ak6NoX_4Aeg_1911197381")]
    [DisplayName("Code")]
    public record Code : IntermediateSecurityDistributionType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of intermediate security distribution.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required IntermediateSecurityDistributionType1Code Value { get; init; }
    }
}
