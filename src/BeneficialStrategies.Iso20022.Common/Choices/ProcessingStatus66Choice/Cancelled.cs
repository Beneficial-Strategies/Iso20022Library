// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus66Choice
{
    /// <summary>
    /// Instruction has been cancelled. The status on the processing of a cancellation request must be provided using a cancellation request report message.
    /// </summary>
    [IsoId("_BvN4geFUEeWIA4E9cYSxxQ")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus66Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
