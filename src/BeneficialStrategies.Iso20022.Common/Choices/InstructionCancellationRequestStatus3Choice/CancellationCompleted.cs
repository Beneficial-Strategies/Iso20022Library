// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus3Choice
{
    /// <summary>
    /// Provides status information related to a instruction cancellation request completed.
    /// </summary>
    [IsoId("_V4EH4-JxEd-Q6MzBzY5WkA")]
    [DisplayName("Cancellation Completed")]
    public partial record CancellationCompleted : InstructionCancellationRequestStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlCmpltd")]
        public required CancelledStatus3Choice_ Value { get; init; }
    }
}
