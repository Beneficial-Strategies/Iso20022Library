// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus35Choice
{
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// </summary>
    [IsoId("_iE4OlffZEeiNZp_PtLohLw")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus35Choice_ { }
}
