// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice
{
    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    public record OriginalMandate : OriginalMandate10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlMndt")]
        public required Mandate20 Value { get; init; }
    }
}
