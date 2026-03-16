// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DistributionType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the distribution type.
    /// </summary>
    [IsoId("_RmZ7Jtp-Ed-ak6NoX_4Aeg_-1257954049")]
    [DisplayName("Code")]
    public record Code : DistributionType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DistributionType1Code Value { get; init; }
    }
}
