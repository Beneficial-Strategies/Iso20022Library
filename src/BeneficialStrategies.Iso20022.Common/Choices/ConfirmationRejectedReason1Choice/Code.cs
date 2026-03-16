// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConfirmationRejectedReason1Choice
{
    /// <summary>
    /// Reason for the rejected status expressed as a code.
    /// </summary>
    [IsoId("__OYdIXZxEeaN2c674jyTxQ")]
    [DisplayName("Code")]
    public record Code : ConfirmationRejectedReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a confirmation rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedConfirmationStatusReason1Code Value { get; init; }
    }
}
