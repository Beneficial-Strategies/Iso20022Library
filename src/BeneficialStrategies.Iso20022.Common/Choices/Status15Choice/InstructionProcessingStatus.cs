// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status15Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_EU__9SRhEeO8sskhVI3IDA")]
    [DisplayName("Instruction Processing Status")]
    public partial record InstructionProcessingStatus : Status15Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
