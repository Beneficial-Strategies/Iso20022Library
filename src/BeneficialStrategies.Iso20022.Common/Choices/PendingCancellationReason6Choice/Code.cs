// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason6Choice
{
    /// <summary>
    /// Standard code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_86aToZwtEeazcsnODTksnQ")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the cancellation request has a pending status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason5Code Value { get; init; }
    }
}
