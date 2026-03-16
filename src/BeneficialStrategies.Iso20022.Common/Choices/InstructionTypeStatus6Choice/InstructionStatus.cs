// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus6Choice
{
    /// <summary>
    /// Instruction Status.
    /// </summary>
    [DisplayName("Instruction Status")]
    public record InstructionStatus : InstructionTypeStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("InstrSts")]
        public required DetailedInstructionStatus20 Value { get; init; }
    }
}
