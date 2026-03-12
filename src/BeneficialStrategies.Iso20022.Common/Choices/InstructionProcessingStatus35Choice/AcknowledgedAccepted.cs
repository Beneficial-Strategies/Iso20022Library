// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus35Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_iE4OhffZEeiNZp_PtLohLw")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : InstructionProcessingStatus35Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
