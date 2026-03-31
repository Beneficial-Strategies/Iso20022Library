// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice
{
    /// <summary>
    /// Original Debtor Identification.
    /// </summary>
    [DisplayName("Original Debtor Identification")]
    public record OriginalDebtorIdentification : OriginalActivation3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlDbtrId")]
        public required Party53Choice_ Value { get; init; }
    }
}
