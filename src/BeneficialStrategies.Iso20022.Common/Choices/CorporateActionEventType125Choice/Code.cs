// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType125Choice
{
    /// <summary>Event type expressed as a code.</summary>
    [IsoId("_zwH4c9_MEe-Ned3-G07x_A")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType125Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType41Code Value { get; init; }
    }
}
