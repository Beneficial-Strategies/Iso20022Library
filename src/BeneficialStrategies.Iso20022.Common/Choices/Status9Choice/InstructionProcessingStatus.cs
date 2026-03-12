// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status9Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_4BGdLf8dEeCrw_OT0uBMXQ")]
    [DisplayName("Instruction Processing Status")]
    public partial record InstructionProcessingStatus : Status9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
