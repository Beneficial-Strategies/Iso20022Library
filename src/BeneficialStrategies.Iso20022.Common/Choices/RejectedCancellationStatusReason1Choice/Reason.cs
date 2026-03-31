// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedCancellationStatusReason1Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RXptddp-Ed-ak6NoX_4Aeg_890850306")]
    [DisplayName("Reason")]
    public record Reason : RejectedCancellationStatusReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Reason for which a cancellation is rejected.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required RejectedCancellationStatusReason1Code Value { get; init; }
    }
}
