// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status2Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_UaQi2Np-Ed-ak6NoX_4Aeg_-243613676")]
    [DisplayName("Instruction Processing Status")]
    public partial record InstructionProcessingStatus : Status2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
