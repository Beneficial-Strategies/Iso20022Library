// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus2Choice
{
    /// <summary>
    /// Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.
    /// </summary>
    [IsoId("_rZOb016uEeSyc4g_pm5hbw")]
    [DisplayName("Cancellation Status")]
    public partial record CancellationStatus : InstructionTypeStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
