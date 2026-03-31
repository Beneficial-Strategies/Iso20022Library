// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus10Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_PNMLQQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Code")]
    public record Code : AffirmationStatus10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the affirmation status of a trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AffirmationStatus1Code Value { get; init; }
    }
}
