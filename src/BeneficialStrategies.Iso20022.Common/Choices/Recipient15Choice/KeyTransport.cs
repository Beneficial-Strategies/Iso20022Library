// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient15Choice
{
    /// <summary>
    /// Key Transport.
    /// </summary>
    [DisplayName("Key Transport")]
    public record KeyTransport : Recipient15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("KeyTrnsprt")]
        public required KeyTransport10 Value { get; init; }
    }
}
