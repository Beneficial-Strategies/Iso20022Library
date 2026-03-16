// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InRepairStatusReason5Choice
{
    /// <summary>
    /// In repair reason expressed as a code.
    /// </summary>
    [IsoId("_P8QicUHqEea8I67lh6qdSQ")]
    [DisplayName("Code")]
    public record Code : InRepairStatusReason5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a In Repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InRepairStatusReason1Code Value { get; init; }
    }
}
