// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuorumQuantity2Choice
{
    /// <summary>
    /// Quorum Quantity.
    /// </summary>
    [DisplayName("Quorum Quantity")]
    public record QuorumQuantity : QuorumQuantity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("QrmQty")]
        public required IsoMax35Text Value { get; init; }
    }
}
