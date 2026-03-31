// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountStatusUpdateInstructionReason2Choice
{
    /// <summary>
    /// Reason for the instruction to change the account status expressed as a code.
    /// </summary>
    [IsoId("_08pj4Xi8EeaRm5xIK6nGuQ")]
    [DisplayName("Code")]
    public record Code : AccountStatusUpdateInstructionReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Sepcifes the reason for a request for a change to an account status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountStatusUpdateRequestReason1Code Value { get; init; }
    }
}
