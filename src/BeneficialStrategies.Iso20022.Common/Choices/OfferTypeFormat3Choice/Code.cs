// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the conditions that apply to the offer.
    /// </summary>
    [IsoId("_rTiaRS87EeKNZpaVtgp8Wg")]
    [DisplayName("Code")]
    public record Code : OfferTypeFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions that apply to the offer.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OfferType2Code Value { get; init; }
    }
}
