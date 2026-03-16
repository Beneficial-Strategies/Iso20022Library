// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus67Choice
{
    /// <summary>
    /// Instruction has been cancelled. The status on the processing of a cancellation request must be provided using a cancellation request report message.
    /// </summary>
    [IsoId("_XD6lMeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus67Choice_ { }
}
