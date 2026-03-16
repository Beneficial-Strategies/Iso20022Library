// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason39Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status expressed as a code.
    /// </summary>
    [IsoId("_GmPv0RIwEeydmIVkS03esw")]
    [DisplayName("Code")]
    public record Code : RejectionReason39Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the transaction or in the instruction has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason62Code Value { get; init; }
    }
}
