// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus8Choice
{
    /// <summary>
    /// Complete.
    /// </summary>
    [DisplayName("Complete")]
    public record Complete : EventProcessingStatus8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmplt")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
