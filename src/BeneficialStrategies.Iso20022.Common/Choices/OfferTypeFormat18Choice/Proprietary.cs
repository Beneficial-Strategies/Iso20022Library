// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat18Choice
{
    /// <summary>Proprietary identification of the conditions that apply to the offer.</summary>
    [IsoId("_h_uUs_IHEfCS-OXqezZQmw")]
    [DisplayName("Proprietary")]
    public record Proprietary : OfferTypeFormat18Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
