// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OfferType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the conditions that apply to the offer.
    /// </summary>
    [IsoId("_Rm2nE9p-Ed-ak6NoX_4Aeg_-312003599")]
    [DisplayName("Code")]
    public record Code : OfferType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions that apply to the offer.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OfferType1Code Value { get; init; }
    }
}
