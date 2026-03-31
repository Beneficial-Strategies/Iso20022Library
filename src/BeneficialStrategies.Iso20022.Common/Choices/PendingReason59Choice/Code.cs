// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason59Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [IsoId("_hB_wsRHpEeuE0Pnt-OcNOA")]
    [DisplayName("Code")]
    public record Code : PendingReason59Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason22Code Value { get; init; }
    }
}
