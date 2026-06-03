// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus17Choice
{
    /// <summary>Specifies the reason of the failing status.</summary>
    [IsoId("_0o3p6eSkEe-qVZLXW4RRBw")]
    [DisplayName("Reason")]
    public record Reason : FailingStatus17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required FailingReason15 Value { get; init; }
    }
}
