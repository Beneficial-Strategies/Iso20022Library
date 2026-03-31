// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountStatusUpdateInstruction1Choice
{
    /// <summary>
    /// Type of change to the account status expressed as a code.
    /// </summary>
    [IsoId("_xWgD8Hi5EeaRm5xIK6nGuQ")]
    [DisplayName("Code")]
    public record Code : AccountStatusUpdateInstruction1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account status update instructed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountStatusUpdateInstruction1Code Value { get; init; }
    }
}
