// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption47Choice
{
    /// <summary>Proprietary identification of the type of corporate action options.</summary>
    [IsoId("_Rh4CBQ7VEfC-6PbsYHIdig")]
    [DisplayName("Proprietary")]
    public record Proprietary : CorporateActionOption47Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
