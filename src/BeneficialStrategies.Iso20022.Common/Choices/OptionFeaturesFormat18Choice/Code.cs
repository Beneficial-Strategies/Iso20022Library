// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat18Choice
{
    /// <summary>
    /// Standard code to specify the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_3by2oUGLEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : OptionFeaturesFormat18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the feature of an option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionFeatures6Code Value { get; init; }
    }
}
