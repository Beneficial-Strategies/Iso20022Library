// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus3Choice
{
    /// <summary>
    /// Status of the meeting instruction message or of the individual meeting instruction(s). The message is identified in InstructionType/InstructionIdentification.
    /// </summary>
    [IsoId("_8GFSoa-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Status")]
    public partial record InstructionStatus : InstructionTypeStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
