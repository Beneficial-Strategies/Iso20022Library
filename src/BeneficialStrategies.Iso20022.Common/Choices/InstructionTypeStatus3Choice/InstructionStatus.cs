// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus3Choice
{
    /// <summary>
    /// Status of the meeting instruction message or of the individual meeting instruction(s). The message is identified in InstructionType/InstructionIdentification.
    /// </summary>
    [IsoId("_8GFSoa-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Status")]
    public record InstructionStatus : InstructionTypeStatus3Choice_ { }
}
