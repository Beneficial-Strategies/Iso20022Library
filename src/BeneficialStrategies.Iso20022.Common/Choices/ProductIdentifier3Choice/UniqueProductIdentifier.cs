// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductIdentifier3Choice
{
    /// <summary>
    /// Unique Product Identifier.
    /// </summary>
    [DisplayName("Unique Product Identifier")]
    public record UniqueProductIdentifier : ProductIdentifier3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UnqPdctIdr")]
        public required IsoMax12Text Value { get; init; }
    }
}
