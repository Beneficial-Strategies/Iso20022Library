// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason51Choice
{
    /// <summary>
    /// Pending reason specified as a code.
    /// </summary>
    [IsoId("_fOg6EbLLEemDyeh7tbvg1w")]
    [DisplayName("Code")]
    public record Code : PendingReason51Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the instruction is pending.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason16Code Value { get; init; }
    }
}
