// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormatSD3Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_VnaHhcSREeeRJJtE9TSlkw")]
    [DisplayName("Not Specified Price")]
    public record NotSpecifiedPrice : PriceFormatSD3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType10Code Value { get; init; }
    }
}
