// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReason8Choice
{
    /// <summary>
    /// Standard code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_0_EWURUOEeuYppTwWp55gA")]
    [DisplayName("Code")]
    public record Code : PendingCancellationReason8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingCancellationReason7Code Value { get; init; }
    }
}
