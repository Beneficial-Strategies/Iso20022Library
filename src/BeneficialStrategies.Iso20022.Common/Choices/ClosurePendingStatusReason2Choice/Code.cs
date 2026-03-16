// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosurePendingStatusReason2Choice
{
    /// <summary>
    /// Reason for the closure pending status expressed as a code.
    /// </summary>
    [IsoId("_9J7XcWCLEeabZtzjEVWYCQ")]
    [DisplayName("Code")]
    public record Code : ClosurePendingStatusReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for the closure pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ClosurePendingStatusReason1Code Value { get; init; }
    }
}
