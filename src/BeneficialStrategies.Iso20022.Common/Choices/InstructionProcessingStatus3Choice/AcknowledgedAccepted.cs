// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus3Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_UZg78tp-Ed-ak6NoX_4Aeg_-332347332")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : InstructionProcessingStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptd")]
        public required AcknowledgedAcceptedStatus3Choice_ Value { get; init; }
    }
}
