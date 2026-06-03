// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason77Choice
{
    /// <summary>Specifies the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_DQbLxqn7EfCG2_q2WT-90w")]
    [DisplayName("Code")]
    public record Code : PendingReason77Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason32Code Value { get; init; }
    }
}
