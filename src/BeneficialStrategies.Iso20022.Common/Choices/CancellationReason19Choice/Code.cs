// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason19Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_jGFhYTnuEeWfSKvvZlhRKg")]
    [DisplayName("Code")]
    public record Code : CancellationReason19Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for the cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason13Code Value { get; init; }
    }
}
