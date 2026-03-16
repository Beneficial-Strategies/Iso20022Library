// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason28Choice
{
    /// <summary>
    /// Rejection reason specified as a code.
    /// </summary>
    [IsoId("_jCSj-rKaEemux5trsZcCpw")]
    [DisplayName("Code")]
    public record Code : RejectedReason28Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the instruction has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason50Code Value { get; init; }
    }
}
