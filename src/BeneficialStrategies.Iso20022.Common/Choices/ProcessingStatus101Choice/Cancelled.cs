// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the cancelled status.</summary>
    [IsoId("d839e65e-74c4-4571-8e5f-3d02ee9e326d")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Canc")]
        public required CancellationStatus24Choice_ Value { get; init; }
    }
}
