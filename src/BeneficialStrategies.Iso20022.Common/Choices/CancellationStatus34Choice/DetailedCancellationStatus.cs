// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus34Choice
{
    /// <summary>Status of individual instruction cancellation requests received within the instruction cancellation message.</summary>
    [IsoId("_c87iY68uEfCx2aBifPEdRg")]
    [DisplayName("Detailed Cancellation Status")]
    public record DetailedCancellationStatus : CancellationStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtldCxlSts")]
        public required DetailedInstructionCancellationStatus16 Value { get; init; }
    }
}
