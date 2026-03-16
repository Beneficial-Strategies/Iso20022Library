// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement13Choice
{
    /// <summary>
    /// Status Advice.
    /// </summary>
    [DisplayName("Status Advice")]
    public record StatusAdvice : StatusOrStatement13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StsAdvc")]
        public required DocumentNumber21 Value { get; init; }
    }
}
