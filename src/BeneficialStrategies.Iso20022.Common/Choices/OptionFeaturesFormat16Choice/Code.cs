// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat16Choice
{
    /// <summary>
    /// Standard code to specify the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_pf4hY0EHEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : OptionFeaturesFormat16Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the features that may apply to a corporate action option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionFeatures8Code Value { get; init; }
    }
}
