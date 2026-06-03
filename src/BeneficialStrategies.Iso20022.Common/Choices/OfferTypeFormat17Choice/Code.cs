// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat17Choice
{
    /// <summary>Standard code to specify the conditions that apply to the offer.</summary>
    [IsoId("52aeca94-561d-4e8f-aac0-1bb077d6977f")]
    [DisplayName("Code")]
    public record Code : OfferTypeFormat17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required OfferType6Code Value { get; init; }
    }
}
