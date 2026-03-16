// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus31Choice
{
    /// <summary>
    /// Detailed Cancellation Status.
    /// </summary>
    [DisplayName("Detailed Cancellation Status")]
    public record DetailedCancellationStatus : CancellationStatus31Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtldCxlSts")]
        public required DetailedInstructionCancellationStatus15 Value { get; init; }
    }
}
