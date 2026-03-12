// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus6Choice
{
    /// <summary>
    /// A cancellation request from yourself for this instruction is pending waiting for further processing (only as an response to an SecuritiesTransactionStatusQuery). The pending status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_UVMcqNp-Ed-ak6NoX_4Aeg_85776256")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
