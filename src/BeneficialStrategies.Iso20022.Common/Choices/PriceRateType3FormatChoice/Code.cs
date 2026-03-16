// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateType3FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of price rate.
    /// </summary>
    [IsoId("_RnAYFNp-Ed-ak6NoX_4Aeg_-1976498594")]
    [DisplayName("Code")]
    public record Code : PriceRateType3FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of price rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PriceRateType3Code Value { get; init; }
    }
}
