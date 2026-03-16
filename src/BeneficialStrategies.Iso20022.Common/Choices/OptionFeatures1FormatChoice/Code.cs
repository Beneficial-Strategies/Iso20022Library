// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeatures1FormatChoice
{
    /// <summary>
    /// Standard code to specify the feature of an option.
    /// </summary>
    [IsoId("_Rm2nFtp-Ed-ak6NoX_4Aeg_1295909960")]
    [DisplayName("Code")]
    public record Code : OptionFeatures1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the feature of an option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionFeatures1Code Value { get; init; }
    }
}
