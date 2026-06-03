// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason83Choice
{
    /// <summary>Standard code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_Herj4bMaEfCEXew4g5B5oA")]
    [DisplayName("Code")]
    public record Code : PendingReason83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason39Code Value { get; init; }
    }
}
