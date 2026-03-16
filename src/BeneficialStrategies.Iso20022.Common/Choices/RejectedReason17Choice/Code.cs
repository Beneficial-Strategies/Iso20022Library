// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason17Choice
{
    /// <summary>
    /// Rejected reason expressed as a code.
    /// </summary>
    [IsoId("_-hqnMSYuEeW_ZNn8gbfY7Q")]
    [DisplayName("Code")]
    public record Code : RejectedReason17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a cancellation rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationRejectedReason1Code Value { get; init; }
    }
}
