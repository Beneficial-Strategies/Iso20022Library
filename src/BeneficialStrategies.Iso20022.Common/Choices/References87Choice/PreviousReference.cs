// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References87Choice
{
    /// <summary>Specifies the previous reference.</summary>
    [IsoId("2fb7d904-23b3-493e-8127-9f3966c4a9db")]
    [DisplayName("Previous Reference")]
    public record PreviousReference : References87Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PrvsRef")]
        public required AdditionalReference10 Value { get; init; }
    }
}
