// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice
{
    /// <summary>Specifies the pending cancellation status.</summary>
    [IsoId("1c0b1556-db68-4183-8d86-baf11eb70084")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus101Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxl")]
        public required PendingStatus81Choice_ Value { get; init; }
    }
}
