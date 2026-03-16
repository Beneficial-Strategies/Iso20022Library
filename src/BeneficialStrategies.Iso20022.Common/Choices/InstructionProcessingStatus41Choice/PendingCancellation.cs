// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus41Choice
{
    /// <summary>
    /// Cancellation instruction is pending.
    /// </summary>
    [IsoId("_4YiuFe6KEeqc-LCjwLsUVg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus41Choice_ { }
}
