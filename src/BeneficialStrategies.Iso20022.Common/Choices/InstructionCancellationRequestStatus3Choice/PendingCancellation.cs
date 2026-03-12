// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus3Choice
{
    /// <summary>
    /// Provides status information related to a pending cancellation request.
    /// </summary>
    [IsoId("_V4EH6eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionCancellationRequestStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
