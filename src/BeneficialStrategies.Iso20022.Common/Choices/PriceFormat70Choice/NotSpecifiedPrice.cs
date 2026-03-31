// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat70Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_p4jBcTi7Eeydid5dcNPKvg")]
    [DisplayName("Not Specified Price")]
    public record NotSpecifiedPrice : PriceFormat70Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of price value.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType8Code Value { get; init; }
    }
}
