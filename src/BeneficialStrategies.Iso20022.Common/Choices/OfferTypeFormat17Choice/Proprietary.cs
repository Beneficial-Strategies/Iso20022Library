// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OfferTypeFormat17Choice
{
    /// <summary>Proprietary identification of the conditions that apply to the offer.</summary>
    [IsoId("29abb297-522a-49f1-89d8-2d751f284906")]
    [DisplayName("Proprietary")]
    public record Proprietary : OfferTypeFormat17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
