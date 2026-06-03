// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PendingReason78Choice
{
    /// <summary>Specifies the reason why the instruction has a pending status.</summary>
    [IsoId("09876d53-0351-496f-9b9b-5abc840ccd0a")]
    [DisplayName("Code")]
    public record Code : PendingReason78Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required PendingReason33Code Value { get; init; }
    }
}
