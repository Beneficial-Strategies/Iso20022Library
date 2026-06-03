// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification262Choice
{
    /// <summary>Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.</summary>
    [IsoId("50e6169a-09e0-4d41-b67b-79c8b4d1c5dc")]
    [DisplayName("Proprietary Identification")]
    public record ProprietaryIdentification : PartyIdentification262Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrtryId")]
        public required GenericIdentification1 Value { get; init; }
    }
}
