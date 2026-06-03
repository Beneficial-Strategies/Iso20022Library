// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason75Choice
{
    /// <summary>Specifies the reason why the instruction has a pending status.</summary>
    [IsoId("_YQ2EYeSkEe-qVZLXW4RRBw")]
    [DisplayName("Code")]
    public record Code : PendingReason75Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason31Code Value { get; init; }
    }
}
