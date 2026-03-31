// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeemedRateType2Choice
{
    /// <summary>
    /// Standard code to specify the type of deemed rate.
    /// </summary>
    [IsoId("_sH2RMdBbEee0mNiKMkpGNQ")]
    [DisplayName("Code")]
    public record Code : DeemedRateType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a deemed rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeemedRateType1Code Value { get; init; }
    }
}
