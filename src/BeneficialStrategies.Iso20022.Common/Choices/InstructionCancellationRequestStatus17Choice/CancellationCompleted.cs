// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus17Choice
{
    /// <summary>
    /// Cancellation Completed.
    /// </summary>
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : InstructionCancellationRequestStatus17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CxlCmpltd")]
        public required CancelledStatus11Choice_ Value { get; init; }
    }
}
