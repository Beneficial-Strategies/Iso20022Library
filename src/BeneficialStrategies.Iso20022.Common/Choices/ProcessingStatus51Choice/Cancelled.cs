// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus51Choice
{
    /// <summary>
    /// Instruction has been cancelled (only as a response to a SecuritiesTransactionStatusQuery). The status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_jWWVlTnvEeWfSKvvZlhRKg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus51Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
