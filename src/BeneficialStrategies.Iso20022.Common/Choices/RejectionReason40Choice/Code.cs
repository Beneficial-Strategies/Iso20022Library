// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason40Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status expressed as a code.
    /// </summary>
    [IsoId("_VB0okRIwEeydmIVkS03esw")]
    [DisplayName("Code")]
    public record Code : RejectionReason40Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a cancellation request has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason63Code Value { get; init; }
    }
}
