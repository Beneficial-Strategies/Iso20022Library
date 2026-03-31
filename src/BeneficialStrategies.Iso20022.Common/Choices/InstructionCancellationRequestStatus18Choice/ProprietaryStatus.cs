// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus18Choice
{
    /// <summary>
    /// Proprietary Status.
    /// </summary>
    [DisplayName("Proprietary Status")]
    public record ProprietaryStatus : InstructionCancellationRequestStatus18Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason7 Value { get; init; }
    }
}
