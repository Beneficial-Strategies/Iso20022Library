// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus56Choice
{
    /// <summary>
    /// Returned.
    /// </summary>
    [DisplayName("Returned")]
    public record Returned : InstructionProcessingStatus56Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rtrd")]
        public required ReturnedStatus2Choice_ Value { get; init; }
    }
}
