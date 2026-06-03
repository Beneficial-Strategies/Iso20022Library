// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References87Choice
{
    /// <summary>Specifies the other reference.</summary>
    [IsoId("2b074670-a615-4797-b6c1-6155ca7c2a77")]
    [DisplayName("Other Reference")]
    public record OtherReference : References87Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OthrRef")]
        public required AdditionalReference10 Value { get; init; }
    }
}
