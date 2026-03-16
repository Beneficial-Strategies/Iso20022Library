// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductIdentifier3Choice
{
    /// <summary>
    /// Underlying Product Identifier.
    /// </summary>
    [DisplayName("Underlying Product Identifier")]
    public record UnderlyingProductIdentifier : ProductIdentifier3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UndrlygPdctIdr")]
        public required UnderlyingProductIdentifier1Code Value { get; init; }
    }
}
