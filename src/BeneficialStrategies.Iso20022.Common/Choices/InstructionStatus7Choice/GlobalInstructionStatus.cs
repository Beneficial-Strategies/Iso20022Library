// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus7Choice
{
    /// <summary>
    /// Status applicable globally to the meeting instruction message.
    /// </summary>
    [IsoId("_8bzrA6-nEemJ1NnLPsTFaw")]
    [DisplayName("Global Instruction Status")]
    public record GlobalInstructionStatus : InstructionStatus7Choice_ { }
}
