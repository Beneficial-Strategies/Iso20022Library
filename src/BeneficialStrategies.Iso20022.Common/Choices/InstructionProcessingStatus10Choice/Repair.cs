// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus10Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_4BPnGv8dEeCrw_OT0uBMXQ")]
    [DisplayName("Repair")]
    public partial record Repair : InstructionProcessingStatus10Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
