// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification5Choice
{
    /// <summary>
    /// Market Identifier Code.
    /// </summary>
    [DisplayName("Market Identifier Code")]
    public record MarketIdentifierCode : MarketIdentification5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MktIdrCd")]
        public required IsoMICIdentifier Value { get; init; }
    }
}
