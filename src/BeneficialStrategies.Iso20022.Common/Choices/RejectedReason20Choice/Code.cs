// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason20Choice
{
    /// <summary>
    /// Rejected reason expressed as a code.
    /// </summary>
    [IsoId("_aciugUHjEea8I67lh6qdSQ")]
    [DisplayName("Code")]
    public record Code : RejectedReason20Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason11Code Value { get; init; }
    }
}
