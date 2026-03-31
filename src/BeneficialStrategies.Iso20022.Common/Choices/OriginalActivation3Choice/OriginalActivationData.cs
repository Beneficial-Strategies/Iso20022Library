// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice
{
    /// <summary>
    /// Original Activation Data.
    /// </summary>
    [DisplayName("Original Activation Data")]
    public record OriginalActivationData : OriginalActivation3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlActvtnData")]
        public required DebtorActivation5 Value { get; init; }
    }
}
