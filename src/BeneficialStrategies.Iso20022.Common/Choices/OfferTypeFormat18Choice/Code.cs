// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat18Choice
{
    /// <summary>Standard code to specify the conditions that apply to the offer.</summary>
    [IsoId("_h_uUsfIHEfCS-OXqezZQmw")]
    [DisplayName("Code")]
    public record Code : OfferTypeFormat18Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required OfferType7Code Value { get; init; }
    }
}
