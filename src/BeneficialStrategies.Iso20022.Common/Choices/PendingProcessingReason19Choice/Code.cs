// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason19Choice
{
    /// <summary>Specifies the reason why the instruction has a pending processing status.</summary>
    [IsoId("483be376-4a3d-44e6-9d9c-cb33173cf871")]
    [DisplayName("Code")]
    public record Code : PendingProcessingReason19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason5Code Value { get; init; }
    }
}
