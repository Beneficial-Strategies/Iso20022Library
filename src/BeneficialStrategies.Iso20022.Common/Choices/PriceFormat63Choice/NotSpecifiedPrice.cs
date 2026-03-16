// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat63Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_SDqHYQ-zEeuE0Pnt-OcNOA")]
    [DisplayName("Not Specified Price")]
    public record NotSpecifiedPrice : PriceFormat63Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of price is unspecified.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType13Code Value { get; init; }
    }
}
