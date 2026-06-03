// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatus6Choice
{
    /// <summary>Specifies the reason of the modification status.</summary>
    [IsoId("a7ea634d-4026-409c-8921-e68cd77303ed")]
    [DisplayName("Reason")]
    public record Reason : ModificationStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required ModificationReason4 Value { get; init; }
    }
}
