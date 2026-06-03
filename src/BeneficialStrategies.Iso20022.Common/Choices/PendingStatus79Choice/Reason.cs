// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus79Choice
{
    /// <summary>Specifies the reason of the pending status.</summary>
    [IsoId("_X5NnieSkEe-qVZLXW4RRBw")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus79Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required PendingReason34 Value { get; init; }
    }
}
