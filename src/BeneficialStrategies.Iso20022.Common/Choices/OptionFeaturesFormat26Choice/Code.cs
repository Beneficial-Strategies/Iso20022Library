// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat26Choice
{
    /// <summary>
    /// Standard code to specify the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_cs42w_fSEeiNZp_PtLohLw")]
    [DisplayName("Code")]
    public record Code : OptionFeaturesFormat26Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the features that may apply to a corporate action option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionFeatures11Code Value { get; init; }
    }
}
