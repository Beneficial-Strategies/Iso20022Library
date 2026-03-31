// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat9Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_Q2Resdp-Ed-ak6NoX_4Aeg_856668280")]
    [DisplayName("Not Specified Price")]
    public record NotSpecifiedPrice : PriceFormat9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of price value.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType4Code Value { get; init; }
    }
}
