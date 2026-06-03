// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice
{
    /// <summary>Specifies the cancelled status.</summary>
    [IsoId("cea44f51-0e5e-4e1a-a82a-cf55e6728b0e")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus103Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus24Choice_ Value { get; init; }
    }
}
