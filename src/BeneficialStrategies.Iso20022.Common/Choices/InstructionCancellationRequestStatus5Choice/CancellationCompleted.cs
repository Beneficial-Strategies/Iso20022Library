// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus5Choice
{
    /// <summary>
    /// Provides status information related to a instruction cancellation request completed.
    /// </summary>
    [IsoId("_lFW2WQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Cancellation Completed")]
    public partial record CancellationCompleted : InstructionCancellationRequestStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
