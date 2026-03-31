// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason23Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_90kgsTqzEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : RejectionReason23Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the settlement instruction has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason30Code Value { get; init; }
    }
}
