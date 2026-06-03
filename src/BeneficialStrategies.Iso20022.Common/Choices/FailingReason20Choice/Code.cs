// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FailingReason20Choice
{
    /// <summary>Specifies the reason why the instruction has a failing settlement status.</summary>
    [IsoId("_05m0keSkEe-qVZLXW4RRBw")]
    [DisplayName("Code")]
    public record Code : FailingReason20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required FailingReason6Code Value { get; init; }
    }
}
