// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat78Choice
{
    /// <summary>
    /// Not Specified Price.
    /// </summary>
    [DisplayName("Not Specified Price")]
    public record NotSpecifiedPrice : PriceFormat78Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType9Code Value { get; init; }
    }
}
