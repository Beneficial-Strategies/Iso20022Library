// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice
{
    /// <summary>
    /// Original Mandate Identification.
    /// </summary>
    [DisplayName("Original Mandate Identification")]
    public record OriginalMandateIdentification : OriginalMandate10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlMndtId")]
        public required IsoMax35Text Value { get; init; }
    }
}
