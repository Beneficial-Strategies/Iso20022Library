// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PenaltyStatus2Choice
{
    /// <summary>Penalty status, in a proprietary form.</summary>
    [IsoId("_-L6hUx-LEeuwwezkzufkMw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PenaltyStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
