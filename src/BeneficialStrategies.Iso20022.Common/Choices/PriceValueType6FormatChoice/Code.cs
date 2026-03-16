// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceValueType6FormatChoice
{
    /// <summary>
    /// Standard code to specify the value of a price.
    /// </summary>
    [IsoId("_RnJiAdp-Ed-ak6NoX_4Aeg_124226664")]
    [DisplayName("Code")]
    public record Code : PriceValueType6FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PriceValueType6Code Value { get; init; }
    }
}
