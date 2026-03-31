// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus71Choice
{
    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    public record Reason : PendingStatus71Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required PendingStatusReason27 Value { get; init; }
    }
}
