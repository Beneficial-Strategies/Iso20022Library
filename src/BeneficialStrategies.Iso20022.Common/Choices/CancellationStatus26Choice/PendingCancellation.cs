// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus26Choice
{
    /// <summary>
    /// Status advising that the instruction cancellation request is pending and advising on the reason for the pending status.
    /// </summary>
    [IsoId("_7I3wILKfEemux5trsZcCpw")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : CancellationStatus26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingCancellationStatus10Choice_ Value { get; init; }
    }
}
