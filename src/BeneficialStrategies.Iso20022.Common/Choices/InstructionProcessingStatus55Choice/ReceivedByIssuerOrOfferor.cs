// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus55Choice
{
    /// <summary>
    /// Received By Issuer Or Offeror.
    /// </summary>
    [DisplayName("Received By Issuer Or Offeror")]
    public record ReceivedByIssuerOrOfferor : InstructionProcessingStatus55Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RcvdByIssrOrOfferr")]
        public required NoSpecifiedReason1 Value { get; init; }
    }
}
