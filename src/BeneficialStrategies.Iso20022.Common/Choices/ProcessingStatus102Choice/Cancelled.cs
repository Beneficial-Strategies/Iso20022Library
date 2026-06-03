// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice
{
    /// <summary>Specifies the cancelled status.</summary>
    [IsoId("cb6e3304-caaa-426d-8f13-ceb1733b6124")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus102Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus16Choice_ Value { get; init; }
    }
}
