// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus83Choice
{
    /// <summary>
    /// Instruction has been cancelled (only as a response to a SecuritiesTransactionStatusQuery). The status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
    /// </summary>
    [IsoId("_NAqkpStVEeyhipY4f42fZQ")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus83Choice_ { }
}
