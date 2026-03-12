// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus3Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_V4EH5-JxEd-Q6MzBzY5WkA")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionCancellationRequestStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
