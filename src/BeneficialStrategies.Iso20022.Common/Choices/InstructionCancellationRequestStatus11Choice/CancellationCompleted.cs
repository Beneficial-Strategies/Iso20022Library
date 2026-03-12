// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus11Choice
{
    /// <summary>
    /// Provides status information related to an instruction cancellation request completed.
    /// </summary>
    [IsoId("_1m6cw4luEeavwKddCbm3hg")]
    [DisplayName("Cancellation Completed")]
    public partial record CancellationCompleted : InstructionCancellationRequestStatus11Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
