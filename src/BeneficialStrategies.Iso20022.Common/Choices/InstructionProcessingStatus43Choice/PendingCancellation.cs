// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus43Choice
{
    /// <summary>
    /// Cancellation instruction is pending.
    /// </summary>
    [IsoId("_pUH1zx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionProcessingStatus43Choice_ { }
}
