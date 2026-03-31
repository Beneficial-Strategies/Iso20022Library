// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus22Choice
{
    /// <summary>
    /// Status of the order cancellation request is cancelled.
    /// </summary>
    [IsoId("_0syLAkgsEeaD2L_hzZaE0w")]
    [DisplayName("Status")]
    public record Status : CancellationStatus22Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the current status of the order cancellation request.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required OrderCancellationStatus2Code Value { get; init; }
    }
}
