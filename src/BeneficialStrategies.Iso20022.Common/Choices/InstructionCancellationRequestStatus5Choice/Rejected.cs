// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus5Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_lFW2bQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionCancellationRequestStatus5Choice_ { }
}
