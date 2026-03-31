// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason11Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_cgnRxZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : CancelledReason11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for the cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason6Code Value { get; init; }
    }
}
