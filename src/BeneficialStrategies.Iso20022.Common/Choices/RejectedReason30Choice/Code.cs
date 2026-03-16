// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason30Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_eKVR2sAUEembi_x1QDJfxw")]
    [DisplayName("Code")]
    public record Code : RejectedReason30Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the identification disclosure response has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason52Code Value { get; init; }
    }
}
