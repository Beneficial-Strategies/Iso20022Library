// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus3Choice
{
    /// <summary>
    /// Instruction has been cancelled (only as an response to an SecuritiesTransactionStatusQuery). The status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_ifpDW_4wEeClUvPNHKL9Zw")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : IntraPositionProcessingStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
