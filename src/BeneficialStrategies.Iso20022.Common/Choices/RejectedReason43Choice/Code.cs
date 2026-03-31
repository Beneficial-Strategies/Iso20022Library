// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason43Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_LVsasRn1EeyroI8qKgB7Mg")]
    [DisplayName("Code")]
    public record Code : RejectedReason43Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction request has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason64Code Value { get; init; }
    }
}
