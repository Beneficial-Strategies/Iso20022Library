// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SuspendedStatusReason5Choice
{
    /// <summary>
    /// Suspended reason expressed as a code.
    /// </summary>
    [IsoId("_o0mHQUHlEea8I67lh6qdSQ")]
    [DisplayName("Code")]
    public record Code : SuspendedStatusReason5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a suspended status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SuspendedStatusReason3Code Value { get; init; }
    }
}
