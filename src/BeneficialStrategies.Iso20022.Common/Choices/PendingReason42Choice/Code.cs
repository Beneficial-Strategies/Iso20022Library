// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason42Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_6QESbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : PendingReason42Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a cancellation request sent for the related instruction is pending.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason9Code Value { get; init; }
    }
}
