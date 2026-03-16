// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus11Choice
{
    /// <summary>
    /// Reason not specified.
    /// </summary>
    [IsoId("_0WViYRUOEeuYppTwWp55gA")]
    [DisplayName("Not Specified Reason")]
    public record NotSpecifiedReason : PendingCancellationStatus11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NotSpcfdRsn")]
        public required NoReasonCode Value { get; init; }
    }
}
