// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice
{
    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    public record OriginalMandate : OriginalMandate11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlMndt")]
        public required Mandate22 Value { get; init; }
    }
}
