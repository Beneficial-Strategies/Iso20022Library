// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus14Choice
{
    /// <summary>
    /// A cancellation request from yourself for this instruction is pending waiting for further processing (only as an response to an SecuritiesTransactionStatusQuery). The pending status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_EsWwESRhEeO8sskhVI3IDA")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionProcessingStatus14Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
