// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat25Choice
{
    /// <summary>Proprietary identification of the additional business process linked to a corporate action event.</summary>
    [IsoId("_beEymaNYEfC9id413JK-Ig")]
    [DisplayName("Proprietary")]
    public record Proprietary : AdditionalBusinessProcessFormat25Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
