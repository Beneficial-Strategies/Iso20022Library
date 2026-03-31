// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus6Choice
{
    /// <summary>
    /// Cancellation Status.
    /// </summary>
    [DisplayName("Cancellation Status")]
    public record CancellationStatus : InstructionTypeStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CxlSts")]
        public required CancellationStatus27Choice_ Value { get; init; }
    }
}
