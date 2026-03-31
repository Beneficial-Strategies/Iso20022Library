// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus3Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request accepted for further processing.
    /// </summary>
    [IsoId("_V4EH5eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Accepted")]
    public record Accepted : InstructionCancellationRequestStatus3Choice_ { }
}
