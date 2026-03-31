// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationCompleteReason1Choice
{
    /// <summary>
    /// Cancelled complete reason expressed as a code.
    /// </summary>
    [IsoId("_inS8ICYwEeW_ZNn8gbfY7Q")]
    [DisplayName("Code")]
    public record Code : CancellationCompleteReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason1Code Value { get; init; }
    }
}
