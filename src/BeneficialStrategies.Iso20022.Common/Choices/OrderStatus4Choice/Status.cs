// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice
{
    /// <summary>
    /// Status of the switch order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_9wxHwUH8EeaV3ab_pHzFIQ")]
    [DisplayName("Status")]
    public record Status : OrderStatus4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the current status of the order.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required OrderStatus4Code Value { get; init; }
    }
}
