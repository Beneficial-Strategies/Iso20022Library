// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus36Choice
{
    /// <summary>
    /// Cancellation instruction is pending.
    /// </summary>
    [IsoId("_U39JNf0oEeiKOe8GCUL1Lg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus36Choice_ { }
}
