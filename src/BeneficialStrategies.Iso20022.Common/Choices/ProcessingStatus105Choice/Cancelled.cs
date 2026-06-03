// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice
{
    /// <summary>Specifies the cancelled status.</summary>
    [IsoId("_u9DESaodEfCG2_q2WT-90w")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus105Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus15Choice_ Value { get; init; }
    }
}
