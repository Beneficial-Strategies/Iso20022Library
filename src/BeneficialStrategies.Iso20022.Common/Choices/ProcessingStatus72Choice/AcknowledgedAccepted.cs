// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus72Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the executing party.
    /// </summary>
    [IsoId("_a2nK0eLtEeWOD7aAy2fAcA")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ProcessingStatus72Choice_
    {
        /// <summary>
        /// Specifies the reason of the Status.
        /// </summary>
        [IsoId("_qTYa0eLtEeWOD7aAy2fAcA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ProprietaryReason4? Reason { get; init; }
    }
}
