// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus5Choice
{
    /// <summary>
    /// Provides status information related to a pending cancellation request.
    /// </summary>
    [IsoId("_lFW2dwFnEeG2HcWTGfYeDQ")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionCancellationRequestStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
