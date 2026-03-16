// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriorityCode3Choice
{
    /// <summary>
    /// Priority code, in a coded form.
    /// </summary>
    [IsoId("_5eGn4RbwEeOy-PlRuFSUzQ")]
    [DisplayName("Code")]
    public record Code : PriorityCode3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the priority level of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Priority1Code Value { get; init; }
    }
}
