// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason7Choice
{
    /// <summary>
    /// Pending reason specified as a code.
    /// </summary>
    [IsoId("_ccJAQbKjEemux5trsZcCpw")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason why the cancellation request has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason6Code Value { get; init; }
    }
}
