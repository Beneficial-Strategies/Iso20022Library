// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus7Choice
{
    /// <summary>
    /// Provides status information related to a pending cancellation request.
    /// </summary>
    [IsoId("_NeZZe1hkEeSsH9MSoogb7Q")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : InstructionCancellationRequestStatus7Choice_ { }
}
