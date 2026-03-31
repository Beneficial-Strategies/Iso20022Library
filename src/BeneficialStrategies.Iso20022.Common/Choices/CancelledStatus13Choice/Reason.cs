// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus13Choice
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_P3gGFSY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    public record Reason : CancelledStatus13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required CancelledStatusReason3Code Value { get; init; }
    }
}
