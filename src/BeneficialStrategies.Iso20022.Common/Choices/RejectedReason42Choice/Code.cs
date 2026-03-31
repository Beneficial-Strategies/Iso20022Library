// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason42Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_W8de8Rn0EeyroI8qKgB7Mg")]
    [DisplayName("Code")]
    public record Code : RejectedReason42Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction/cancellation request has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason67Code Value { get; init; }
    }
}
