// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus13Choice
{
    /// <summary>
    /// Provides status information related to an instruction cancellation request completed.
    /// </summary>
    [IsoId("_V5aGgxn0EeyroI8qKgB7Mg")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : InstructionCancellationRequestStatus13Choice_ { }
}
