// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus82Choice
{
    /// <summary>
    /// Cancellation request is pending on the instruction.
    /// </summary>
    [IsoId("_FjyNSRIwEeydmIVkS03esw")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus56Choice_ Value { get; init; }
    }
}
