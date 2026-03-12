// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus7Choice
{
    /// <summary>
    /// Status applicable globally to the meeting instruction message.
    /// </summary>
    [IsoId("_8bzrA6-nEemJ1NnLPsTFaw")]
    [DisplayName("Global Instruction Status")]
    public partial record GlobalInstructionStatus : InstructionStatus7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
