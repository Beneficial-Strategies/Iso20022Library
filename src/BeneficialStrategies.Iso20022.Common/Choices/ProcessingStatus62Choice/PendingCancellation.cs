// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus62Choice
{
    /// <summary>
    /// A cancellation request from yourself for this instruction is pending waiting for further processing (only as a response to a SecuritiesTransactionStatusQuery). The pending status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_6d7voZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus62Choice_ { }
}
