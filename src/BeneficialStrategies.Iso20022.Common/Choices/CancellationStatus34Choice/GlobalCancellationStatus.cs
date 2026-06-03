// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus34Choice
{
    /// <summary>Status applicable globally to the meeting instruction cancellation request message.</summary>
    [IsoId("_c87iYa8uEfCx2aBifPEdRg")]
    [DisplayName("Global Cancellation Status")]
    public record GlobalCancellationStatus : CancellationStatus34Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GblCxlSts")]
        public required CancellationStatus35Choice_ Value { get; init; }
    }
}
