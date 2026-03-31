// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountPriceType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the amount price type.
    /// </summary>
    [IsoId("_RlqUQtp-Ed-ak6NoX_4Aeg_221154567")]
    [DisplayName("Code")]
    public record Code : AmountPriceType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the amount price type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AmountPriceType1Code Value { get; init; }
    }
}
