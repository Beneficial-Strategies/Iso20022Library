// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus12Choice
{
    /// <summary>
    /// Pending.
    /// </summary>
    [DisplayName("Pending")]
    public record Pending : InstructionStatus12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus70Choice_ Value { get; init; }
    }
}
